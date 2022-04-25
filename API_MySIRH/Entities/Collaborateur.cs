using System.ComponentModel.DataAnnotations;

namespace API_MySIRH.Entities
{
    public class Collaborateur : EntityBase
    {
        public string Nom { get; set; } = String.Empty;
        public string Prenom { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public DateTime DateNaissance { get; set; }
        public string Matricule { get; set; } = String.Empty;
        public string Civilite { get; set; } = String.Empty;
        public string AutreTechnos { get; set; } = String.Empty; //todo : validation => table relation one-to-many
        public string NumCin { get; set; } = String.Empty;
        public string Nationnalite { get; set; } = String.Empty;
        public string LieuNaissance { get; set; } = String.Empty;
        public string PhoneProfesionnel { get; set; } = String.Empty;
        public string PhonePersonnel { get; set; } = String.Empty;
        public string EmailPersonnel { get; set; } = String.Empty;
        public string Adresse { get; set; } = String.Empty;
        public string Langues { get; set; } = String.Empty; //todo : table relation one-to-many
        public string Note { get; set; } = String.Empty; //todo : table relation one-to-many
        public DateTime? DatePremiereExperience { get; set; } // cas exception
        public DateTime? DateEntreeSqli { get; set; } // cas exception
        public DateTime? DateSortieSqli { get; set; } // cas exception
        public DateTime? DateDebutStage { get; set; } // cas exception
        public string Certifications { get; set; } = String.Empty; //todo : table relation one-to-many
        public bool HadAlreadyWorkedAtSQLI { get; set; }
        /**
        *  Foreign key & navigabilité
        */
        public string SituationFamiliale { get; set; } = String.Empty; //todo : table relation

        public virtual int? ModeRecrutementId { get; set; }
        public virtual ModeRecrutement? ModeRecrutement { get; set; }
        public virtual int? SiteId { get; set; }
        public virtual Site? Site { get; set; }
        public virtual int? SkillCenterId { get; set; }
        public virtual SkillCenter? SkillCenter { get; set; }
        public virtual int? TypeContratId { get; set; }
        public virtual TypeContrat? TypeContrat { get; set; }
        public virtual int? PosteId { get; set; }
        public virtual Post? Poste { get; set; }
        public virtual int? NiveauId { get; set; }
        public virtual Niveau? Niveau { get; set; }
        public virtual ICollection<Diplome> DiplomesList { get; set; }
        public virtual ICollection<Document> DocumentsList { get; set; }

        public Collaborateur()
        {
            this.DiplomesList = new List<Diplome>();
            this.DocumentsList = new List<Document>();
        }
    }
}