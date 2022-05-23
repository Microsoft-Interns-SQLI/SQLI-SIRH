namespace API_MySIRH.DTOs
{
    public class ImageDTO
    {
        public Guid Id { get; set; }
        public string URL { get; set; }
        public string Name { get; set; }
        public int CollaborateurId { get; set; }
    }
}
