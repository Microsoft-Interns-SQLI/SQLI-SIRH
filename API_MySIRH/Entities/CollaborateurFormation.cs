namespace API_MySIRH.Entities
{
    public class CollaborateurFormation
    {
        public Status? Status { get; set; }
        public DateTime? DateDebut { get; set; }
        public DateTime? DateFin { get; set; }

        public int CollaborateurId { get; set; }
        public virtual Collaborateur Collaborateur { get; set; }

        public int FormationId { get; set; }
        public virtual Formation Formation { get; set; }
    }
}
