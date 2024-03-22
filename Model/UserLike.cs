using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatingApp.Model
{
    [Table("user-like")]
    public class UserLike
    {
        [Key]
        public Guid Id { get; set; }
    }
}
