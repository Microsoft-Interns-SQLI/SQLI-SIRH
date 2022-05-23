using API_MySIRH.DTOs;

namespace API_MySIRH.Interfaces
{
    public interface IImageService
    {
        Task<FileStream> GetImage(int id);
        Task<ImageDTO> UploadImage(IFormFile image, int id);
    }
}
