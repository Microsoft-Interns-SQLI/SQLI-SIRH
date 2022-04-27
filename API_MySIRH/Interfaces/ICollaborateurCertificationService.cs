using API_MySIRH.DTOs;

namespace API_MySIRH.Interfaces
{
    public interface ICollaborateurCertificationService
    {
        Task<List<CollaborateurCertificationDTO>> GetAll();
        Task<List<CollaborateurCertificationDTO>> GetByCollaborateur(int id);
        Task<List<CollaborateurCertificationDTO>> GetByCertification(int id);
        Task<CollaborateurCertificationDTO> GetOne(int collaborateurId, int certificationId);
        Task Add(CollaborateurCertificationDTO collaborateurCertification);
        Task Update(CollaborateurCertificationDTO collaborateurCertification);
        Task Delete(CollaborateurCertificationDTO collaborateurCertification);
    }
}
