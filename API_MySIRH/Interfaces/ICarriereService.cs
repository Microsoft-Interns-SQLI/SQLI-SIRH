using API_MySIRH.DTOs;

namespace API_MySIRH.Interfaces
{
    public interface ICarriereService
    {
        Task<List<CarriereDTO>?> GetAll();
        Task<List<CarriereDTO>?> GetAllByCollab(int idCollaborateur);
        Task<CarriereDTO?> FindById(int id);
        Task<CarriereDTO?> Add(CarriereDTO carriereDTO);
        Task Update(CarriereDTO carriereDTO);
        Task Delete(CarriereDTO carriereDTO);
        Task<bool> Exists(int idCarriere);
    }
}