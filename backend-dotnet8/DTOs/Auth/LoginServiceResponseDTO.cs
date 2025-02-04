namespace backend_dotnet8.DTOs.Auth
{
    public class LoginServiceResponseDTO
    {
        public string NewToken { get; set; }


        public UserInfo UserInfo { get; set; }
    }
}
