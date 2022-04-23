using System.ComponentModel.DataAnnotations;

namespace API_MySIRH.DTOs.Collaborateur
{
    public class CollaborateurInsertDTO : DtoBase
    {
        [Required(ErrorMessage = "le nom est obligatoire")]
        public string Nom { get; set; } = String.Empty;

        [Required(ErrorMessage = "le prénom est obligatoire")]
        public string Prenom { get; set; } = String.Empty;

        public string Email { get; set; } = String.Empty;

        [Required(ErrorMessage = "la date de naissance est obligatoire")]
        public DateTime DateNaissance { get; set; }

        [Required(ErrorMessage = "la matricule est obligatoire")]
        [StringLength(8, ErrorMessage = "La matricule se constitue de 5 charactéres minimum jusqu'à 10 charactéres maximum.", MinimumLength = 5)]
        public string Matricule { get; set; } = String.Empty;

        //todo validate the char : H/F
        [Required(ErrorMessage = "la civilité est obligatoire")]
        [StringLength(1, ErrorMessage = "Civilité doit être soit 'H'~Homme soit 'F'~Femme.")]
        public string Civilite { get; set; } = String.Empty;
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
        public DateTime? DatePremiereExperience { get; set; }
        public DateTime? DateEntreeSqli { get; set; }
        public DateTime? DateSortieSqli { get; set; }
        public DateTime? DateDebutStage { get; set; }
        public string Certifications { get; set; } = String.Empty;
        public bool HadAlreadyWorkedAtSQLI { get; set; }

        // Relations
        public int? PosteId { get; set; }
        public int? SkillCenterId { get; set; }
        public int? SiteId { get; set; }
        public int? NiveauId { get; set; }
        public int? TypeContratId { get; set; }
        public int? ModeRecrutementId { get; set; }

        // todo : should keep in InsertDTO or not ..
        // public ICollection<DiplomeDTO> DiplomesList { get; set; }
        // public ICollection<FileDTO>? Documents { get; set; }

        public CollaborateurInsertDTO()
        {
            // this.DiplomesList = new List<DiplomeDTO>();
            // this.Documents = new List<FileDTO>();
        }
    }
}