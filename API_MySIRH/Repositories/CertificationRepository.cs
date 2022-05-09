using API_MySIRH.Data;
using API_MySIRH.Entities;
using API_MySIRH.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API_MySIRH.Repositories
{
    public class CertificationRepository : ICertificationRepository
    {
        private readonly DataContext _context;

        public CertificationRepository(DataContext context)
        {
            _context = context;
        }

        public Task Add(Certification certification)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Certification certification)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Certification>> GetAll()
        {
            return await _context.Certifications.AsNoTracking().ToListAsync();
        }

        public Task<Certification> GetById()
        {
            throw new NotImplementedException();
        }

        public Task<Certification> GetByLibelle()
        {
            throw new NotImplementedException();
        }

        public Task Update(Certification certification)
        {
            throw new NotImplementedException();
        }
    }
}
