using API_MySIRH.DTOs;

namespace API_MySIRH.Interfaces
{
    public interface IDashboardService
    {
        public double GetHeadCount();
        public double GetDemissionCount();
        public double GetFemaleCount();
        public double GetMaleCount();
        public double GetAverageAge();
        public double GetHeadCountPerPoste (string postName);
        public double GetHeadCountPerNiveaux( string niveauName);
        public double GetAverageExp();
        public double GetTauxSoustraitant();

    }
}
