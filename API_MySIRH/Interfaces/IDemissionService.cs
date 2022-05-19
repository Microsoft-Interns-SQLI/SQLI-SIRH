using API_MySIRH.DTOs;
using API_MySIRH.Entities;
using API_MySIRH.Helpers;

namespace API_MySIRH.Interfaces
{
    public interface IDemissionService
    {
        IEnumerable<DemissionDTO>   GetDemissions();
        Task<PagedList<CollaborateurDTO>> GetCollaborateursDemissioned(FilterParams filterParams);
        DemissionDTO GetDemission(int id);
        Task UpdateDemission(DemissionDTO demission);
        Task DeleteDemission(int id);

    }
}
