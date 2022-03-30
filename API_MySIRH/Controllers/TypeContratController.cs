using API_MySIRH.DTOs;
using API_MySIRH.Entities;
using API_MySIRH.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_MySIRH.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TypeContratController : ControllerBase
    {
        private readonly ITypeContratService _iTypeContrat;

        public TypeContratController(ITypeContratService iTypeContrat)
        {
            _iTypeContrat = iTypeContrat;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TypeContratDto>> get(int id)
        {
            var type = await _iTypeContrat.GetById(id);
            if (type != null)
                return Ok(type);
            else
            {
                return NotFound();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TypeContratDto>>> get()
        {
            var type = await _iTypeContrat.GetAll();
            if (type != null)
                return Ok(type);
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public async Task<ActionResult<TypeContratDto>> post([FromBody] TypeContratDto type)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _iTypeContrat.Add(type);
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

        [HttpPut("{id}")]
        public async Task<IActionResult> update(int id, [FromBody] TypeContratDto type)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _iTypeContrat.Update(id, type);
                }
                catch(Exception ex)
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

        [HttpDelete("{id}")]
        public async Task<IActionResult> delete(int id)
        {
            try
            {
                await _iTypeContrat.Delete(id);
            }
            catch(Exception ex)
            {
                return NotFound(ex.Message);
            }

            return Ok($"Type of contract with id : {id} deleted successfully!");
        }
    }
}
