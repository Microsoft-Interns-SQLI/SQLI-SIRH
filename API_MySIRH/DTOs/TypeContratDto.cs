using System.ComponentModel.DataAnnotations;

namespace API_MySIRH.DTOs
{
    public class TypeContratDto : DtoBase
    {
        [Required(ErrorMessage = "This field is required!")]
        public string Name { get; set; }
    }
}
