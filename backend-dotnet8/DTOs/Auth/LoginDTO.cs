using System.ComponentModel.DataAnnotations;

namespace backend_dotnet8.DTOs.Auth
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "User Name is Required!")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required!")]
        public string Password { get; set; }

    }
}
