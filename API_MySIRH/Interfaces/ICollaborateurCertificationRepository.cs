using API_MySIRH.Entities;

namespace API_MySIRH.Interfaces
{
    public interface ICollaborateurCertificationRepository
    {
        Task<List<CollaborateurCertification>> GetAll();
        Task<List<CollaborateurCertification>> GetByCollaborateur(int id);
        Task<List<CollaborateurCertification>> GetByCertification(int id);
        Task<CollaborateurCertification> GetOne(int collaborateurId, int certificationId);
        Task Add(CollaborateurCertification collaborateurCertification);
        Task Update(CollaborateurCertification collaborateurCertification);
        Task Delete(CollaborateurCertification collaborateurCertification);

        Task<List<int>> GetAnnees();
        Task<List<int>> GetAnneesByCollaborateur(int id);
    }
}
