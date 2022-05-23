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

        public async Task Add(CollaborateurFormation collaborateurFormation)
        {
            await _context.CollaborateurFormations.AddAsync(collaborateurFormation);
            await _context.SaveChangesAsync();

        }

        public Task Delete(CollaborateurFormation collaborateurFormation)
        {
            throw new NotImplementedException();
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

        public async Task<CollaborateurFormation> GetOne(int collaborateurId, int formationId)
        {
            var cf = await _context.CollaborateurFormations
                    .Where(cf => cf.CollaborateurId == collaborateurId && cf.FormationId == formationId)
                    .Include(cf => cf.Collaborateur)
                    .Include(cf => cf.Formation)
                    .AsNoTracking()
                    .FirstOrDefaultAsync();

            return cf;
        }

        public async Task Update(CollaborateurFormation collaborateurFormation)
        {
            _context.Entry(collaborateurFormation).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
