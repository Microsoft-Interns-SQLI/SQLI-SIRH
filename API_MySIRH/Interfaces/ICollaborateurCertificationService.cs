using API_MySIRH.DTOs;
using API_MySIRH.Entities;
using API_MySIRH.Helpers;

namespace API_MySIRH.Interfaces
{
    public interface ICollaborateurCertificationService
    {
        Task<CollaborateurCertificationResponse> GetAll(FilterParamsForCertifAndFormation filter);
        Task<CollaborateurCertificationResponse> GetByCollaborateur(int id, FilterParamsForCertifAndFormation filter);
        Task<List<CollaborateurCertificationDTO>> GetByCertification(int id);
        Task<CollaborateurCertificationDTO> GetOne(int collaborateurId, int certificationId);
        Task Add(CollaborateurCertificationDTO collaborateurCertification);
        Task Update(CollaborateurCertificationDTO collaborateurCertification);
        Task Delete(CollaborateurCertificationDTO collaborateurCertification);

        Task<List<int>> GetAnnees();
        Task<List<int>> GetAnneesByCollaborateur(int id);
    }
}
