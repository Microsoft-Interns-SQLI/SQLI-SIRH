namespace API_MySIRH.DTOs
{
    public class DashboardDto :DtoBase
    {
        public double FemaleCount { get; set; } 
        public double MaleCount { get; set; } 
        public double RateEncadrement { get; set; }
        public double HeadCount { get; set; }
        public double AverageExperience { get; set; }
        public double RateEmploi { get; set; }
        public double TurnOver { get; set; }
        public double RateSousTraitance { get; set; }
        public double RateSatisfaction { get; set; }
        public double AverageAge { get; set; }
        public double CountTLRH { get; set; }
    }
}
