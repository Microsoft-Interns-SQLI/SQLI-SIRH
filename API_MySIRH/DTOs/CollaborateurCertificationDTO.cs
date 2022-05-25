namespace API_MySIRH.DTOs
{
    public class CollaborateurCertificationDTO : DtoBase
    {
        public string? Status { get; set; }
        public DateTime? DateDebut { get; set; }
        public DateTime? DateFin { get; set; }
        public int CollaborateurId { get; set; }

        public int CertificationId { get; set; }
    }

    public class CollaborateurCertificationResponse
    {
        public int Annee { get; set; }
        public List<CollaborateurCertificationDTO> List { get; set; }
    }
}
