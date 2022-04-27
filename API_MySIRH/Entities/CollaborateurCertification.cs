using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_MySIRH.Entities
{
    public class CollaborateurCertification
    {
        public string? Status { get; set; }
        public DateTime? DateDebut { get; set; } 
        public DateTime? DateFin { get; set; }

        public int CollaborateurId { get; set; }
        public virtual Collaborateur Collaborateur { get; set; }

        public int CertificationId { get; set; }
        public virtual Certification Certification { get; set; }
    }
}
