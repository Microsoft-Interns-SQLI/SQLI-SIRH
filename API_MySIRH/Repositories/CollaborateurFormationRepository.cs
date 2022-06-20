using API_MySIRH.Data;
using API_MySIRH.Entities;
using API_MySIRH.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API_MySIRH.Repositories
{
    public class CollaborateurFormationRepository : ICollaborateurFormationRepository
    {
        private readonly DataContext _context;

        public CollaborateurFormationRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<CollaborateurFormation> Add(CollaborateurFormation collaborateurFormation)
        {
            await _context.CollaborateurFormations.AddAsync(collaborateurFormation);
            await _context.SaveChangesAsync();

            return collaborateurFormation;

        }

        public async Task Delete(CollaborateurFormation collaborateurFormation)
        {
               _context.CollaborateurFormations.Remove(collaborateurFormation);
               await _context.SaveChangesAsync();
        }

        public async Task<List<CollaborateurFormation>> GetAll()
        {
            var list =  await _context.CollaborateurFormations
                            .Include(cf=>cf.Collaborateur)
                            .Include(cf=>cf.Formation)
                            .ToListAsync();

            return list;
        }

        public async Task<List<int>> GetAnnees()
        {
            return await _context.CollaborateurFormations
                                .Select(x => x.DateDebut.Value.Year)
                                .Distinct()
                                .ToListAsync();
        }

        public async Task<List<int>> GetAnneesByCollaborateur(int id)
        {
            return await _context.CollaborateurFormations
                                .Where(x=> x.CollaborateurId == id)
                                .Select(x => x.DateDebut.Value.Year)
                                .Distinct()
                                .ToListAsync();
        }

        public async Task<List<CollaborateurFormation>> GetByCollaborateur(int id)
        {
            return await _context.CollaborateurFormations.Where(x => x.CollaborateurId == id)
                .Include(x=>x.Collaborateur)
                .Include(x=>x.Formation)
                .ToListAsync();
        }

        public Task<List<CollaborateurFormation>> GetByFormation(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CollaborateurFormation>> GetByCollabAndFormation(int collabId, int formationId)
        {
            return await _context.CollaborateurFormations
                .Include(x => x.Collaborateur)
                .Include(x => x.Formation)
                .Where(x=> x.CollaborateurId == collabId && x.FormationId == formationId)
                .AsNoTracking()
                .ToListAsync();
        }
        public async Task<CollaborateurFormation> GetById(int id)
        {
            return await _context.CollaborateurFormations.Where(x => x.Id == id).AsNoTracking().FirstOrDefaultAsync();
        }
        public async Task<CollaborateurFormation> Update(CollaborateurFormation collaborateurFormation)
        {
            _context.Entry(collaborateurFormation).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return collaborateurFormation;
        }
    }
}
