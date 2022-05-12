using API_MySIRH.DTOs;

namespace API_MySIRH.Interfaces
{
    public interface ICollaborateurTypeContratService
    {
        Task<List<CollaborateurTypeContratDTO>?> GetAllCollabsContrats();
        Task<List<CollaborateurTypeContratDTO>?> GetAllCollabsContratsByCollab(int idCollaborateur);
        Task<CollaborateurTypeContratDTO> GetCollabContratById(int idCollabTypeContrat);
        Task<CollaborateurTypeContratDTO> AddCollabContrat(CollaborateurTypeContratDTO collaborateurTypeContratDTO);
        Task UpdateCollabContrat(CollaborateurTypeContratDTO collaborateurTypeContratDTO);
        Task DeleteCollabContrat(int idCollabContrat);

        Task<List<CollaborateurDTO>> GetCollaborateursByContrat(int idContrat);
        Task<List<TypeContratDTO>> GetContratsByCollaborateur(int idCollaborateur);
    }
}