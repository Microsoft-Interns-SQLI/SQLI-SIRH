using API_MySIRH.Entities;

namespace API_MySIRH.Interfaces
{
    public interface INiveauRepository
    {
        Task<IEnumerable<Niveau>> GetNiveaux();
        Task<Niveau> GetNiveau(int id);
        Task UpdateNiveau(int id, Niveau Niveau);
        Task<Niveau> AddNiveau(Niveau Niveau);
        Task DeleteNiveau(int id);
        bool NiveauExists(int id);
    }
}