using API_MySIRH.DTOs;

namespace API_MySIRH.Interfaces
{
    public interface IDashboardService
    {
        public double GetHeadCount(IEnumerable<CollaborateurDTO> collaborateurs);
        public double GetDemissionCount(IEnumerable<CollaborateurDTO> collaborateurs);
        public double GetFemaleCount(IEnumerable<CollaborateurDTO> collaborateurs);
        public double GetMaleCount(IEnumerable<CollaborateurDTO> collaborateurs);
        public double GetAverageAge(IEnumerable<CollaborateurDTO> collaborateurs);
        public double GetHeadCountPerPoste (IEnumerable<CollaborateurDTO> collaborateurs,string postName);
        public double GetHeadCountPerNiveaux(IEnumerable<CollaborateurDTO> collaborateurs, string niveauName);

    }
}
