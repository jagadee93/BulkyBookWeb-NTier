
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace BulkyBook.Models.ViewModels
{   
    public class ProductVM
    {
        public  Product Product { get; set; }
        [ValidateNever]
        public  IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> CategoryList { get; set; }
    }
}
