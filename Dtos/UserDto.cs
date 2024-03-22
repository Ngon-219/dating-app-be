using System.ComponentModel.DataAnnotations;

namespace DatingApp.Dtos
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
