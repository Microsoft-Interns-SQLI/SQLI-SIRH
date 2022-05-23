namespace API_MySIRH.Entities
{
    public class Carriere : EntityBase
    {
        public virtual int? CollaborateurId { get; set; }
        public virtual Collaborateur? Collaborateur { get; set; }
        public virtual int? NiveauId { get; set; }
        public virtual Niveau? Niveau { get; set; }
        public virtual int? PosteId { get; set; }
        public virtual Post? Poste { get; set; }
        public string? ProfilDeCout { get; set; }
        public float? SalaireNet { get; set; }
        public float? VariableNet { get; set; }
        public float? SalaireBrut { get; set; }
        public float? VariableBrut { get; set; }
        public string? TLRH { get; set; }
    }
}