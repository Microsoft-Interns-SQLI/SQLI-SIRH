using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_MySIRH.DTOs;
using API_MySIRH.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API_MySIRH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize()]
    public class DiplomesController : ControllerBase
    {
        private readonly IDiplomeService _diplomeService;
        private readonly ICollaborateurRepository _collaborateurRepository;
        private readonly IMapper _mapper;
        public DiplomesController(IDiplomeService diplomeService, ICollaborateurRepository collaborateurRepository, IMapper mapper)
        {
            this._diplomeService = diplomeService;
            this._collaborateurRepository = collaborateurRepository;
            this._mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DiplomeDTO>>> GetAllDiplomes()
        {
            return await this._diplomeService.GetAllDiplomes();
        }

        [HttpGet("collab-{idCollab}")]
        public async Task<ActionResult<IEnumerable<DiplomeDTO>>> GetCollabDiplomes(int idCollab)
        {
            if (await this._collaborateurRepository.CollaborateurExistsById(idCollab))
                return Ok(await this._diplomeService.GetCollabDiplomes(idCollab));
            return NotFound();
        }

        [HttpPost]
        public async Task<ActionResult<CollaborateurDTO>> AddDiplomeToCollab(DiplomeDTO diplomeDTO)
        {
            var diplome = await this._diplomeService.AddDiplomeToCollab(diplomeDTO);
            return CreatedAtAction(nameof(GetAllDiplomes), new { id = diplome.Id }, diplome);
        }

        [HttpPut("{diplomeId}")]
        public async Task<ActionResult> UpdateDiplome(int diplomeId, DiplomeDTO diplomeDTO)
        {
            if (diplomeDTO.Id != diplomeId)
                return BadRequest();
            try
            {
                await this._diplomeService.UpdateCollabDiplome(diplomeDTO);
            }
            catch
            {
                throw;
            }
            return NoContent();
        }

        [HttpDelete("{diplomeId}")]
        public async Task<ActionResult> DeleteDiplome(int diplomeId)
        {
            if (!await this._diplomeService.Exists(diplomeId))
                return NotFound();
            await this._diplomeService.DeleteDiplomeToCollab(diplomeId);
            return NoContent();
        }

    }
}