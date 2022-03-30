using API_MySIRH.DTOs;

namespace API_MySIRH.Interfaces
{
    public interface INiveauService
    {
        Task<IEnumerable<NiveauDTO>> GetNiveaux();
        Task<NiveauDTO> GetNiveau(int id);
        Task UpdateNiveau(int id, NiveauDTO niveau);
        Task<NiveauDTO> AddNiveau(NiveauDTO niveau);
        Task DeleteNiveau(int id);
    }
}