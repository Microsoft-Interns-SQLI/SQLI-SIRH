using System.ComponentModel.DataAnnotations;

namespace API_MySIRH.Entities.Auth.Dtos.incoming
{
    public class UserRequestLoginDto
    {

        [Required(ErrorMessage ="UserName is Required")]
        public string username { get; set; }
        [Required(ErrorMessage ="Password is Required")]
        public string Password { get; set; }
    }
}
