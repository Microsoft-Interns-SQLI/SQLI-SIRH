namespace API_MySIRH.Entities
{
    public class Demission : EntityBase
    {
        public DateTime? DateSortieSqli { get; set; } // cas exception
        public DateTime? DateDemission { get; set; }
        public int? ReasonDemissionId { get; set; }
        public ReasonDemission? ReasonDemission { get; set; }
        public string? Comment { get; set; }
        public bool IsCanceled { get; set; } = false;
        public int CollaborateurId { get; set; }
        public Collaborateur? Collaborateur { get; set; }
    }
}
