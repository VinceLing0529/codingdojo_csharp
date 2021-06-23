using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WeddingPlanner.Models
{
    public class Wedding
    {
        [Key]
        public int WeddingId {get; set;}
        [Required(ErrorMessage ="Must be present")]
        public string WedderOne{get; set;}
        [Required (ErrorMessage ="Must be present")]
        public string WedderTwo{get;set;}
        [Required (ErrorMessage ="Must be present")]
        [FutureDateAttribute (ErrorMessage ="Must be a future date")]
        public DateTime Date{get;set;}
        [Required (ErrorMessage ="Must be present")]
        public string Address{get;set;}
        
        public int UserId {get;set;}

        public List<Guest> Guest{get;set;}
        public User Creator{get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}


public class FutureDateAttribute : ValidationAttribute
{
    public override bool IsValid(object value)
    {
        return value != null && (DateTime)value > DateTime.Now;
    }
}
