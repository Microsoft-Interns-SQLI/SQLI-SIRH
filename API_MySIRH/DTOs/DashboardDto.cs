using static API_MySIRH.Services.DashboardService;

namespace API_MySIRH.DTOs
{
    public class DashboardDto :DtoBase
    {
        public double HeadCount { get; set; }
        public double FemaleCount { get; set; } 
        public double MaleCount { get; set; }
        public double DemissionCount { get; set; }
        public double AverageAge { get; set; }
        public double ICDCount { get; set; }
        public double ExpertTechCount { get; set; }
        public double ChefDeProjetCount { get; set; }
        public double ManagerCount { get; set; }
        public double JuniorCount { get; set; }
        public double OperationnelCount { get; set; }
        public double ConfirmeCount { get; set; }
        public double SeniorCount { get; set; } 
    }
}
