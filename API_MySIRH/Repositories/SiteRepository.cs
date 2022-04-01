using API_MySIRH.Data;
using API_MySIRH.Entities;
using API_MySIRH.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API_MySIRH.Repositories
{
    public class SiteRepository : ISiteRepository
    {
        private readonly DataContext _context;

        public SiteRepository(DataContext context)
        {
            this._context = context;
        }
        public async Task<Site> AddSite(Site site)
        {
            _context.Sites.Add(site);
            await _context.SaveChangesAsync();
            return site;
        }

        public async Task DeleteSite(int id)
        {
            var site = await _context.Sites.FindAsync(id);
            if (site != null)
            {
                _context.Sites.Remove(site);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Site> GetSite(int id)
        {
            var site = await _context.Sites.FindAsync(id);
            return site;
        }

        public async Task<IEnumerable<Site>> GetSites()
        {
            return await _context.Sites.ToListAsync();
        }

        public async Task UpdateSite(int id, Site site)
        {
            if (id == site.Id)
            {
                _context.Entry(site).State = EntityState.Modified;
                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }
            }
        }
    }
}
