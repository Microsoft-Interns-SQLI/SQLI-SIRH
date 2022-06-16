using API_MySIRH.DTOs;
using API_MySIRH.Entities;
using API_MySIRH.Helpers;

namespace API_MySIRH.Interfaces
{
    public interface IDemissionService
    {
        IQueryable<Collaborateur> GetCollabsDemissions(FilterParams filterParams);
        Task<DemissionDTO?> GetDemissionById(int id);
        Task<DemissionDTO?> UpdateDemission(DemissionDTO demission);
        Task<DemissionDTO?> AddDemission(DemissionDTO demission);
        Task DeleteDemission(int id);
        
    }
}
