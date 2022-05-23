using API_MySIRH.Entities;

namespace API_MySIRH.Interfaces
{
    public interface ICollaborateurFormationRepository
    {
        Task<List<CollaborateurFormation>> GetAll();
        Task<List<CollaborateurFormation>> GetByCollaborateur(int id);
        Task<List<CollaborateurFormation>> GetByFormation(int id);
        Task<CollaborateurFormation> GetOne(int collaborateurId, int formationId);
        Task Add(CollaborateurFormation collaborateurFormation);
        Task Update(CollaborateurFormation collaborateurFormation);
        Task Delete(CollaborateurFormation collaborateurFormation);

        Task<List<int>> GetAnnees();

        Task<List<int>> GetAnneesByCollaborateur(int id);
    }
}
