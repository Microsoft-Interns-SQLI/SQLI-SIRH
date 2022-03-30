namespace API_MySIRH.Entities.Auth.Dtos.Generic
{
    public class AuthResult
    {
        public string Token { get; set; }
        public bool success { get; set; }
        public string? Message { get; set; }
        public List<string>? Errors { get; set; }
    }
}
