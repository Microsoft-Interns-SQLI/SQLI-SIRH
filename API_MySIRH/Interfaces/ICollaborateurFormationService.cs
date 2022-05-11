using API_MySIRH.DTOs;
using API_MySIRH.Entities;

namespace API_MySIRH.Interfaces
{
    public interface ICollaborateurFormationService
    {
        Task<List<CollaborateurFormationDTO>> GetAll(Status status);
        Task<List<CollaborateurFormationDTO>> GetByCollaborateur(int id);
        Task<List<CollaborateurFormationDTO>> GetByFormation(int id);
        Task<CollaborateurFormationDTO> GetOne(int collaborateurId, int formationId);
        Task Add(CollaborateurFormationDTO collaborateurFormation);
        Task Update(CollaborateurFormationDTO collaborateurFormation);
        Task Delete(CollaborateurFormationDTO collaborateurFormation);
    }
}
