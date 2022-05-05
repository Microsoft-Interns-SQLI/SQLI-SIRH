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

        public Task Add(CollaborateurFormation collaborateurFormation)
        {
            throw new NotImplementedException();
        }

        public Task Delete(CollaborateurFormation collaborateurFormation)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CollaborateurFormation>> GetAll()
        {
            return await _context.CollaborateurFormations
                            .Include(cf=>cf.Collaborateur)
                            .Include(cf=>cf.Formation)
                            .ToListAsync();
        }

        public Task<List<CollaborateurFormation>> GetByCollaborateur(int id)
        {
            throw new NotImplementedException();
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
