using System.ComponentModel.DataAnnotations;
using API_MySIRH.Entities;

namespace API_MySIRH.DTOs
{
    public class CollaborateurDTO : DtoBase
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
        public string Diplomes { get; set; } = String.Empty;
        public string Certifications { get; set; } = String.Empty;
        public bool HadAlreadyWorkedAtSQLI { get; set; }
        public string Files { get; set; } = String.Empty;

        // Relations
        // public ICollection<DiplomeDTO> DiplomesList { get; set; }

        public PostDTO? Post { get; set; }
        public SkillCenterDTO? SkillCenter { get; set; }
        public SiteDTO? Site { get; set; }
        public NiveauDTO? Niveau { get; set; }
        public TypeContratDTO? TypeContrat { get; set; }
        public ModeRecrutementDTO? ModeRecrutement { get; set; }

        // public CollaborateurDTO()
        // {
        //     this.DiplomesList = new List<DiplomeDTO>();
        // }
    }
}