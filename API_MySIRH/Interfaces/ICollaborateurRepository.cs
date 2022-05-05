using API_MySIRH.Entities;
using API_MySIRH.Helpers;

namespace API_MySIRH.Interfaces
{
    public interface ICollaborateurRepository
    {
        IQueryable<Collaborateur> GetCollaborateurs();
        Task<Collaborateur?> GetCollaborateurById(int id);
        Task<Collaborateur?> GetCollaborateurByMatricule(string matricule);
        Task<Collaborateur?> GetCollaborateurByEmail(string email);
        Task UpdateCollaborateur(Collaborateur collaborateur);
        Task<Collaborateur> AddCollaborateur(Collaborateur collaborateur);
        Task DeleteCollaborateur(int id);
        Task<bool> CollaborateurExistsById(int id);
        Task<bool> CollaborateurExistsByMatricule(string matricule);
        Task<bool> CollaborateurExistsByEmail(string email);
    }
}