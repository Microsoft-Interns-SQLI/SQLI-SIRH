using API_MySIRH.DTOs;

namespace API_MySIRH.Interfaces
{
    public interface IDashboardService
    {
        Task<DashboardDto> getDashboard();
    }
}
