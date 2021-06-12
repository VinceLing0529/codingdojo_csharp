using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
namespace Form_Sub.Models
{
    public class User
    {
        [Required]
        [MinLength(4)]
        public string Firstname { get; set; }
 
         [Required]
        [MinLength(4)]
        public string Lastname { get; set; }
 
  
         [Required]
        [Range(0,120)]
        public int Age { get; set; }
 
        [Required]
        [EmailAddress]
        public string Email { get; set; }
 
        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}