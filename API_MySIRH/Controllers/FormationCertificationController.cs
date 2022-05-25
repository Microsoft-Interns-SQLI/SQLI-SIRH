

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
        private readonly ICertificationService _certificationService;

        public FormationCertificationController(ICollaborateurCertificationService collaborateurCertificationService, ICollaborateurFormationService collaborateurFormationService, IFormationService formationService, ICertificationService certificationService)
        {
            _collaborateurCertificationService = collaborateurCertificationService;
            _collaborateurFormationService = collaborateurFormationService;
            _formationService = formationService;
            _certificationService = certificationService;
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
        [HttpGet("certifications/years/{id}")]
        public async Task<IActionResult> GetCertificationYears(int id)
        {
            var years = await _collaborateurCertificationService.GetAnneesByCollaborateur(id);

            return Ok(years);
        }
        [HttpGet("certifications/{collabId}/{certifId}")]
        public async Task<IActionResult> GetCertification(int collabId, int certifId)
        {
            var cc = await _collaborateurCertificationService.GetOne(collabId, certifId);

            return Ok(cc);
        }

        [HttpGet("certifications/{collabId}")]
        public async Task<IActionResult> GetCertification(int collabId, [FromQuery] FilterParamsForCertifAndFormation filter)
        {
            var cc = await _collaborateurCertificationService.GetByCollaborateur(collabId, filter);

            return cc == null ? Ok(new CollaborateurCertificationResponse { List = new List<CollaborateurCertificationDTO>() }) : Ok(cc);
        }

        [HttpPut("certifications/{collabId}/{certifId}")]
        public async Task<IActionResult> PutCertification(int collabId, int certifId, CollaborateurCertificationDTO collaborateurCertification)
        {
            if (collaborateurCertification.CollaborateurId != collabId || certifId != collaborateurCertification.CertificationId)
                return BadRequest("Something went wrong!");

            var formationExist = await _certificationService.GetById(certifId);

            if (formationExist == null)
                return BadRequest("Certificate unfound");

            if (DateTime.Compare((DateTime)collaborateurCertification.DateDebut, (DateTime)collaborateurCertification.DateFin) > 0)
                return BadRequest("The Start date must be earlier than the end date!");

            if (collaborateurCertification.Id == 0)
                await _collaborateurCertificationService.Add(collaborateurCertification);
            else
            {
                var cf = await _collaborateurCertificationService.GetOne(collabId, certifId);

                await addOrUpdateCertification(cf, collaborateurCertification);
            }
            return StatusCode(StatusCodes.Status201Created, "Collaborateur cerification updated successfully!");
        }
        [HttpPut("certifications/{collabId}")]
        public async Task<IActionResult> PutCertifications(int collabId, List<CollaborateurCertificationDTO> collaborateurCertifications)
        {
            foreach (var collaborateurCertification in collaborateurCertifications)
            {
                var certificationExist = await _certificationService.GetById(collaborateurCertification.CertificationId);

                if (certificationExist == null)
                    return BadRequest("Certificate unfound");

                if (collaborateurCertification.CollaborateurId != collabId)
                    return BadRequest("Something went wrong!");

                var cf = await _collaborateurCertificationService.GetOne(collabId, collaborateurCertification.CertificationId);

                if (cf != null && cf.DateDebut.Value.ToString("dd/MM/yyyy").CompareTo(collaborateurCertification.DateDebut.Value.ToString("dd/MM/yyyy")) == 0
                     && cf.DateFin.Value.ToString("dd/MM/yyyy").CompareTo(collaborateurCertification.DateFin.Value.ToString("dd/MM/yyyy")) == 0
                     && cf.CollaborateurId == collaborateurCertification.CollaborateurId && cf.CertificationId == collaborateurCertification.CertificationId)
                    continue;
                else
                {
                    await _collaborateurCertificationService.Add(collaborateurCertification);
                }
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
            if(collaborateurFormation.Id == 0)
                await _collaborateurFormationService.Add(collaborateurFormation);
            else
            {
                var cf = await _collaborateurFormationService.GetOne(collabId, formationId);

                await addOrUpdateFormation(cf, collaborateurFormation);
            }
            

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

                if (cf != null && cf.DateDebut.Value.ToString("dd/MM/yyyy").CompareTo(collaborateurFormation.DateDebut.Value.ToString("dd/MM/yyyy")) == 0
                    && cf.DateFin.Value.ToString("dd/MM/yyyy").CompareTo(collaborateurFormation.DateFin.Value.ToString("dd/MM/yyyy")) == 0
                    && cf.CollaborateurId == collaborateurFormation.CollaborateurId && cf.FormationId == collaborateurFormation.FormationId)
                    continue;
                else
                {
                    await _collaborateurFormationService.Add(collaborateurFormation);
                }
                
            }

            return StatusCode(StatusCodes.Status201Created, "Collaborateur formation updated successfully!");
        }


        private async Task addOrUpdateFormation(CollaborateurFormationDTO oldcf, CollaborateurFormationDTO newcf)
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
        private async Task addOrUpdateCertification(CollaborateurCertificationDTO oldcf, CollaborateurCertificationDTO newcf)
        {
            if (oldcf == null)
            {
                await _collaborateurCertificationService.Add(newcf);
            }
            else if (oldcf.DateDebut != newcf.DateDebut || oldcf.DateFin != newcf.DateFin || oldcf.Status != newcf.Status)
            {
                await _collaborateurCertificationService.Update(newcf);
            }
        }
    }
}
