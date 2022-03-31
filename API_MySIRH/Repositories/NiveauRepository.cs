using API_MySIRH.Data;
using API_MySIRH.Entities;
using API_MySIRH.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API_MySIRH.Repositories
{
    public class NiveauRepository : INiveauRepository
    {
        private readonly DataContext _context;

        public NiveauRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Niveau> AddNiveau(Niveau niveau)
        {
            _context.Niveaux.Add(niveau);
            await _context.SaveChangesAsync();
            return niveau;
        }

        public async Task DeleteNiveau(int id)
        {
            var niveauToDelete = await _context.Niveaux.FindAsync(id);
            if (niveauToDelete != null)
                _context.Niveaux.Remove(niveauToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<Niveau> GetNiveau(int id)
        {
            return await _context.Niveaux.FindAsync(id);
        }

        public async Task<IEnumerable<Niveau>> GetNiveaux()
        {
            return await _context.Niveaux.ToListAsync();
        }

        public bool NiveauExists(int id)
        {
            return _context.Niveaux.Any(n => n.Id == id);
        }

        public async Task UpdateNiveau(int id, Niveau niveau)
        {
            _context.Entry(niveau).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}