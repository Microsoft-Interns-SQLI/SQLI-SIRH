using API_MySIRH.DTOs;
using API_MySIRH.Entities;

namespace API_MySIRH.Interfaces
{
    public interface ISiteService
    {
        Task<IEnumerable<SiteDTO>> GetSites();
        Task<SiteDTO> GetSite(int id);
        Task UpdateSite(int id, SiteDTO site);
        Task<SiteDTO> AddSite(SiteDTO site);
        Task DeleteSite(int id);
    }
}
