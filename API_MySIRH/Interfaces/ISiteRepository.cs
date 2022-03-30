using API_MySIRH.Entities;

namespace API_MySIRH.Interfaces
{
    public interface ISiteRepository
    {
        Task<IEnumerable<Site>> GetSites();
        Task<Site> GetSite(int id);
        Task UpdateSite(int id, Site site);
        Task<Site> AddSite(Site site);
        Task DeleteSite(int id);
    }
}
