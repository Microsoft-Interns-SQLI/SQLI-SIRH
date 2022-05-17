
using API_MySIRH.Entities;

namespace API_MySIRH.Interfaces
{
    public interface IImageRepository
    {
        Task<Image> GetImage(int id);

        Task<Image> UploadImage(Image image);

        Task<bool> IsExists(int collaborateurId, string name);
        Task<bool> IsExistById(int collaborateurId);
    }
}
