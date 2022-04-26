namespace API_MySIRH.Entities
{
    public class Dashboard : EntityBase
    {
        public double FemaleCount { get; set; } = 0;
        public double MaleCount { get; set; } = 0;
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
