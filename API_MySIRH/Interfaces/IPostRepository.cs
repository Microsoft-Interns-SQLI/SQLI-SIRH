using API_MySIRH.Entities;

namespace API_MySIRH.Interfaces
{
    public interface IPostRepository
    {

        Task<IEnumerable<Post>> GetPosts();
        Task<Post> GetPost(int id);
        Task UpdatePost(int id, Post post);
        Task<Post> AddPost(Post post);
        Task DeletePost(int id);
    }
}
