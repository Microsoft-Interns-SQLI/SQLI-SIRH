using API_MySIRH.DTOs;

namespace API_MySIRH.Interfaces
{
    public interface ITypeContratService
    {
        public Task<TypeContratDto> GetById(int id);
        public Task<IEnumerable<TypeContratDto>> GetAll();

        public Task Add(TypeContratDto type);

        public Task Update(int id, TypeContratDto type);

        public Task Delete(int id);
    }
}
