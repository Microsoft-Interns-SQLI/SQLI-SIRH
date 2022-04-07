using API_MySIRH.Data;
using API_MySIRH.Entities;
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

        public async Task<Dashboard> getDashboard()
        {
            var dashboard = await _context.Dashboards.FirstOrDefaultAsync();
            return dashboard;
        }
    }
}
