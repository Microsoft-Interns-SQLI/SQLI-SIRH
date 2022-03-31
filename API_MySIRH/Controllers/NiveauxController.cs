using API_MySIRH.DTOs;
using API_MySIRH.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API_MySIRH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NiveauxController : ControllerBase
    {
        private readonly INiveauService _niveauService;

        public NiveauxController(INiveauService niveauService)
        {
            _niveauService = niveauService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<NiveauDTO>>> GetNiveaux()
        {
            return Ok(await _niveauService.GetNiveaux());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<NiveauDTO>> GetNiveau(int id)
        {
            return Ok(await _niveauService.GetNiveau(id));
        }

        [HttpPost]
        public async Task<ActionResult> AddNiveau(NiveauDTO niveau)
        {
            var niveauToCreate = await _niveauService.AddNiveau(niveau);
            return CreatedAtAction(nameof(GetNiveaux), new { id = niveauToCreate.Id }, niveauToCreate);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<NiveauDTO>> UpdateNiveau(int id, NiveauDTO niveau)
        {
            if (id != niveau.Id)
            {
                return BadRequest();
            }

            try
            {
                await _niveauService.UpdateNiveau(id, niveau);
            }
            catch
            {
                throw;
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteToDoItem(int id)
        {
            var niveau = await _niveauService.GetNiveau(id);
            if (niveau == null)
            {
                return NotFound();
            }

            await _niveauService.DeleteNiveau(id);

            return NoContent();
        }
    }
}