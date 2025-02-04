using System.ComponentModel.DataAnnotations;

namespace backend_dotnet8.DTOs.Auth
{
    public class UpdateRoleDTOcs
    {
        [Required(ErrorMessage = "UserName is Required")]
        public string UserName { get; set; }

        public RoleType NewRole { get; set; }
    }

    public enum RoleType
    {

        Admin,
        Manager,
        User
    }
}
