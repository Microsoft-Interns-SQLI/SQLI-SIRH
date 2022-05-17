namespace API_MySIRH.Entities
{
    public class Image
    {
        public Guid Id { get; set; }
        public string URL { get; set; }
        public string Name { get; set; }
        public int CollaborateurId { get; set; }
        public Collaborateur Collaborateur { get; set; }
    }
}
