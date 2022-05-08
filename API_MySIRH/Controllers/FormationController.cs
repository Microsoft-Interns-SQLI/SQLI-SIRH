using API_MySIRH.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_MySIRH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormationController : ControllerBase
    {
        private readonly IFormationService _formationService;

        public FormationController(IFormationService formationService)
        {
            _formationService = formationService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var formations = await _formationService.GetAll();

            return Ok(formations);
        }
    }
}
