using static API_MySIRH.Services.DashboardService;

namespace API_MySIRH.Entities
{
    public class Dashboard : EntityBase
    {
        public double HeadCount { get; set; }
        public double FemaleCount { get; set; }
        public double MaleCount { get; set; }
        public double DemissionCount { get; set; }
        public double AverageAge { get; set; }
        public double AverageExp { get; set; }
        public double ICDCount { get; set; }
        public double ExpertTechCount { get; set; }
        public double ChefDeProjetCount { get; set; }
        public double ManagerCount { get; set; }
        public double JuniorCount { get; set; }
        public double OperationnelCount { get; set; }
        public double ConfirmeCount { get; set; }
        public double SeniorCount { get; set; }
        public double TauxEncadrement { get; set; }
        public double TauxSoustraitant { get; set; }
    }
}
