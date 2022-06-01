using API_MySIRH.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API_MySIRH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CertificationController : ControllerBase
    {
        private readonly ICertificationService certificationService;

        public CertificationController(ICertificationService certificationService)
        {
            this.certificationService = certificationService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var certifications = await certificationService.GetAll();

            return Ok(certifications);
        }
    }
}
