using API_MySIRH.Entities;

namespace API_MySIRH.Interfaces
{
    public interface IDemissionRepository
    {
        IEnumerable<Demission> GetDemissions();
        Demission GetDemission(int id);
        Task UpdateDemission(Demission demission);
        Task DeleteDemission(int id);
    }
}
