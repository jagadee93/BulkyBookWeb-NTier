using System.ComponentModel.DataAnnotations;

namespace BulkyBook.Models  
{
    public class Category
    {

       [Key]
       public required int CategoryId { get; set; }
       public required string Name { get; set; }
       public int DisplayOrder { get; set; }
    }
}
