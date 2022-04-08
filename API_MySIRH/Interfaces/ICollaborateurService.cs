using API_MySIRH.DTOs;
using API_MySIRH.Helpers;

namespace API_MySIRH.Interfaces
{
    public interface ICollaborateurService
    {
        Task<PagedList<CollaborateurDTO>> GetCollaborateurs(FilterParams filterParams);
        Task<CollaborateurDTO> GetCollaborateurById(int id);
        Task<CollaborateurDTO> GetCollaborateurByMatricule(string matricule);
        Task<CollaborateurDTO> GetCollaborateurByEmail(string email);
        Task UpdateCollaborateur(int id, CollaborateurDTO collaborateur);
        Task<CollaborateurDTO> AddCollaborateur(CollaborateurDTO collaborateur);
        Task DeleteCollaborateur(int id);

        Task<bool> CollaborateurExistsById(int id);
        Task<bool> CollaborateurExistsByMatricule(string matricule);
        Task<bool> CollaborateurExistsByEmail(string email);
    }
}