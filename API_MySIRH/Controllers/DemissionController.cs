using API_MySIRH.DTOs;
using API_MySIRH.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_MySIRH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemissionController : ControllerBase
    {
        private readonly IDemissionService _demissionService;

        public DemissionController(IDemissionService demissionService)
        {
            _demissionService = demissionService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CollaborateurDTO>>> GetDemissions()
        {
            var res = _demissionService.GetCollaborateursDemissioned();
            return Ok(res);
        }
        [HttpPost]
        public async Task<ActionResult> AddDemission(DemissionDTO demissionDTO)
        {
            throw new NotImplementedException();
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateDemission(int id, DemissionDTO demissionDTO)
        {
            throw new NotImplementedException();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> AddDemission(int id)
        {
            throw new NotImplementedException();
        }
    }
}
