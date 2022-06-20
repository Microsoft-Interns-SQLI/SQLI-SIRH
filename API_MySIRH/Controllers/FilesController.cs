using System.Net.Http.Headers;
using API_MySIRH.DTOs;
using API_MySIRH.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API_MySIRH.Controllers
{
    [ApiController]
    [Route("api/files")]
    [Authorize]
    public class FilesController : ControllerBase
    {
        public readonly IFilesService _filesService;

        public FilesController(IFilesService filesService)
        {
            _filesService = filesService;

        }
        [HttpPost("upload/{id}")]
        public async Task<ActionResult> Upload([FromQuery] string type, int id)
        {
            try
            {
                try
                {
                    ICollection<FileDTO> Paths = await _filesService.UploadFile(Request.Form.Files, type, id);
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
            return File(memory, "application/pdf");
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                await _filesService.Delete(id);
                return NoContent();
            }
            catch (Exception ex)
            {

                return StatusCode(500, $"Internal server error: {ex}");
            }
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