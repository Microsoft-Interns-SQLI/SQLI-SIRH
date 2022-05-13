namespace API_MySIRH.DTOs
{
    public class DemissionDTO : DtoBase
    {
        public DateTime? DateSortieSqli { get; set; } // cas exception
        public DateTime? DateDemission { get; set; }
        public string ReasonDemission { get; set; } = string.Empty;
        public bool IsCanceled { get; set; }
    }
}
