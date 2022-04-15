using System.ComponentModel.DataAnnotations;

namespace API_MySIRH.Entities
{
    public class Collaborateur : EntityBase
    {

        /**
        / TODO : Foreign key & navigabilité
        *----------------------------------------------------
        *    public Post Poste { get; set; } 
        *    public SkillCenter SkillCenter { get; set; } 
        *    public Site Site { get; set; } 
        *    public Niveau Niveau { get; set; } 
        *    public TypeContrat TypeContrat { get; set; } 
        */

        public string Nom { get; set; } = String.Empty;
        public string Prenom { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public DateTime DateNaissance { get; set; }
        public string Matricule { get; set; } = String.Empty;
        public string Civilite { get; set; } = String.Empty;
        public string Poste { get; set; } = String.Empty;
        public string SkillCenter { get; set; } = String.Empty;
        public string Site { get; set; } = String.Empty;
        public string TypeContrat { get; set; } = String.Empty;
        public string AutreTechnos { get; set; } = String.Empty;
        public string ModeRecrutement { get; set; } = String.Empty;
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


        // public string Niveau { get; set; } = String.Empty;

        public virtual int? NiveauId { get; set; }
        public virtual Niveau? Niveau { get; set; }

    }
}