using API_MySIRH.Entities;

namespace API_MySIRH.Interfaces
{
    public interface ICarriereRepository
    {
        Task<List<Carriere>?> GetAll();
        Task<List<Carriere>?> GetAllByCollab(int idCollaborateur);
        Task<Carriere?> FindById(int id);
        Task<Carriere?> Add(Carriere carriere);
        Task Update(Carriere carriere);
        Task Delete(Carriere carriere);
        Task<bool> Exists(int idCarriere);
    }
}