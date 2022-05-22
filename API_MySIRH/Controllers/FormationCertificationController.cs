

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
        private readonly IFormationService _formationService;

        public FormationCertificationController(ICollaborateurCertificationService collaborateurCertificationService, ICollaborateurFormationService collaborateurFormationService, IFormationService formationService)
        {
            _collaborateurCertificationService = collaborateurCertificationService;
            _collaborateurFormationService = collaborateurFormationService;
            _formationService = formationService;
        }

        [HttpGet("certifications")]
        public async Task<IActionResult> GetCertifications([FromQuery] FilterParamsForCertifAndFormation filter)
        {
            var list = await _collaborateurCertificationService.GetAll(filter);

            return Ok(list);
        }
        [HttpGet("certifications/years")]
        public async Task<IActionResult> GetCertificationYears()
        {
            var years = await _collaborateurCertificationService.GetAnnees();

            return Ok(years);
        }
        [HttpGet("certifications/{collabId}/{certifId}")]
        public async Task<IActionResult> GetCertification(int collabId, int certifId)
        {
            var cc = await _collaborateurCertificationService.GetOne(collabId, certifId);

            return Ok(cc);
        }

        [HttpPut("certifications/{collabId}/{certifId}")]
        public async Task<IActionResult> PutCertification(int collabId, int certifId, CollaborateurCertificationDTO collaborateurCertification)
        {
            var cc = await _collaborateurCertificationService.GetOne(collabId, certifId);

            if (cc == null)
            {
                await _collaborateurCertificationService.Add(collaborateurCertification);
            }
            else
            {
                if (cc.CollaborateurId != collaborateurCertification.CollaborateurId || collaborateurCertification.CertificationId != cc.CertificationId)
                    return BadRequest("Collaborateur certification unfound!");

                await _collaborateurCertificationService.Update(collaborateurCertification);
            }

            return StatusCode(StatusCodes.Status201Created, "Collaborateur certification updated successfully!");
        }

        [HttpGet("formations")]
        public async Task<IActionResult> GetFormations([FromQuery] FilterParamsForCertifAndFormation filter)
        {
            var list = await _collaborateurFormationService.GetAll(filter);

            return list == null ? Ok(new CollaborateurFormationResponse { List = new List<CollaborateurFormationDTO>() }) : Ok(list);
        }
        [HttpGet("formations/years")]
        public async Task<IActionResult> GetFormationYears()
        {
            var years = await _collaborateurFormationService.GetAnnees();

            return Ok(years);
        }
        [HttpGet("formations/years/{id}")]
        public async Task<IActionResult> GetFormationYears(int id)
        {
            var years = await _collaborateurFormationService.GetAnneesByCollaborateur(id);

            return Ok(years);
        }
        [HttpGet("formations/{collabId}/{formationId}")]
        public async Task<IActionResult> GetFormation(int collabId, int formationId)
        {
            var cc = await _collaborateurFormationService.GetOne(collabId, formationId);

            return Ok(cc);
        }

        [HttpGet("formations/{collabId}")]
        public async Task<IActionResult> GetFormation(int collabId, [FromQuery] FilterParamsForCertifAndFormation filter)
        {
            var cc = await _collaborateurFormationService.GetByCollaborateur(collabId, filter);

            return cc == null ? Ok(new CollaborateurFormationResponse { List = new List<CollaborateurFormationDTO>() }) : Ok(cc);
        }

        [HttpPut("formations/{collabId}/{formationId}")]
        public async Task<IActionResult> PutFormation(int collabId, int formationId, CollaborateurFormationDTO collaborateurFormation)
        {

            if (collaborateurFormation.CollaborateurId != collabId || formationId != collaborateurFormation.FormationId)
                return BadRequest("Something went wrong!");

            var formationExist = await _formationService.GetById(formationId);

            if (formationExist == null)
                return BadRequest("Formation unfound");

            if (DateTime.Compare((DateTime)collaborateurFormation.DateDebut, (DateTime)collaborateurFormation.DateFin) > 0)
                return BadRequest("The Start date must be earlier than the end date!");

            var cf = await _collaborateurFormationService.GetOne(collabId, formationId);

            await addOrUpdate(cf, collaborateurFormation);

            return StatusCode(StatusCodes.Status201Created, "Collaborateur formation updated successfully!");
        }

        [HttpPut("formations/{collabId}")]
        public async Task<IActionResult> PutFormations(int collabId, List<CollaborateurFormationDTO> collaborateurFormations)
        {
            foreach (var collaborateurFormation in collaborateurFormations)
            {
                var formationExist = await _formationService.GetById(collaborateurFormation.FormationId);

                if (formationExist == null)
                    return BadRequest("Formation unfound");

                if (collaborateurFormation.CollaborateurId != collabId)
                    return BadRequest("Something went wrong!");

                var cf = await _collaborateurFormationService.GetOne(collabId, collaborateurFormation.FormationId);

                await addOrUpdate(cf, collaborateurFormation);
            }

            return StatusCode(StatusCodes.Status201Created, "Collaborateur formation updated successfully!");
        }

        private async Task addOrUpdate(CollaborateurFormationDTO oldcf, CollaborateurFormationDTO newcf)
        {
            if (oldcf == null)
            {
                await _collaborateurFormationService.Add(newcf);
            }
            else if (oldcf.DateDebut != newcf.DateDebut || oldcf.DateFin != newcf.DateFin || oldcf.Status != newcf.Status)
            {
                await _collaborateurFormationService.Update(newcf);
            }
        }
    }
}
