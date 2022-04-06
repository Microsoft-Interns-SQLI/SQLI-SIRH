using API_MySIRH.Data;
using API_MySIRH.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API_MySIRH.Repositories
{
    public class DashboardRepository : IDashboardRepository
    {
        private readonly DataContext _context;

        public DashboardRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<int> GetNbFemale()
        {
            return await _context.Dashboards.Select(d=>d.nbFemale).FirstOrDefaultAsync();
        }

        public async Task<int> GetNbMale()
        {
            return await _context.Dashboards.Select(d => d.nbMale).FirstOrDefaultAsync();
        }
    }
}
