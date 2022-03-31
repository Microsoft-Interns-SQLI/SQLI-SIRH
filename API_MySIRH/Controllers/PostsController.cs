using API_MySIRH.DTOs;
using API_MySIRH.Entities;
using API_MySIRH.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_MySIRH.Controllers
{

    public class PostsController : MdmController<Post, PostDTO>
    {

        public PostsController(IMdmService<Post, PostDTO> mdmService) : base(mdmService)
        {

        }

        [HttpGet("postes")]
        public async Task<ActionResult<IEnumerable<PostDTO>>> GetPosts()
        {
            var result = await _mdmService.GetAll();
            return Ok(result);
        }

        [HttpGet("postes/{id}")]
        public async Task<ActionResult<PostDTO>> GetPost(int id)
        {
            var post = await _mdmService.GetById(id);

            if (post == null)
            {
                return NotFound();
            }

            return post;
        }

        [HttpPut("postes/{id}")]
        public async Task<IActionResult> PutPost(int id, PostDTO post)
        {
            if (id != post.Id)
            {
                return BadRequest();
            }

            try
            {
                await _mdmService.Update(id, post);
            }
            catch
            {
                throw;
            }

            return NoContent();
        }


        [HttpPost("postes")]
        public async Task<ActionResult<PostDTO>> PostPost(PostDTO post)
        {
            var returnedPost = await _mdmService.Add(post);
            return CreatedAtAction("GetPost", new { id = returnedPost.Id }, returnedPost);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePost(int id)
        {
            var postToDelete = await _mdmService.GetById(id);
            if (postToDelete == null)
            {
                return NotFound();
            }

            await _mdmService.Delete(id);

            return NoContent();
        }
    }
}
