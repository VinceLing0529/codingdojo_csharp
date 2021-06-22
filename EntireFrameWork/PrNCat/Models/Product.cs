using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PrNCat.Models
{
    public class Product
    {
        [Key]
        public int ProductId {get; set;}
        [Required]
        public string Name {get; set;}
         [Required]
        public string Descrtion {get; set;}
         [Required]
        public decimal price{get;set;}
        public List<Association> Cat {get; set;}
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}