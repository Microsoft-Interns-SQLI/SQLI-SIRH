using System.ComponentModel.DataAnnotations;

namespace API_MySIRH.DTOs
{
    public class CollaborateurDTO : DtoBase
    {
        [Required(ErrorMessage = "Le nom est obligatoire")]
        public string Nom { get; set; } = String.Empty;
        [Required(ErrorMessage = "Le prénom est obligatoire")]
        public string Prenom { get; set; } = String.Empty;
        [Required(ErrorMessage = "La matricule est obligatoire")]
        [StringLength(8, ErrorMessage = "La matricule se constitue de 5 charactéres minimum jusqu'à 10 charactéres maximum.", MinimumLength = 5)]
        public string Matricule { get; set; } = String.Empty;
        //todo validate the char : H/F
        [Required(ErrorMessage = "La civilité est obligatoire")]
        [StringLength(1, ErrorMessage = "Civilité doit être soit 'H'~Homme soit 'F'~Femme.")]
        public string Civilite { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public string AutreTechnos { get; set; } = String.Empty;
        public string SituationFamiliale { get; set; } = String.Empty;
        public string NumCin { get; set; } = String.Empty;
        public string Nationnalite { get; set; } = String.Empty;
        public string LieuNaissance { get; set; } = String.Empty;
        public string PhoneProfesionnel { get; set; } = String.Empty;
        public string PhonePersonnel { get; set; } = String.Empty;
        public string EmailPersonnel { get; set; } = String.Empty;
        public string Adresse { get; set; } = String.Empty;
        public string Langues { get; set; } = String.Empty;
        public string Note { get; set; } = String.Empty;
        [Required(ErrorMessage = "la date de naissance est obligatoire")]
        public DateTime DateNaissance { get; set; }
        public DateTime? DatePremiereExperience { get; set; }
        public DateTime? DateEntreeSqli { get; set; }
        public DateTime? DateSortieSqli { get; set; }
        public DateTime? DateDebutStage { get; set; }

        // Relations
        public int? PosteId { get; set; }
        public PostDTO? Poste { get; set; }
        public int? SkillCenterId { get; set; }
        public SkillCenterDTO? SkillCenter { get; set; }
        public int? SiteId { get; set; }
        public SiteDTO? Site { get; set; }
        public int? NiveauId { get; set; }
        public NiveauDTO? Niveau { get; set; }
        public int? ModeRecrutementId { get; set; }
        public ModeRecrutementDTO? ModeRecrutement { get; set; }
        public ICollection<DiplomeDTO>? Diplomes { get; set; }
        public ICollection<FileDTO>? Documents { get; set; }

        //public ICollection<CertificationDTO>? Certifications { get; set; }
    }
}