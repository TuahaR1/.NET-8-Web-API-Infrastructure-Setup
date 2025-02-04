namespace backend_dotnet8.DTOs.Auth
{
    public class UserInfo
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }
        public string Email { get; set; }

        public DateTime CreatedAt { get; set; }

        public IEnumerable<string> Roles { get; set; }

    }
}
