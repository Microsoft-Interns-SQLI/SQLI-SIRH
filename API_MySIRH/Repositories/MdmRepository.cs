using API_MySIRH.Data;
using API_MySIRH.Entities;
using API_MySIRH.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API_MySIRH.Repositories
{
    public class MdmRepository<T> : IMdmRepository<T> where T : class,IStringName
    {
        private readonly DataContext _context;

        public MdmRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<T> Add(T obj)
        {
            _context.Set<T>().Add(obj);
            await _context.SaveChangesAsync();
            return obj;
        }

        public async Task Delete(int id)
        {
            var objToDelete = await _context.Set<T>().FindAsync(id);
            if (objToDelete != null)
                _context.Set<T>().Remove(objToDelete);
            await _context.SaveChangesAsync();

        }

        // public bool Exists(int id)
        // {
        //     return _context.Set<T>().Any(n => n. == id);
        // }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<T> GetByName(string name)
        {
            return await _context.Set<T>().Where(x => x.Name == name).FirstOrDefaultAsync();
        }

        public async Task Update(int id, T obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}