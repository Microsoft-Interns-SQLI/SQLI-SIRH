using System.Net.Http.Headers;
using API_MySIRH.DTOs;
using API_MySIRH.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API_MySIRH.Controllers
{
    [ApiController]
    [Route("api/files")]
    public class FilesController : ControllerBase
    {
        public readonly IFilesService _filesService;

        public FilesController(IFilesService filesService)
        {
            _filesService = filesService;

        }
        [HttpPost("upload")]
        public async Task<ActionResult> Upload()
        {
            try
            {
                try
                {
                    ICollection<string> Paths = await _filesService.UploadFile(Request.Form.Files);
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

        [HttpGet("download")]
        public async Task<ActionResult> Download([FromQuery] string file)
        {

            if (!System.IO.File.Exists(file))
                return NotFound();
            var memory = new MemoryStream();
            await using (var stream = new FileStream(file, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, "application/pdf", $"CV_Collab_{new Guid()}");
        }
    }
}

// var filePath = Path.Combine(_env.ContentRootPath, "Upload\\files", file);
// if (!System.IO.File.Exists(filePath))
//     return NotFound();
// var memory = new MemoryStream();
// await using (var stream = new FileStream(filePath, FileMode.Open))
// {
//     await stream.CopyToAsync(memory);
// }
// memory.Position = 0;
// return File(memory, "application/pdf", filePath);