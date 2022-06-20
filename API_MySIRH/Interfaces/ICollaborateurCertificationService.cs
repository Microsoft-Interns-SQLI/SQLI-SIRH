using API_MySIRH.DTOs;
using API_MySIRH.Entities;
using API_MySIRH.Helpers;

namespace API_MySIRH.Interfaces
{
    public interface ICollaborateurCertificationService
    {
        Task<CollaborateurCertificationResponse> GetAll(FilterParamsForCertifAndFormation filter);
        Task<CollaborateurCertificationResponse> GetByCollaborateur(int id, FilterParamsForCertifAndFormation filter);
        Task<CollaborateurCertificationDTO> GetById(int id);
        Task<List<CollaborateurCertificationDTO>> GetByCertification(int id);
        Task<List<CollaborateurCertificationDTO>> GetByCollabAndCertif(int collaborateurId, int certificationId);
        Task<CollaborateurCertificationDTO> Add(CollaborateurCertificationDTO collaborateurCertification);
        Task<CollaborateurCertificationDTO> Update(CollaborateurCertificationDTO collaborateurCertification);
        Task Delete(CollaborateurCertificationDTO collaborateurCertification);

        Task<List<int>> GetAnnees();
        Task<List<int>> GetAnneesByCollaborateur(int id);
    }
}
