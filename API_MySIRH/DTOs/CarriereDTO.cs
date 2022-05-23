using System.ComponentModel.DataAnnotations;

namespace API_MySIRH.DTOs
{
    public class CarriereDTO : DtoBase
    {
        public virtual int? CollaborateurId { get; set; }
        public virtual CollaborateurDTO? Collaborateur { get; set; }
        public virtual int? NiveauId { get; set; }
        public virtual NiveauDTO? Niveau { get; set; }
        public virtual int? PosteId { get; set; }
        public virtual PostDTO? Poste { get; set; }
        public string? ProfilDeCout { get; set; }
        public float? SalaireNet { get; set; }
        public float? VariableNet { get; set; }
        public float? SalaireBrut { get; set; }
        public float? VariableBrut { get; set; }
        public string? TLRH { get; set; }
        public int Annee { get; set; }
    }
}