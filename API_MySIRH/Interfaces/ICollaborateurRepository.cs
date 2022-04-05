using API_MySIRH.Entities;
using API_MySIRH.Helpers;

namespace API_MySIRH.Interfaces
{
    public interface ICollaborateurRepository
    {
        IQueryable<Collaborateur> GetCollaborateurs();
        Task<Collaborateur> GetCollaborateur(int id);
        Task UpdateCollaborateur(int id, Collaborateur collaborateur);
        Task<Collaborateur> AddCollaborateur(Collaborateur collaborateur);
        Task DeleteCollaborateur(int id);
        Task<bool> CollaborateurExists(int id);
    }
}