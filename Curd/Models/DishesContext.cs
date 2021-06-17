using Microsoft.EntityFrameworkCore;

namespace Curd.Models
{
    public class DishesContext :DbContext
    {
        public DishesContext(DbContextOptions options) : base(options){}

        public DbSet<Dish> Dishes{get; set;}
    }
}