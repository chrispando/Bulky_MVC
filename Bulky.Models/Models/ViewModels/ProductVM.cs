using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Bulky.Models.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Bulky.Models.Models.ViewModels
{
    public class ProductVM
    {
        public Product Product { get; set; } = new Product();
        [ValidateNever]
        public IEnumerable<SelectListItem> CategoryList { get; set; } = new List<SelectListItem>();

    }
}