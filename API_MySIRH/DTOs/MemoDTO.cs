namespace API_MySIRH.DTOs
{
    public class MemoDTO : DtoBase
    {
        public string Titre { get; set; }
        public string HtmlContent { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
    }
}
