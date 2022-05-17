namespace API_MySIRH.DTOs
{
    public class CollaborateurTypeContratDTO : DtoBase
    {
        public DateTime? DateDebut { get; set; }
        public DateTime? DateFin { get; set; }
        public bool IsInSQLI { get; set; }
        public virtual int? TypeContratId { get; set; }
        public virtual TypeContratDTO? TypeContrat { get; set; }
        public virtual int? CollaborateurId { get; set; }
        public virtual CollaborateurDTO? Collaborateur { get; set; }
    }
}