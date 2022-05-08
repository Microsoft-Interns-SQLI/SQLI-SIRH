namespace API_MySIRH.Entities
{
    public class Formation : EntityBase
    {
        public string Libelle { get; set; }

        public virtual ICollection<Collaborateur> Collaborateurs { get; set; }

        public List<CollaborateurFormation> CollaborateurFormations { get; set; }
    }
}
