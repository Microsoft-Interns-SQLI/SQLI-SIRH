using API_MySIRH.Entities;

namespace API_MySIRH.Interfaces
{
    public interface IFormationRepository
    {
        Task<List<Formation>> GetAll();
        Task<Formation> GetById();
        Task<Formation> GetByLibelle();
        Task Update(Formation formation);
        Task Add(Formation formation);
        Task Delete(Formation formation);
    }
}
