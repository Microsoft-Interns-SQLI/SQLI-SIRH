using API_MySIRH.Data;
using API_MySIRH.Entities;
using API_MySIRH.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API_MySIRH.Repositories
{
    public class CollaborateurCertificationRepository : ICollaborateurCertificationRepository
    {
        private readonly DataContext _context;

        public CollaborateurCertificationRepository(DataContext context)
        {
            _context = context;
        }

        public async Task Add(CollaborateurCertification collaborateurCertification)
        {
            await _context.CollaborateurCertifications.AddAsync(collaborateurCertification);
            await _context.SaveChangesAsync();
        }

        public Task Delete(CollaborateurCertification collaborateurCertification)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CollaborateurCertification>> GetAll()
        {
            return await _context.CollaborateurCertifications
                .Include(cc => cc.Certification)
                .Include(cc => cc.Collaborateur)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<List<int>> GetAnnees()
        {
            return await _context.CollaborateurCertifications
                                .Select(x => x.DateDebut.Value.Year)
                                .Distinct()
                                .ToListAsync();
        }
        public async Task<List<int>> GetAnneesByCollaborateur(int id)
        {
            return await _context.CollaborateurCertifications
                                .Where(x => x.CollaborateurId == id)
                                .Select(x => x.DateDebut.Value.Year)
                                .Distinct()
                                .ToListAsync();
        }
        public Task<List<CollaborateurCertification>> GetByCertification(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CollaborateurCertification>> GetByCollaborateur(int id)
        {
            return await _context.CollaborateurCertifications.Where(x => x.CollaborateurId == id)
                .Include(x => x.Collaborateur)
                .Include(x => x.Certification)
                .ToListAsync();
        }

        public async Task<CollaborateurCertification> GetOne(int collaborateurId, int certificationId)
        {
            var cc = await _context.CollaborateurCertifications
                .Include(cc => cc.Collaborateur)
                .Include(cc => cc.Certification)
                .Where(cc => cc.CertificationId == certificationId && cc.CollaborateurId == collaborateurId)
                .AsNoTracking()
                .FirstOrDefaultAsync();

            return cc;
        }

        public async Task Update(CollaborateurCertification collaborateurCertification)
        {
            _context.Entry(collaborateurCertification).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
