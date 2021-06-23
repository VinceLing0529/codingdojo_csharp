using System.ComponentModel.DataAnnotations;

namespace WeddingPlanner.Models
{
    public class Guest
    {
        [Key]
        public int GuestId{get;set;}
        [Required]
        public int WeddingId{get;set;}
        [Required]
        public int UserId{get;set;}
        
        public Wedding Wedding{get;set;}
        public User User{get;set;}
        
    }
}