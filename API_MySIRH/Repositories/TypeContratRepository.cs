using API_MySIRH.Data;
using API_MySIRH.Entities;
using API_MySIRH.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API_MySIRH.Repositories
{
    public class TypeContratRepository : ITypeContratRepository
    {
        private DataContext _context;
        public TypeContratRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<TypeContrat> GetById(int id)
        {
            return await _context.TypeContrats.FindAsync(id);

        }
        public async Task<TypeContrat> GetByName(string name)
        {
            return await _context.TypeContrats.SingleOrDefaultAsync(t => t.Name == name.ToUpper());

        }
        public async Task<IEnumerable<TypeContrat>> GetAll()
        {
            return await _context.TypeContrats.ToListAsync();
        }
        public async Task Add(TypeContrat type)
        {
            if (!await isExist(type))
            {
                type.Name = type.Name.ToUpper();
                await _context.TypeContrats.AddAsync(type);
                await Save();
            }
            else
            {
                throw new Exception("This Type of contract is already exist!");
            }

        }
        public async Task Update(int id, TypeContrat type)
        {
            if (id == type.Id)
            {
                _context.Entry(type).State = EntityState.Modified;
                await Save();
            }
            else
            {
                throw new Exception("Operation failed!");
                // handle exception later
            }


        }

        public async Task Delete(int id)
        {
            var type = await GetById(id);
            if (type != null)
            {
                _context.TypeContrats.Remove(type);
                await Save();
            }
            else
            {
                throw new Exception("This type doesn't exist!");
            } 
        }



        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        public async Task<bool> isExist(TypeContrat type)
        {
            return await GetByName(type.Name) != null;
        }
    }
}
