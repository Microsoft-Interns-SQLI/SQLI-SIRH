using API_MySIRH.DTOs;

namespace API_MySIRH.Interfaces
{
    public interface IFormationService
    {
        Task<List<FormationDTO>> GetAll();
        Task<FormationDTO> GetById(int id);
        Task<FormationDTO> GetByLibelle();
        Task Update(FormationDTO formation);
        Task Add(FormationDTO formation);
        Task Delete(FormationDTO formation);
    }
}
