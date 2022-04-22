using System.ComponentModel.DataAnnotations.Schema;

namespace API_MySIRH.Entities
{
    public class Document : EntityBase
    {
        public string FileName { get; set; } = String.Empty;
        public Guid FileId { get; set; } = new Guid();
        public string Type { get; set; } = String.Empty;
        public string URL { get; set; } = String.Empty;
        public int CollaborateurId { get; set; }
        public Collaborateur? Collaborateur { get; set; }
    }
}