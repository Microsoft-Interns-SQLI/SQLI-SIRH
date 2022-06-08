using API_MySIRH.Entities;

namespace API_MySIRH.Interfaces
{
    public interface ICollaborateurFormationRepository
    {
        Task<List<CollaborateurFormation>> GetAll();

        Task<CollaborateurFormation> GetById(int id);
        Task<List<CollaborateurFormation>> GetByCollaborateur(int id);
        Task<List<CollaborateurFormation>> GetByFormation(int id);
        Task<List<CollaborateurFormation>> GetByCollabAndFormation(int collabId, int formationId);
        Task<CollaborateurFormation> Add(CollaborateurFormation collaborateurFormation);
        Task<CollaborateurFormation> Update(CollaborateurFormation collaborateurFormation);
        Task Delete(CollaborateurFormation collaborateurFormation);

        Task<List<int>> GetAnnees();

        Task<List<int>> GetAnneesByCollaborateur(int id);
    }
}
