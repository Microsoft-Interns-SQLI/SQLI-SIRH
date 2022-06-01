
using API_MySIRH.DTOs;
using API_MySIRH.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API_MySIRH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CarriereController : ControllerBase
    {
        private readonly ICarriereService _carriereService;
        public CarriereController(ICarriereService carriereService)
        {
            this._carriereService = carriereService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CarriereDTO>?>> GetAll()
        {
            return Ok(await this._carriereService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CarriereDTO?>> GetById(int id)
        {
            var carriere = await this._carriereService.FindById(id);
            return carriere is not null ? Ok(carriere) : NotFound();
        }

        [HttpGet("Carrieres-du-collab-{id}")]
        public async Task<ActionResult<IEnumerable<CarriereDTO>?>> GetAllByCollab(int id)
        {
            return await this._carriereService.GetAllByCollab(id);
        }

        [HttpPost]
        public async Task<ActionResult<CarriereDTO?>> Add(CarriereDTO carriereDTO)
        {
            return Ok(await this._carriereService.Add(carriereDTO));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, CarriereDTO carriereDTO)
        {
            if (id != carriereDTO.Id)
            {
                return BadRequest();
            }
            try
            {
                await this._carriereService.Update(carriereDTO);
            }
            catch
            {
                throw;
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (!await this._carriereService.Exists(id))
                return NotFound();
            var carrierToDelete = await this._carriereService.FindById(id);
            await this._carriereService.Delete(carrierToDelete!);
            return NoContent();
        }

    }
}