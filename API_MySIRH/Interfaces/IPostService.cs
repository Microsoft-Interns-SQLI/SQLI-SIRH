using API_MySIRH.DTOs;
using API_MySIRH.Entities;

namespace API_MySIRH.Interfaces
{
    public interface IPostService
    {
        Task<IEnumerable<PostDTO>> GetPosts();
        Task<PostDTO> GetPost(int id);
        Task UpdatePost(int id, PostDTO post);
        Task<PostDTO> AddPost(PostDTO post);
        Task DeletePost(int id);
    }
}
