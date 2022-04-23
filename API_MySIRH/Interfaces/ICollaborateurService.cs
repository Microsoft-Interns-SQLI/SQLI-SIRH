using API_MySIRH.DTOs.Collaborateur;
using API_MySIRH.Helpers;

namespace API_MySIRH.Interfaces
{
    public interface ICollaborateurService
    {
        Task<PagedList<CollaborateurDTO>> GetCollaborateurs(FilterParams filterParams);
        IEnumerable<CollaborateurDTO> GetCollaborateurs();
        Task<CollaborateurDTO> GetCollaborateurById(int id);
        Task<CollaborateurDTO> GetCollaborateurByMatricule(string matricule);
        Task<CollaborateurDTO> GetCollaborateurByEmail(string email);

        Task UpdateCollaborateur(int id, CollaborateurInsertDTO collaborateur);
        Task<CollaborateurDTO> AddCollaborateur(CollaborateurInsertDTO collaborateur);
        Task DeleteCollaborateur(int id);

        Task<bool> CollaborateurExistsById(int id);
        Task<bool> CollaborateurExistsByMatricule(string matricule);
        Task<bool> CollaborateurExistsByEmail(string email);
    }
}