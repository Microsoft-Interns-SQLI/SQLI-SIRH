using API_MySIRH.DTOs;
using API_MySIRH.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_MySIRH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        private readonly IImageService _imageService;

        public ImageController(IImageService imageService)
        {
            _imageService = imageService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                return Ok(await _imageService.GetImage(id));
            }
            catch(Exception ex)
            {
                return NoContent();
            }
        }

        [HttpPost("{id}")]
        public async Task<ActionResult<ImageDTO>> Post([FromForm] IFormFile image, int id)
        {
            var imageDTO = new ImageDTO();

            try
            {
                imageDTO = await _imageService.UploadImage(image,id);
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok(imageDTO);
        }
    }
}
