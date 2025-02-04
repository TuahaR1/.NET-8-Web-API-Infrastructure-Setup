using System.ComponentModel.DataAnnotations;

namespace backend_dotnet8.DTOs.Auth
{
    public class RegisterDTO
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        [Required(ErrorMessage = "UserName is Required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        public string Password { get; set; }

        public string Address { get; set; }

    }
}
