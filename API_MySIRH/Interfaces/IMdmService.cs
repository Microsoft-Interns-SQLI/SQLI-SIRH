using API_MySIRH.DTOs;

namespace API_MySIRH.Interfaces
{
    public interface IMdmService<T, TDto>
    {
        Task<IEnumerable<TDto>> GetAll();
        Task<TDto> GetById(int id);
        Task<TDto> GetByName(string name);
        Task Update(int id, TDto niveau);
        Task<TDto> Add(TDto niveau);
        Task Delete(int id);

    }
}