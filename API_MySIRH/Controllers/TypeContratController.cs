using API_MySIRH.DTOs;
using API_MySIRH.Entities;
using API_MySIRH.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_MySIRH.Controllers
{
    public class TypeContratController : MdmController<TypeContrat, TypeContratDTO>
    {
        public TypeContratController(IMdmService<TypeContrat, TypeContratDTO> mdmService) : base(mdmService)
        {
        }

        [HttpGet("contrats/{id}")]
        public async Task<ActionResult<TypeContratDTO>> get(int id)
        {
            var type = await _mdmService.GetById(id);
            if (type != null)
                return Ok(type);
            else
            {
                return NotFound();
            }
        }
        [HttpGet("contrats")]
        public async Task<ActionResult<IEnumerable<TypeContratDTO>>> get()
        {
            var type = await _mdmService.GetAll();
            if (type != null)
                return Ok(type);
            else
            {
                return NotFound();
            }
        }

        [HttpPost("contrats")]
        public async Task<ActionResult<TypeContratDTO>> post([FromBody] TypeContratDTO type)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _mdmService.Add(type);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
                return Ok($"Type de contrat : {type.Name} add successfully !");
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut("contrats/{id}")]
        public async Task<IActionResult> update(int id, [FromBody] TypeContratDTO type)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _mdmService.Update(id, type);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
                return Ok($"Type of contract with id : {id} updated successfully!");
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("contrats/{id}")]
        public async Task<IActionResult> delete(int id)
        {
            try
            {
                await _mdmService.Delete(id);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

            return Ok($"Type of contract with id : {id} deleted successfully!");
        }
    }
}
