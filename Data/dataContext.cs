using DatingApp.Model;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.Data
{
    public class dataContext:DbContext
    {
        public dataContext(DbContextOptions<dataContext> options) : base(options) { 
        
        }

        public DbSet<AppUser> user { get; set; }
        public DbSet<UserLike> userLike { get; set; }
    }
}
