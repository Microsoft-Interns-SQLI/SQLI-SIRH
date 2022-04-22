using System.ComponentModel.DataAnnotations.Schema;

namespace API_MySIRH.Entities
{
    public class Document : EntityBase
    {
        public string FileName { get; set; } = String.Empty;
        public Guid FileId { get; set; } = new Guid(); // 12345678-1234-1234-1234-123412345678
        public string Type { get; set; } = String.Empty;
        public string URL { get; set; } = String.Empty;
        public int CollaborateurId { get; set; }
        public Collaborateur? Collaborateur { get; set; }
    }
}