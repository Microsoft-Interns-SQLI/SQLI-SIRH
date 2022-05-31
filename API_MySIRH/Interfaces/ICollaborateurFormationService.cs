using API_MySIRH.DTOs;
using API_MySIRH.Entities;
using API_MySIRH.Helpers;
using API_MySIRH.Services;

namespace API_MySIRH.Interfaces
{
    public interface ICollaborateurFormationService
    {
        Task<CollaborateurFormationResponse> GetAll(FilterParamsForCertifAndFormation filter);
        Task<CollaborateurFormationResponse> GetByCollaborateur(int id, FilterParamsForCertifAndFormation filter);
        Task<List<CollaborateurFormationDTO>> GetByFormation(int id);
        Task<CollaborateurFormationDTO> GetById(int id);
        Task<List<CollaborateurFormationDTO>> GetByCollabAndFormation(int collabId, int formationId);
        Task Add(CollaborateurFormationDTO collaborateurFormation);
        Task Update(CollaborateurFormationDTO collaborateurFormation);
        Task Delete(CollaborateurFormationDTO collaborateurFormation);

        Task<List<int>> GetAnnees();

        Task<List<int>> GetAnneesByCollaborateur(int id);
    }
}
