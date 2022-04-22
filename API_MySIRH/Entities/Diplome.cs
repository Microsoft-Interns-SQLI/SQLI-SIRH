using System.ComponentModel.DataAnnotations;

namespace API_MySIRH.Entities
{
    public class Diplome : EntityBase
    {
        public int? Annee { get; set; }
        public string? Label { get; set; } = String.Empty;
        public string? Detail { get; set; } = String.Empty;
        public string? Description { get; set; } = String.Empty;
    }
}