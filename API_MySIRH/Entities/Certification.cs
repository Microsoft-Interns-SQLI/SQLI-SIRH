namespace API_MySIRH.Entities
{
    public class Certification : EntityBase
    {
        public string Libelle { get; set; }

        public virtual ICollection<Collaborateur> Collaborateurs { get; set; }

        public List<CollaborateurCertification> CollaborateurCertifications { get; set; }
    }
}
