using System.Net.Http.Headers;
using API_MySIRH.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API_MySIRH.Controllers
{
    [ApiController]
    [Route("api/upload")]
    public class UploadController : ControllerBase
    {
        public readonly IUploadService _uploadService;
        public readonly IWebHostEnvironment _env;
        public UploadController(IUploadService uploadService, IWebHostEnvironment env)
        {
            _uploadService = uploadService;
            _env = env;
        }
        [HttpPost]
        public async Task<ActionResult> Upload()
        {
            try
            {
                try
                {
                    ICollection<string> Paths = await _uploadService.UploadFile(Request.Form.Files);
                    return Ok(Paths);
                }
                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }
    }
}