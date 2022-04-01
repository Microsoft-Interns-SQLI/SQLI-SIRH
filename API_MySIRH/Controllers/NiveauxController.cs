using API_MySIRH.DTOs;
using API_MySIRH.Entities;
using API_MySIRH.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API_MySIRH.Controllers
{
    public class NiveauxController : MdmController<Niveau, NiveauDTO>
    {
        public NiveauxController(IMdmService<Niveau, NiveauDTO> mdmService) : base(mdmService)
        {
        }

        [HttpGet("niveaux")]
        public async Task<ActionResult<IEnumerable<NiveauDTO>>> GetNiveaux()
        {
            return Ok(await _mdmService.GetAll());
        }

        [HttpGet("niveaux/{id}")]
        public async Task<ActionResult<NiveauDTO>> GetNiveau(int id)
        {
            return Ok(await _mdmService.GetById(id));
        }

        [HttpPost("niveaux")]
        public async Task<ActionResult> AddNiveau(NiveauDTO niveau)
        {
            var niveauToCreate = await _mdmService.Add(niveau);
            return CreatedAtAction(nameof(GetNiveau), new { id = niveauToCreate.Id }, niveauToCreate);
        }

        [HttpPut("niveaux/{id}")]
        public async Task<ActionResult<NiveauDTO>> UpdateNiveau(int id, NiveauDTO niveau)
        {
            if (id != niveau.Id)
            {
                return BadRequest();
            }

            try
            {
                await _mdmService.Update(id, niveau);
            }
            catch
            {
                throw;
            }

            return NoContent();
        }

        [HttpDelete("niveaux/{id}")]
        public async Task<IActionResult> DeleteToDoItem(int id)
        {
            var niveau = await _mdmService.GetById(id);
            if (niveau == null)
            {
                return NotFound();
            }

            await _mdmService.Delete(id);

            return NoContent();
        }
    }
}