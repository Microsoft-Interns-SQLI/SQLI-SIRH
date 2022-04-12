namespace API_MySIRH.Entities
{
    public class Niveau : EntityBase
    {
        public string Name { get; set; } = String.Empty;
        public virtual List<Collaborateur> Collaborateurs { get; set; }
    }
}