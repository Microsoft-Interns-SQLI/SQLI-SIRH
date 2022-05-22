using System.ComponentModel.DataAnnotations;

namespace API_MySIRH.DTOs
{
    public class DiplomeDTO : DtoBase
    {
        [Required(ErrorMessage = "l'année d'obtention du diplôme est obligatoire")]
        public int Annee { get; set; }
        public string? Label { get; set; }
        [Required(ErrorMessage = "le détail est obligatoire")]
        public string Detail { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int CollaborateurId { get; set; }
    }
}