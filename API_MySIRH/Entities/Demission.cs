namespace API_MySIRH.Entities
{
    public class Demission : EntityBase
    {
        public DateTime? DateSortieSqli { get; set; } // cas exception
        public DateTime? DateDemission { get; set; }
        public string ReasonDemission { get; set; } = string.Empty;
        public bool IsCanceled { get; set; } = false;
        public int CollaborateurId { get; set; }
        public Collaborateur? Collaborateur { get; set; }
    }
}
