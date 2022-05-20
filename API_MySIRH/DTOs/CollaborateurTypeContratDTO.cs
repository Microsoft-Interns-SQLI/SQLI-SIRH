using System.ComponentModel.DataAnnotations;

namespace API_MySIRH.DTOs
{
    public class CollaborateurTypeContratDTO : DtoBase
    {
        [Required(ErrorMessage = "la date début est obligatoire")]
        public DateTime DateDebut { get; set; }
        public DateTime? DateFin { get; set; }
        public bool IsInSQLI { get; set; }
        [Required(ErrorMessage = "le type du contrat est obligatoire")]
        public virtual int? TypeContratId { get; set; }
        public virtual TypeContratDTO? TypeContrat { get; set; }
        public virtual int? CollaborateurId { get; set; }
        public virtual CollaborateurDTO? Collaborateur { get; set; }
    }
}