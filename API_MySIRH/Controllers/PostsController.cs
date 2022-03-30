using API_MySIRH.DTOs;
using API_MySIRH.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_MySIRH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly ILogger<PostsController> _logger;
        private readonly IPostService _postService;

        public PostsController(ILogger<PostsController> logger, IPostService postService)
        {
            this._logger = logger;
            this._postService = postService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PostDTO>>> GetPosts()
        {
            var result = await _postService.GetPosts();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PostDTO>> GetPost(int id)
        {
            var post = await _postService.GetPost(id);

            if (post == null)
            {
                return NotFound();
            }

            return post;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPost(int id, PostDTO post)
        {
            if (id != post.Id)
            {
                return BadRequest();
            }

            try
            {
                await _postService.UpdatePost(id, post);
            }
            catch
            {
                throw;
            }

            return NoContent();
        }

        
        [HttpPost]
        public async Task<ActionResult<PostDTO>> PostPost(PostDTO post)
        {
            var returnedPost = await _postService.AddPost(post);
            return CreatedAtAction("GetPost", new { id = returnedPost.Id }, returnedPost);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePost(int id)
        {
            var postToDelete = await _postService.GetPost(id);
            if (postToDelete == null)
            {
                return NotFound();
            }

            await _postService.DeletePost(id);

            return NoContent();
        }
    }
}
