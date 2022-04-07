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
                var folderName = Path.Combine(_env.ContentRootPath, "Upload\\files");
                List<string> Paths = new List<string>();
                //var file = Request.Form.Files[0];
                foreach (var file in Request.Form.Files)
                {
                    if (!Directory.Exists(folderName))
                    {
                        Directory.CreateDirectory(folderName);
                    }
                    var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
                    if (file.Length > 0)
                    {
                        var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                        var fullPath = Path.Combine(pathToSave, fileName);
                        var dbPath = Path.Combine(folderName, fileName);
                        using (var stream = new FileStream(fullPath, FileMode.Create))
                        {
                            await file.CopyToAsync(stream);
                        }

                        Paths.Add(dbPath);

                    }
                    else
                    {
                        return BadRequest();
                    }
                }
                return Ok(Paths);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }
    }
}