using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace DatingApp.Model
{
    [Table("User-Table")]
    public class AppUser
    {
        [Key]
        [Required]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Username { get; set; }
        [AllowNull]
        public DateOnly DateOfBirth { get; set; } = DateOnly.MinValue;
        public string KnownAs { get; set; } = string.Empty;
        public DateTime Created { get; set; } = DateTime.UtcNow;
        public DateTime LastActive { get; set; } = DateTime.UtcNow;
        [AllowNull]
        public string Gender { get; set; }
        [AllowNull]
        public string Introduction { get; set; }
        [AllowNull]
        public string LookingFor { get; set; }
        [AllowNull]
        public string Interests { get; set; }
        [AllowNull]
        public string City { get; set; }
        [AllowNull]
        public string Country { get; set; }
        [AllowNull] [ForeignKey("user-like")] public Guid UserLikeId { get; set; }
    }
}
