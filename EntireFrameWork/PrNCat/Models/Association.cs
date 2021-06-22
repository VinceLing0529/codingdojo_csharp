using System.ComponentModel.DataAnnotations;

namespace PrNCat.Models
{
    public class Association
    {
        [Key]
    public int AssociationId { get; set; }
    [Required]
    public int ProductId { get; set; }
     [Required]
    public int CategoryId { get; set; }
    public Product Product { get; set; }
    public Category Category { get; set; }

    }
}