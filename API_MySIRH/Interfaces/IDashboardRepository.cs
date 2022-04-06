namespace API_MySIRH.Interfaces
{
    public interface IDashboardRepository
    {
        Task<int> GetNbFemale();
        Task<int> GetNbMale();
    }
}
