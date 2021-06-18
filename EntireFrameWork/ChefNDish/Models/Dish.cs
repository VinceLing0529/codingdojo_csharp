using System.ComponentModel.DataAnnotations;

namespace ChefNDish.Models
{
    public class Dish
    {
        [Key]
        public int DishID{get; set;}

        [Required]
        public string Name{get;set;}
        [Required]
        [Range(0,5000)]
        public int Calories{get; set;}
        [Required]
        public int Tastiness{get; set;}
        public string Description{get; set;}
        public int ChefId{get;set;}
        public Chef creater{get;set;}
    }
}