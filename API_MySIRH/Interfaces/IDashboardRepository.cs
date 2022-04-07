using API_MySIRH.Entities;

namespace API_MySIRH.Interfaces
{
    public interface IDashboardRepository
    {
        Task<Dashboard> getDashboard();
    }
}
