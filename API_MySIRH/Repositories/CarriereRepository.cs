using API_MySIRH.Data;
using API_MySIRH.Entities;
using API_MySIRH.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API_MySIRH.Repositories
{
    public class CarriereRepository : ICarriereRepository
    {
        private readonly DataContext _dataContext;
        public CarriereRepository(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }

        public async Task<Carriere?> Add(Carriere carriere)
        {
            await this._dataContext.Carrieres.AddAsync(carriere);
            await this._dataContext.SaveChangesAsync();

            return carriere;
        }

        public async Task Delete(Carriere carriere)
        {
            this._dataContext.Carrieres.Remove(carriere);
            await this._dataContext.SaveChangesAsync();
        }

        public Task<bool> Exists(int idCarriere)
        {
            return this._dataContext.Carrieres.AnyAsync(carriere => carriere.Id == idCarriere);
        }

        public async Task<Carriere?> FindById(int id)
        {
            return await
                this._dataContext.Carrieres
                    .Include(c => c.Collaborateur)
                    .Include(c => c.Niveau)
                    .Include(c => c.Poste)
                    .AsNoTracking()
                    .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<List<Carriere>?> GetAll()
        {
            return await this._dataContext.Carrieres.ToListAsync();
        }

        public async Task<List<Carriere>?> GetAllByCollab(int idCollaborateur)
        {
            return await
                this._dataContext.Carrieres
                    .Where(c => c.CollaborateurId == idCollaborateur)
                    .Include(c => c.Collaborateur)
                    .Include(c => c.Niveau)
                    .Include(c => c.Poste)
                    .ToListAsync();
        }

        public async Task Update(Carriere carriere)
        {
            this._dataContext.Entry(carriere).State = EntityState.Modified;
            await this._dataContext.SaveChangesAsync();
        }
    }
}