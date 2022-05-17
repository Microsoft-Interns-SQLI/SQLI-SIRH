

using API_MySIRH.DTOs;
using API_MySIRH.Helpers;
using API_MySIRH.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API_MySIRH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormationCertificationController : ControllerBase
    {
        private readonly ICollaborateurCertificationService _collaborateurCertificationService;
        private readonly ICollaborateurFormationService _collaborateurFormationService;

        public FormationCertificationController(ICollaborateurCertificationService collaborateurCertificationService, ICollaborateurFormationService collaborateurFormationService)
        {
            _collaborateurCertificationService = collaborateurCertificationService;
            _collaborateurFormationService = collaborateurFormationService;
        }

        [HttpGet("certifications")]
        public async Task<IActionResult> GetCertifications([FromQuery] FilterParamsForCertifAndFormation filter)
        {
            var list = await _collaborateurCertificationService.GetAll(filter);

            var annees =  await _collaborateurCertificationService.GetAnnees();

            return Ok(new { list = list, annees = annees });
        }
        [HttpGet("certifications/{collabId}/{certifId}")]
        public async Task<IActionResult> GetCertification(int collabId, int certifId)
        {
            var cc = await _collaborateurCertificationService.GetOne(collabId, certifId);

            return Ok(cc);
        }

        [HttpPut("certifications/{collabId}/{certifId}")]
        public async Task<IActionResult> PutCertification(int collabId, int certifId,CollaborateurCertificationDTO collaborateurCertification)
        {
            var cc = await _collaborateurCertificationService.GetOne(collabId, certifId);

            if (cc == null || cc.CollaborateurId != collaborateurCertification.CollaborateurId || collaborateurCertification.CertificationId != cc.CertificationId)
                return BadRequest("Collaborateur certification unfound!");


            await _collaborateurCertificationService.Update(collaborateurCertification);

            return StatusCode(StatusCodes.Status201Created, "Collaborateur certification updated successfully!");
        }

        [HttpGet("formations")]
        public async Task<IActionResult> GetFormations([FromQuery] FilterParamsForCertifAndFormation filter)
        {
            var list = await _collaborateurFormationService.GetAll(filter);

            var annees = await _collaborateurFormationService.GetAnnees();

            return Ok(new {list = list, annees = annees});
        }
        [HttpGet("formations/{collabId}/{formationId}")]
        public async Task<IActionResult> GetFormation(int collabId, int formationId)
        {
            var cc = await _collaborateurFormationService.GetOne(collabId, formationId);

            return Ok(cc);
        }

        [HttpPut("formations/{collabId}/{formationId}")]
        public async Task<IActionResult> PutFormation(int collabId, int formationId, CollaborateurFormationDTO collaborateurFormation)
        {
            var cf = await _collaborateurFormationService.GetOne(collabId, formationId);

            if (cf == null || cf.CollaborateurId != collaborateurFormation.CollaborateurId || collaborateurFormation.FormationId != cf.FormationId)
                return BadRequest("Collaborateur formation unfound!");


            await _collaborateurFormationService.Update(collaborateurFormation);

            return StatusCode(StatusCodes.Status201Created, "Collaborateur formation updated successfully!");
        }
    }
}
