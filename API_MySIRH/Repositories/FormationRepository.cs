using API_MySIRH.Data;
using API_MySIRH.Entities;
using API_MySIRH.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API_MySIRH.Repositories
{
    public class FormationRepository : IFormationRepository
    {
        private readonly DataContext _context;

        public FormationRepository(DataContext context)
        {
            _context = context;
        }

        public Task Add(Formation formation)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Formation formation)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Formation>> GetAll()
        {
            return await _context.Formations.ToListAsync();
        }

        public async Task<Formation> GetById(int id)
        {
            return await _context.Formations.FindAsync(id);
        }

        public Task<Formation> GetByLibelle()
        {
            throw new NotImplementedException();
        }

        public Task Update(Formation formation)
        {
            throw new NotImplementedException();
        }
    }
}
