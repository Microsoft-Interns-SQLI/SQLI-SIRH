using API_MySIRH.Entities;

namespace API_MySIRH.Interfaces
{
    public interface ICollaborateurTypeContratRepository
    {
        Task<List<CollaborateurTypeContrat>> GetAllCollabsContrats();
        Task<List<CollaborateurTypeContrat>> GetAllCollabsContratsByCollab(int idCollaborateur);
        Task<CollaborateurTypeContrat?> GetCollabContratById(int idCollabContrat);
        Task<CollaborateurTypeContrat> AddCollabContrat(CollaborateurTypeContrat collaborateurTypeContrat);
        Task UpdateCollabContrat(CollaborateurTypeContrat collaborateurTypeContrat);
        Task DeleteCollabContrat(int id);

        Task<List<TypeContrat>> GetContratsByCollaborateur(int idCollaborateur);
        Task<List<Collaborateur>> GetCollaborateursByContrat(int idContrat);

        Task<CollaborateurTypeContrat> GetCurrentContrat(int idCollaborateur);
    }
}