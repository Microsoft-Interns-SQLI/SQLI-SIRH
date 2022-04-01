namespace API_MySIRH.DTOs.Auth
{
    public class AuthResponse
    {
        public string accessToken { get; set; }

        public UserDto user { get; set; }
    }
}
