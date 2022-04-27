

using API_MySIRH.DTOs;
using API_MySIRH.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_MySIRH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormationCertificationController : ControllerBase
    {
        private readonly ICollaborateurCertificationService _collaborateurCertificationService;

        public FormationCertificationController(ICollaborateurCertificationService collaborateurCertificationService)
        {
            _collaborateurCertificationService = collaborateurCertificationService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var list = await _collaborateurCertificationService.GetAll();

            return Ok(list);
        }
        [HttpGet("{collabId}/{certifId}")]
        public async Task<IActionResult> Get(int collabId, int certifId)
        {
            var cc = await _collaborateurCertificationService.GetOne(collabId, certifId);

            return Ok(cc);
        }

        [HttpPut("{collabId}/{certifId}")]
        public async Task<IActionResult> Put(int collabId, int certifId,CollaborateurCertificationDTO collaborateurCertification)
        {
            var cc = await _collaborateurCertificationService.GetOne(collabId, certifId);

            if (cc == null || cc.CollaborateurId != collaborateurCertification.CollaborateurId || collaborateurCertification.CertificationId != cc.CertificationId)
                return BadRequest("Collaborateur certification unfound!");


            await _collaborateurCertificationService.Update(collaborateurCertification);

            return StatusCode(StatusCodes.Status201Created, "Collaborateur certification updated successfully!");
        }
    }
}
