namespace API_MySIRH.Entities
{
    public class CollaborateurTypeContrat : EntityBase
    {
        public DateTime? DateDebut { get; set; }
        public DateTime? DateFin { get; set; }
        public virtual int? TypeContratId { get; set; }
        public virtual TypeContrat? TypeContrat { get; set; }
        public virtual int? CollaborateurId { get; set; }
        public virtual Collaborateur? Collaborateur { get; set; }
    }

}