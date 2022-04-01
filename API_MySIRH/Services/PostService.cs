using API_MySIRH.DTOs;
using API_MySIRH.Entities;
using API_MySIRH.Interfaces;
using AutoMapper;

namespace API_MySIRH.Services
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;

        public PostService(IPostRepository postRepository, IMapper mapper)
        {
            this._postRepository = postRepository;
            this._mapper = mapper;
        }

        public async Task<PostDTO> AddPost(PostDTO postDTO)
        {
            var returnedPost = await _postRepository.AddPost(_mapper.Map<Post>(postDTO));
            return _mapper.Map<PostDTO>(returnedPost);
        }

        public async Task DeletePost(int id)
        {
            await _postRepository.DeletePost(id);
        }

        public async Task<PostDTO> GetPost(int id)
        {
            var result = await _postRepository.GetPost(id);
            return _mapper.Map<PostDTO>(result);
        }

        public async Task<IEnumerable<PostDTO>> GetPosts()
        {
            var result = await _postRepository.GetPosts();
            return _mapper.Map<IEnumerable<Post>, IEnumerable<PostDTO>>(result);
        }

        public async Task UpdatePost(int id, PostDTO postDTO)
        {
            var post = _mapper.Map<Post>(postDTO);
            await _postRepository.UpdatePost(id, post);
        }
    }
}
