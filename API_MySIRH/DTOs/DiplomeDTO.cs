using System.ComponentModel.DataAnnotations;

namespace API_MySIRH.DTOs
{
    public class DiplomeDTO : DtoBase
    {
        public int? Annee { get; set; }
        public string? Label { get; set; }
        public string? Detail { get; set; }
        public string? Description { get; set; }
    }
}