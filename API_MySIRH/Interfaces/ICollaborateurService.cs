using API_MySIRH.DTOs;
using API_MySIRH.Helpers;

namespace API_MySIRH.Interfaces
{
    public interface ICollaborateurService
    {
        Task<PagedList<CollaborateurDTO>> GetCollaborateurs(FilterParams filterParams);
        Task<PagedList<CollaborateurDTO>> GetDemissions(FilterParams filterParams);
        IEnumerable<CollaborateurDTO> GetCollaborateurs();
        Task<CollaborateurDTO> GetCollaborateurById(int id);
        Task<CollaborateurDTO> GetCollaborateurByMatricule(string matricule);
        Task<CollaborateurDTO> GetCollaborateurByEmail(string email);

        Task UpdateCollaborateur(CollaborateurDTO collaborateur);
        Task<CollaborateurDTO> AddCollaborateur(CollaborateurDTO collaborateur);
        Task DeleteCollaborateur(int id);

        Task<bool> CollaborateurExistsById(int id);
        Task<bool> CollaborateurExistsByMatricule(string matricule);
        Task<bool> CollaborateurExistsByEmail(string email);
        Task<IEnumerable<DateTime>> GetIntegrationsYearsRange();
        Task<PagedList<CollaborateurDTO>> GetIntegrations(FilterParams filterParams);
    }
}