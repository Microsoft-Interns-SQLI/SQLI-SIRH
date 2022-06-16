using API_MySIRH.Entities;

namespace API_MySIRH.Interfaces
{
    public interface IDemissionRepository
    {
        IQueryable<Collaborateur> GetCollabsDemissions();
        Task<Demission?> GetDemissionByID(int id);
        Task<Demission?> UpdateDemission(Demission demission);
        Task<Demission?> AddDemission(Demission demission);
        Task DeleteDemission(int id);
    }
}
