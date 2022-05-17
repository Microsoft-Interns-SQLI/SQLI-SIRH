using API_MySIRH.Data;
using API_MySIRH.Entities;
using API_MySIRH.Interfaces;

namespace API_MySIRH.Repositories
{
    public class DemissionRepository : IDemissionRepository
    {
        private readonly DataContext _context;

        public DemissionRepository(DataContext context)
        {
            _context = context;
        }

        public Task DeleteDemission(int id)
        {
            throw new NotImplementedException();
        }

        public Demission GetDemission(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Demission> GetDemissions()
        {
            throw new NotImplementedException();
        }

        public Task UpdateDemission(Demission demission)
        {
            throw new NotImplementedException();
        }
    }
}
