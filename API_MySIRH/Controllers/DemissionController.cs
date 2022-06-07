using API_MySIRH.DTOs;
using API_MySIRH.Entities;
using API_MySIRH.Extentions;
using API_MySIRH.Helpers;
using API_MySIRH.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_MySIRH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize()]
    public class DemissionController : ControllerBase
    {
        private readonly IDemissionService _DemissionService;
        private readonly ICollaborateurService _collaborateurService;

        public DemissionController(IDemissionService service, ICollaborateurService collaborateurService)
        {
            _DemissionService = service;
            _collaborateurService = collaborateurService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CollaborateurDTO>>> GetDemissions([FromQuery] FilterParams filterParams)
        {
            //var collabs = await _collaborateurService.GetDemissions(filterParams);
            //Response.AddPaginationHeader(collabs.CurrentPage, collabs.PageSize, collabs.TotalCount, collabs.TotalPages);
            //return Ok(collabs);
            throw new NotImplementedException(); // call this from collab as it returns a list of collabs !!
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<DemissionDTO>> GetDemission(int id)
        {
            var data = await _DemissionService.GetDemissionById(id);
            if (data != null)
                return Ok(data);
            return BadRequest();
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<DemissionDTO?>> UpdateDemission(int id, DemissionDTO demission)
        {
            if (demission.Id != id)
                return BadRequest();
            var resp = await _DemissionService.GetDemissionById(id);
            if (resp == null)
                return NotFound();
            else if (resp.CollaborateurId != demission.CollaborateurId)
                return BadRequest();
            try
            {
                await this._DemissionService.UpdateDemission(demission);
            }
            catch
            {
                throw;
            }
            return await this._DemissionService.GetDemissionById(id);
        }
        [HttpPost]
        public async Task<ActionResult> AddDemission(DemissionDTO demission)
        {
            var collab = await this._collaborateurService.GetCollaborateurById(demission.CollaborateurId);
            if (collab != null)
            {
                demission.CollaborateurId = collab.Id;
                var data = await this._DemissionService.AddDemission(demission);
                if (data != null)
                    return CreatedAtAction(nameof(AddDemission), new {id = data.Id, data });
            }
            return BadRequest();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteDemission(int id)
        {
            var data = await _DemissionService.GetDemissionById(id);
            if (data is null)
                return NotFound();
            data.IsCanceled = true;
            data.ReasonDemission = null;
            await this._DemissionService.UpdateDemission(data);
            return Ok(data);
        }

    }
}
