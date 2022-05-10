using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_MySIRH.Data;
using API_MySIRH.Entities;
using API_MySIRH.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API_MySIRH.Repositories
{
    public class DiplomeRepository : IDiplomeRepository
    {
        private readonly DataContext _dataContext;
        private readonly ICollaborateurRepository _collaborateurRepository;
        public DiplomeRepository(DataContext dataContext, ICollaborateurRepository collaborateurRepository)
        {
            this._dataContext = dataContext;
            this._collaborateurRepository = collaborateurRepository;
        }

        public async Task<List<Diplome>> GetAllDiplomes()
        {
            return await this._dataContext.Diplomes.ToListAsync();
        }

        public async Task<Diplome?> GetDiplome(int idDiplome)
        {
            return await this._dataContext.Diplomes.FindAsync(idDiplome);
        }

        public async Task<Diplome> AddDiplomeToCollab(Diplome diplome)
        {
            await this._dataContext.Diplomes.AddAsync(diplome);
            await this._dataContext.SaveChangesAsync();

            return diplome;
        }

        public async Task UpdateCollabDiplome(Diplome diplome)
        {
            this._dataContext.Entry(diplome).State = EntityState.Modified;
            await this._dataContext.SaveChangesAsync();
        }

        public async Task DeleteDiplomeToCollab(int idDiplome)
        {
            this._dataContext.Diplomes.Remove((await this.GetDiplome(idDiplome))!);
            await this._dataContext.SaveChangesAsync();
        }

        public async Task<bool> Exists(int idDiplome)
        {
            return await this._dataContext.Diplomes.AnyAsync(diplome => diplome.Id == idDiplome);
        }
    }
}