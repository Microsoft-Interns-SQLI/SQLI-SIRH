﻿using API_MySIRH.Data;
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

        public Task Add(CollaborateurCertification collaborateurCertification)
        {
            throw new NotImplementedException();
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
                .ToListAsync();
        }

        public Task<List<CollaborateurCertification>> GetByCertification(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CollaborateurCertification>> GetByCollaborateur(int id)
        {
            throw new NotImplementedException();
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