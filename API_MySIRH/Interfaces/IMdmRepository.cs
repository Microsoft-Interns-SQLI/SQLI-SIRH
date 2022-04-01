using API_MySIRH.Entities;

namespace API_MySIRH.Interfaces
{
    public interface IMdmRepository<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task Update(int id, T obj);
        Task<T> Add(T obj);
        Task Delete(int id);
        //bool Exists(int id);
    }
}