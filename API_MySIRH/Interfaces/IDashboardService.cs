using API_MySIRH.DTOs;
using API_MySIRH.DTOs.Collaborateur;
using static API_MySIRH.Services.DashboardService;

namespace API_MySIRH.Interfaces
{
    public interface IDashboardService
    {
        public double GetFemaleCount(IEnumerable<CollaborateurDTO> collaborateurs);
        public double GetMaleCount(IEnumerable<CollaborateurDTO> collaborateurs);
        public double GetHeadCount(IEnumerable<CollaborateurDTO> collaborateurs);
        public double GetAverageAge(IEnumerable<CollaborateurDTO> collaborateurs);
        public int GetHeadCountPerPoste (IEnumerable<CollaborateurDTO> collaborateurs,string postName);
        public int GetHeadCountPerNiveaux(IEnumerable<CollaborateurDTO> collaborateurs, string niveauName);

    }
}
