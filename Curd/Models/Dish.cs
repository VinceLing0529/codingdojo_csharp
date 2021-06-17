using System;
using System.ComponentModel.DataAnnotations;

namespace Curd.Models
{
    public class Dish
    {
        [Key]
        public int DishId{get; set;}
        [Required(ErrorMessage = "is required")]
        public string Name{get; set;}
        [Required(ErrorMessage = "is required")]

        public string Chef{get; set;}
        [Required(ErrorMessage = "is required")]

        public int Tastiness {get; set;}
        [Required(ErrorMessage = "is required")]
        [Range(0,5000, ErrorMessage = "must be at least 2 characters")]
        public int Calories {get; set;}
        [Required(ErrorMessage = "is required")]

        public string Description{get; set;}
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }   
}