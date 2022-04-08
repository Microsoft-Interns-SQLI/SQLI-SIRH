using API_MySIRH.DTOs;
using API_MySIRH.Interfaces;
using Microsoft.AspNetCore.Mvc;
using API_MySIRH.Helpers;
using API_MySIRH.Extentions;
using Syncfusion.XlsIO;
using System.Collections;
using AutoMapper;
using API_MySIRH.Entities;

namespace API_MySIRH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize()]
    public class CollaborateursController : ControllerBase
    {
        private readonly ICollaborateurService _collaborateurService;
        private readonly IMapper _mapper;


        public CollaborateursController(ICollaborateurService collaborateurService, IMapper mapper)
        {
            _collaborateurService = collaborateurService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CollaborateurDTO>>> GetCollaborateurs([FromQuery] FilterParams filterParams)
        {
            var collabs = await _collaborateurService.GetCollaborateurs(filterParams);
            Response.AddPaginationHeader(collabs.CurrentPage, collabs.PageSize, collabs.TotalCount, collabs.TotalPages);
            return Ok(collabs);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CollaborateurDTO>> GetCollaborateur(int id)
        {
            return Ok(await this._collaborateurService.GetCollaborateurById(id));
        }

        [HttpPost]
        public async Task<ActionResult> AddCollaborateur(CollaborateurDTO collaborateurDTO)
        {
            var collaborateurToCreate = await this._collaborateurService.AddCollaborateur(collaborateurDTO);
            return CreatedAtAction(nameof(GetCollaborateurs), new { id = collaborateurToCreate.Id }, collaborateurToCreate);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<CollaborateurDTO>> UpdateCollaborateur(int id, CollaborateurDTO collaborateurDTO)
        {
            if (id != collaborateurDTO.Id)
            {
                return BadRequest();
            }
            try
            {
                await this._collaborateurService.UpdateCollaborateur(id, collaborateurDTO);
            }
            catch
            {
                throw;
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCollaborateur(int id)
        {
            var collaborateur = await this._collaborateurService.GetCollaborateurById(id);
            if (collaborateur is null)
                return NotFound();
            await this._collaborateurService.DeleteCollaborateur(id);
            return NoContent();
        }

        [HttpPost("import")]
        public async Task<IActionResult> UploadFileCSV([FromForm] IFormFile file)
        {
            //Save Excel file into Archive folder
            await ImportFeatures.UploadFileLocaly(file);

            var list = ImportFeatures.ConvertToList(file);

            foreach (var collaborateur in list)
            {
                await InvokeOperation(collaborateur);
            }


            return Ok();
        }

        private async Task InvokeOperation(Collaborateur collaborateur)
        {
            //if collab is not a freelancer
            if (collaborateur.Matricule != "0")
            {
                if (await _collaborateurService.CollaborateurExistsByMatricule(collaborateur.Matricule))
                {
                    var collab = await _collaborateurService.GetCollaborateurByMatricule(collaborateur.Matricule);
                    var collabDto = _mapper.Map<CollaborateurDTO>(collaborateur);
                    collabDto.Id = collab.Id;
                    await _collaborateurService.UpdateCollaborateur(collab.Id, collabDto);
                }
                else
                {
                    await _collaborateurService.AddCollaborateur(_mapper.Map<CollaborateurDTO>(collaborateur));
                }
            }
            //if collab ==> freelancer (freelancer doesn't have a matricule so we verify by email)
            else
            {
                if (await _collaborateurService.CollaborateurExistsByEmail(collaborateur.Email))
                {
                    var collab = await _collaborateurService.GetCollaborateurByEmail(collaborateur.Email);
                    var collabDto = _mapper.Map<CollaborateurDTO>(collaborateur);
                    collabDto.Id = collab.Id;

                    await _collaborateurService.UpdateCollaborateur(collab.Id, collabDto);
                }
                else
                {
                    await _collaborateurService.AddCollaborateur(_mapper.Map<CollaborateurDTO>(collaborateur));
                }
            }
        }
    }
}