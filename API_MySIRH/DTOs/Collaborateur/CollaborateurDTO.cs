using System.ComponentModel.DataAnnotations;

namespace API_MySIRH.DTOs.Collaborateur
{
    public class CollaborateurDTO : DtoBase
    {
        public string Nom { get; set; } = String.Empty;
        public string Prenom { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public string Matricule { get; set; } = String.Empty;
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
        public DateTime DateNaissance { get; set; }
        public DateTime? DatePremiereExperience { get; set; }
        public DateTime? DateEntreeSqli { get; set; }
        public DateTime? DateSortieSqli { get; set; }
        public DateTime? DateDebutStage { get; set; }
        public string Certifications { get; set; } = String.Empty;
        public bool HadAlreadyWorkedAtSQLI { get; set; }

        // Relations
        public PostDTO? Poste { get; set; }
        public SkillCenterDTO? SkillCenter { get; set; }
        public SiteDTO? Site { get; set; }
        public NiveauDTO? Niveau { get; set; }
        public TypeContratDTO? TypeContrat { get; set; }
        public ModeRecrutementDTO? ModeRecrutement { get; set; }
        public ICollection<DiplomeDTO>? DiplomesList { get; set; }
        public ICollection<FileDTO>? Documents { get; set; }
    }
}