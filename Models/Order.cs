using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EFCore_Cascading_Dropdown.Models
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        [Display(Name = "Category")]
        [ForeignKey("CategoryId")]
        public virtual long CategoryId { get; set; }

        [Display(Name = "Product")]
        [ForeignKey("ProductId")]
        public virtual long ProductId { get; set; }

        [Display(Name = "Category")]
        public virtual Category? CategoryInfo { get; set; }

        [Display(Name = "Product")]
        public virtual Product? Product { get; set; }
    }
}
