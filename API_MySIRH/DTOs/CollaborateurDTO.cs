using System.ComponentModel.DataAnnotations;

namespace API_MySIRH.DTOs
{
    public class CollaborateurDTO : DtoBase
    {


        [Required(ErrorMessage = "le nom est obligatoire")]
        public string Nom { get; set; }

        [Required(ErrorMessage = "le prénom est obligatoire")]
        public string Prenom { get; set; } = String.Empty;

        [Required(ErrorMessage = "la date de naissance est obligatoire")]
        [RegularExpression(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$", ErrorMessage = "Le format de la date est invalid.")]
        public DateTime DateNaissance { get; set; }

        [Required(ErrorMessage = "la matricule est obligatoire")]
        [StringLength(8, ErrorMessage = "La matricule se constitue de 5 charactéres minimum jusqu'à 10 charactéres maximum.", MinimumLength = 5)]
        public string Matricule { get; set; } = String.Empty;

        [Required(ErrorMessage = "la civilité est obligatoire")]
        [StringLength(1, ErrorMessage = "Civilité doit être soit 'H'~Homme soit 'F'~Femme.")]
        public string Civilite { get; set; } = String.Empty;

        /**
        / TODO : Foreign key & navigabilité
        *----------------------------------------------------
        *    public Post Poste { get; set; } 
        *    public SkillCenter SkillCenter { get; set; } 
        *    public Site Site { get; set; } 
        *    public Niveau Niveau { get; set; } 
        *    public TypeContrat TypeContrat { get; set; } 
        */

        public string ModeRecrutement { get; set; } = String.Empty;

        [RegularExpression(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$", ErrorMessage = "Le format de la date est invalid.")]
        public DateTime? DatePremiereExperience { get; set; }

        [RegularExpression(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$", ErrorMessage = "Le format de la date est invalid.")]
        public DateTime? DateEntreeSqli { get; set; }

        [RegularExpression(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$", ErrorMessage = "Le format de la date est invalid.")]
        public DateTime? DateSortieSqli { get; set; }

        [RegularExpression(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$", ErrorMessage = "Le format de la date est invalid.")]
        public DateTime? DateDebutStage { get; set; }

        public string Diplomes { get; set; } = String.Empty;

    }
}