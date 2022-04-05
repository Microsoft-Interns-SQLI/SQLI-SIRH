using API_MySIRH.DTOs;
using API_MySIRH.Helpers;

namespace API_MySIRH.Interfaces
{
    public interface ICollaborateurService
    {
        Task<PagedList<CollaborateurDTO>> GetCollaborateurs(FilterParams filterParams);
        Task<CollaborateurDTO> GetCollaborateur(int id);
        Task UpdateCollaborateur(int id, CollaborateurDTO collaborateur);
        Task<CollaborateurDTO> AddCollaborateur(CollaborateurDTO collaborateur);
        Task DeleteCollaborateur(int id);
    }
}