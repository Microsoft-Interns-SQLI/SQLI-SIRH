namespace API_MySIRH.DTOs
{
    public class FileDTO : DtoBase
    {
        public string FileName { get; set; } = String.Empty;
        public Guid FileId { get; set; } = new Guid();
        public string Type { get; set; } = String.Empty;
        public string URL { get; set; } = String.Empty;
        public int CollaborateurId { get; set; }
    }
}