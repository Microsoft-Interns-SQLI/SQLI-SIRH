using API_MySIRH.DTOs;
using API_MySIRH.Extentions;
using API_MySIRH.Helpers;
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
        public async Task<ActionResult<IEnumerable<CollaborateurDTO>>> GetDemissions([FromQuery] FilterParams filterParams)
        {
            var res = await _demissionService.GetCollaborateursDemissioned(filterParams);
            Response.AddPaginationHeader(res.CurrentPage, res.PageSize, res.TotalCount, res.TotalPages);
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
