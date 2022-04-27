using API_MySIRH.DTOs.Collaborateur;

namespace API_MySIRH.DTOs
{
    public class CollaborateurCertificationDTO
    {
        public string? Status { get; set; }
        public DateTime? DateDebut { get; set; }
        public DateTime? DateFin { get; set; }

        //public int CollaborateurId { get; set; }
        //public string? Nom { get; set; }
        //public string? Prenom { get; set; }

        public int CollaborateurId { get; set; }

        public int CertificationId { get; set; }
    }
}
