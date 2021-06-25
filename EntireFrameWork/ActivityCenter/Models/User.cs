using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ActivityCenter.Models
{
    public class User
{
    [Key]
    public int UserId {get;set;}
    [Required (ErrorMessage="is required")]
    [MinLength(2, ErrorMessage="Name must be 2 characters or longer!")]
    public string Name {get;set;}
    [EmailAddress (ErrorMessage="is not a email")]
    [Required (ErrorMessage="is required")]
    public string Email {get;set;}
    [DataType(DataType.Password)]
    [Required (ErrorMessage="is required")]
    [MinLength(8, ErrorMessage="Password must be 8 chracters or longer!")]
    [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[$@$!%*#?&])[A-Za-z\d$@$!%*#?&]{1,}$", ErrorMessage = "Must be at least 1 number, 1 letter, and a special character")]

    public string Password {get;set;}
    public DateTime CreatedAt {get;set;} = DateTime.Now;
    public DateTime UpdatedAt {get;set;} = DateTime.Now;
    [NotMapped]
    [Compare("Password")]
    [DataType(DataType.Password)]
    public string Confirm {get;set;}

    public List<Join> Attend{get;set;}
    public List<Activit> CreatedActivities {get;set;}

}    

}