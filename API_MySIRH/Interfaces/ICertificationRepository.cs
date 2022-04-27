using API_MySIRH.Entities;

namespace API_MySIRH.Interfaces
{
    public interface ICertificationRepository
    {
        Task<List<Certification>> GetAll();
        Task<Certification> GetById();
        Task<Certification> GetByLibelle();
        Task Update(Certification certification);
        Task Add(Certification certification);
        Task Delete(Certification certification);
    }
}
