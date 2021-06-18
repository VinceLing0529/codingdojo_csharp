using Microsoft.EntityFrameworkCore;

namespace Curd.Models
{
    public class UsersContext :DbContext
    {
        public UsersContext(DbContextOptions options) : base(options){}

        public DbSet<User> Users{get; set;}
    }
}