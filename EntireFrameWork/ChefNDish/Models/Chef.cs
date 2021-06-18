using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ChefNDish.Models
{
    public class Chef
    {
        [Key]
        public int ChefId{get; set;}

        [Required(ErrorMessage ="is required")]
        public string FirstName{get;set;}
        [Required (ErrorMessage ="is required")]
        public string LastName{get; set;}
        [Required (ErrorMessage ="is required")]
        [Range(0,100,ErrorMessage ="must between 0 to 100 ")]
        public int Age{get;set;}

        public List<Dish> AllDishes{get; set;}

    
    }
}