using API_MySIRH.Data;
using API_MySIRH.DTOs;
using API_MySIRH.Entities;
using API_MySIRH.Interfaces;
using API_MySIRH.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace API_MySIRH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollaborateursController : ControllerBase
    {
        private readonly ICollaborateurService _collaborateurService;

        public CollaborateursController(ICollaborateurService collaborateurService)
        {
            this._collaborateurService = collaborateurService;
        }

        [HttpGet]
        public async Task<ActionResult<PagedCollectionResponse<CollaborateurDTO>>> GetCollaborateurs([FromQuery] FilterModel filterModel)
        {
            IEnumerable<CollaborateurDTO> collabs = await Task.FromResult<IEnumerable<CollaborateurDTO>>(await this._collaborateurService.GetCollaborateurs());

            Func<FilterModel, IEnumerable<CollaborateurDTO>> filterData = (filterModel) =>
            {
                return collabs.Where(p => p.Nom.StartsWith(filterModel.Term ?? String.Empty, StringComparison.InvariantCultureIgnoreCase))
                .Skip((filterModel.Page - 1) * filterModel.Limit)
                .Take(filterModel.Limit);
            };

            var result = new PagedCollectionResponse<CollaborateurDTO>();
            result.Items = filterData(filterModel);

            FilterModel nextFilter = filterModel.Clone() as FilterModel;
            nextFilter.Page += 1;
            String nextUrl = filterData(nextFilter).Count() <= 0 ? null : this.Url.Action(nameof(GetCollaborateurs), null, nextFilter, Request.Scheme);

            FilterModel previousFilter = filterModel.Clone() as FilterModel;
            previousFilter.Page -= 1;
            String previousUrl = previousFilter.Page <= 0 ? null : this.Url.Action(nameof(GetCollaborateurs), null, previousFilter, Request.Scheme);

            result.NextPage = !String.IsNullOrWhiteSpace(nextUrl) ? new Uri(nextUrl) : null;
            result.PreviousPage = !String.IsNullOrWhiteSpace(previousUrl) ? new Uri(previousUrl) : null;
            result.Total = collabs.Count();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CollaborateurDTO>> GetCollaborateur(int id)
        {
            return Ok(await this._collaborateurService.GetCollaborateur(id));
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
            var collaborateur = await this._collaborateurService.GetCollaborateur(id);
            if (collaborateur is null)
                return NotFound();
            await this._collaborateurService.DeleteCollaborateur(id);
            return NoContent();
        }
    }
}