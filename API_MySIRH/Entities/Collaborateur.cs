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
        public DateTime? DatePremiereExperience { get; set; }
        public DateTime? DateDebutStage { get; set; }
        public DateTime? DateEntreeSqli { get; set; }
        public string SituationFamiliale { get; set; } = String.Empty; //todo : table relation


        /**
        *  Foreign key & navigabilité
        */
        public virtual int? ModeRecrutementId { get; set; }
        public virtual ModeRecrutement? ModeRecrutement { get; set; }
        public virtual int? SiteId { get; set; }
        public virtual Site? Site { get; set; }
        public virtual int? SkillCenterId { get; set; }
        public virtual SkillCenter? SkillCenter { get; set; }
        public virtual ICollection<Diplome>? Diplomes { get; set; }
        public virtual ICollection<Document>? Documents { get; set; }
        public virtual ICollection<Certification> Certifications { get; set; }
        public List<CollaborateurCertification> CollaborateurCertifications { get; set; }
        public virtual ICollection<Formation> Formations { get; set; }
        public List<CollaborateurFormation> CollaborateurFormations { get; set; }
        public virtual ICollection<Carriere>? Carrieres { get; set; }

        // Demmision ?? 
        public ICollection<Demission> Demissions { get; set; }

        public Carriere? GetCurrentCarriere()
        {
            return this.Carrieres?.OrderByDescending(carr => carr.Annee).First();
        }
    }
}