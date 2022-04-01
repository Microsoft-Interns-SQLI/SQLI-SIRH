using API_MySIRH.DTOs;
using API_MySIRH.Entities;

namespace API_MySIRH.Interfaces
{
    public interface ITypeContratRepository
    {
        public Task<TypeContrat> GetById(int id);
        public Task<TypeContrat> GetByName(string name);
        public Task<bool> isExist(TypeContrat type);
        public Task<IEnumerable<TypeContrat>> GetAll();

        public Task Add(TypeContrat type);

        public Task Update(int id,TypeContrat type);

        public Task Delete(int id);

        public Task Save();
    }
}
