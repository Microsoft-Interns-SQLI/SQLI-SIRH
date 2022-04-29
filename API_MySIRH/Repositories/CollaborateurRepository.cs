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
            await this._context.SaveChangesAsync();

            return await this.GetCollaborateurById(collaborateur.Id); // todo-review : is it necessary to fetch by id after insert ?
        }

        public async Task<bool> CollaborateurExistsById(int id)
        {
            return await this._context.Collaborateurs.AnyAsync(collaborateur => collaborateur.Id == id);
        }

        public async Task<bool> CollaborateurExistsByMatricule(string matricule)
        {
            return await this._context.Collaborateurs.AnyAsync(collaborateur => collaborateur.Matricule == matricule);
        }

        public async Task<bool> CollaborateurExistsByEmail(string email)
        {
            return await this._context.Collaborateurs.AnyAsync(collaborateur => collaborateur.Email == email);
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

        public async Task<Collaborateur?> GetCollaborateurById(int id)
        {
            return await
                    this._context.Collaborateurs
                        .Include(c => c.Poste)
                        .Include(c => c.SkillCenter)
                        .Include(c => c.Site)
                        .Include(c => c.Niveau)
                        // .Include(c => c.TypeContrat) // todo : config entity to get all it's typeContrat
                        .Include(c => c.ModeRecrutement)
                        .Include(c => c.Documents)
                        .Include(c => c.Diplomes)
                        .AsNoTracking()
                        .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Collaborateur?> GetCollaborateurByMatricule(string matricule)
        {
            return await this._context.Collaborateurs.Where(c => c.Matricule == matricule).AsNoTracking().FirstOrDefaultAsync();
        }

        public async Task<Collaborateur?> GetCollaborateurByEmail(string email)
        {
            return await this._context.Collaborateurs.Where(c => c.Email == email).AsNoTracking().FirstOrDefaultAsync();
        }

        public async Task UpdateCollaborateur(Collaborateur collaborateur)
        {
            this._context.Entry(collaborateur).State = EntityState.Modified;
            await this._context.SaveChangesAsync();
        }
    }
}