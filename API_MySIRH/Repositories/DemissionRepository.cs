using API_MySIRH.Data;
using API_MySIRH.Entities;
using API_MySIRH.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API_MySIRH.Repositories
{
    public class DemissionRepository : IDemissionRepository
    {
        private readonly DataContext _data;

        public DemissionRepository(DataContext data)
        {
            _data = data;
        }

        public async Task<Demission?> AddDemission(Demission demission)
        {
            await this._data.Demissions.AddAsync(demission);
            await this._data.SaveChangesAsync();

            return await this.GetDemissionByID(demission.Id);
        }

        public async Task DeleteDemission(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Demission?> GetDemissionByID(int id)
        {
            return await this._data.Demissions.AsNoTracking().Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public IQueryable<Collaborateur> GetCollabsDemissions()
        {
            var query = _data.Collaborateurs

                .Include(c => c.Carrieres)! // todo : to remove
                .ThenInclude(carr => carr.Poste)
                .Include(c => c.Carrieres)!
                .ThenInclude(carr => carr.Niveau)
                .Include(dem=>dem.Demissions)
                .AsSplitQuery() // todo : good practice ?
                .Include(x => x.Certifications)
                .AsNoTracking();
            return query;
        }

        public async Task<Demission?> UpdateDemission(Demission demission)
        {
            _data.Entry(demission).State = EntityState.Modified;
            await this._data.SaveChangesAsync();
            return await this.GetDemissionByID(demission.Id);
        }

        public IQueryable<Demission> GetDems()
        {
            return _data.Demissions.AsNoTracking();
        }
    }
}
