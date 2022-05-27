using API_MySIRH.DTOs;
using API_MySIRH.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API_MySIRH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize()]
    public class CollaborateurTypeContratsController : ControllerBase
    {
        private readonly ICollaborateurTypeContratService _collaborateurTypeContratService;

        public CollaborateurTypeContratsController(ICollaborateurTypeContratService collaborateurTypeContratService)
        {
            this._collaborateurTypeContratService = collaborateurTypeContratService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CollaborateurTypeContratDTO>>> GetAllCollaborateursTypeContrats()
        {
            var allCollabsTypeContrats = await this._collaborateurTypeContratService.GetAllCollabsContrats();
            return Ok(allCollabsTypeContrats);
        }

        [HttpGet("collaborateur-{idCollaborateur}")]
        public async Task<ActionResult<IEnumerable<CollaborateurTypeContratDTO>>> GetAllCollaborateursTypeContratsByCollab(int idCollaborateur)
        {
            var allCollabsTypeContratsByCollab = await this._collaborateurTypeContratService.GetAllCollabsContratsByCollab(idCollaborateur);
            return Ok(allCollabsTypeContratsByCollab);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CollaborateurTypeContratDTO>> GetOneCollaborateursTypeContrat(int id)
        {
            var collaborateurTypeContrat = await this._collaborateurTypeContratService.GetCollabContratById(id);
            return Ok(collaborateurTypeContrat);
        }

        [HttpPost]
        public async Task<IActionResult> AddCollabContrat(CollaborateurTypeContratDTO collaborateurTypeContratDTO)
        {
            var collabTypeContrat = await this._collaborateurTypeContratService.AddCollabContrat(collaborateurTypeContratDTO);

            return CreatedAtAction(nameof(GetAllCollaborateursTypeContrats), new { id = collabTypeContrat.Id }, collabTypeContrat);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCollabContrat(int id, CollaborateurTypeContratDTO collaborateurTypeContratDTO)
        {
            if (id != collaborateurTypeContratDTO.Id)
            {
                return BadRequest();
            }
            try
            {
                await this._collaborateurTypeContratService.UpdateCollabContrat(collaborateurTypeContratDTO);
            }
            catch
            {
                throw;
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCollabContrat(int id)
        {
            var collabContrat = await this._collaborateurTypeContratService.GetCollabContratById(id);
            if (collabContrat is null)
                return NotFound();
            await this._collaborateurTypeContratService.DeleteCollabContrat(id);
            return NoContent();
        }


        [HttpGet("contrat-{idContrat}")]
        public async Task<ActionResult<IEnumerable<CollaborateurTypeContratDTO>>> GetCollaborateursByContrat(int idContrat)
        {
            var data = await this._collaborateurTypeContratService.GetCollaborateursByContrat(idContrat);
            return Ok(data);
        }

        [HttpGet("contrats-of-collaborateur-{idCollaborateur}")]
        public async Task<ActionResult<IEnumerable<CollaborateurTypeContratDTO>>> GetContratsByCollaborateur(int idCollaborateur)
        {
            var data = await this._collaborateurTypeContratService.GetContratsByCollaborateur(idCollaborateur);
            return Ok(data);
        }
    }
}