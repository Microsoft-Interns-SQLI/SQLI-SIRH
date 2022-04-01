using API_MySIRH.DTOs;

namespace API_MySIRH.Interfaces
{
    public interface ITypeContratService
    {
        public Task<TypeContratDTO> GetById(int id);
        public Task<IEnumerable<TypeContratDTO>> GetAll();

        public Task Add(TypeContratDTO type);

        public Task Update(int id, TypeContratDTO type);

        public Task Delete(int id);
    }
}
