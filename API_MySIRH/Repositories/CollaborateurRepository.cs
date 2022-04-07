using API_MySIRH.Data;
using API_MySIRH.Entities;
using API_MySIRH.Helpers;
using API_MySIRH.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API_MySIRH.Repositories
{
    public class CollaborateurRepository : ICollaborateurRepository
    {
        private readonly DataContext _context;


        public CollaborateurRepository(DataContext context)
        {
            this._context = context;
        }

        public async Task<Collaborateur> AddCollaborateur(Collaborateur collaborateur)
        {
            await this._context.Collaborateurs.AddAsync(collaborateur);

            var dashboard = await _context.Dashboards.SingleOrDefaultAsync();
            if(dashboard is not null)
            {
                if (collaborateur.Civilite == "M")
                    dashboard.nbMale++;
                else dashboard.nbFemale++;
            }

            await this._context.SaveChangesAsync();
            return collaborateur;
        }

        public async Task<bool> CollaborateurExists(int id)
        {
            return await this._context.Collaborateurs.AnyAsync(collaborateur => collaborateur.Id == id);
        }

        public async Task DeleteCollaborateur(int id)
        {
            var collaborateurToDelete = await this._context.Collaborateurs.FindAsync(id);
            if (collaborateurToDelete is not null)
                this._context.Collaborateurs.Remove(collaborateurToDelete);
            await this._context.SaveChangesAsync();
        }

        public IQueryable<Collaborateur> GetCollaborateurs()
        {
            var query = _context.Collaborateurs;
            return query;
        }

        public async Task<Collaborateur> GetCollaborateur(int id)
        {
            return await this._context.Collaborateurs.FindAsync(id);
        }

        public async Task UpdateCollaborateur(int id, Collaborateur collaborateur)
        {
            this._context.Entry(collaborateur).State = EntityState.Modified;
            await this._context.SaveChangesAsync();
        }
    }
}