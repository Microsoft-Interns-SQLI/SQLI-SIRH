using static API_MySIRH.Services.DashboardService;

namespace API_MySIRH.Entities
{
    public class Dashboard : EntityBase
    {
        public double HeadCount { get; set; }
        public double FemaleCount { get; set; }
        public double MaleCount { get; set; }
        public double AverageAge { get; set; }
        public int ICDCount { get; set; }
        public int ExpertTechCount { get; set; }
        public int ChefDeProjetCount { get; set; }
        public int ManagerCount { get; set; }
        public int JuniorCount { get; set; }
        public int OperationnelCount { get; set; }
        public int ConfirmeCount { get; set; }
        public int SeniorCount { get; set; }
    }
}
