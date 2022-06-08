using API_MySIRH.Entities;

namespace API_MySIRH.Interfaces
{
    public interface ICollaborateurCertificationRepository
    {
        Task<List<CollaborateurCertification>> GetAll();
        Task<CollaborateurCertification> GetById(int id);
        Task<List<CollaborateurCertification>> GetByCollaborateur(int id);
        Task<List<CollaborateurCertification>> GetByCertification(int id);
        Task<List<CollaborateurCertification>> GetByCollabAndCertif(int collaborateurId, int certificationId);
        Task<CollaborateurCertification> Add(CollaborateurCertification collaborateurCertification);
        Task<CollaborateurCertification> Update(CollaborateurCertification collaborateurCertification);
        Task Delete(CollaborateurCertification collaborateurCertification);

        Task<List<int>> GetAnnees();
        Task<List<int>> GetAnneesByCollaborateur(int id);
    }
}
