using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace miniAmazonApi.Models
{
    [Table("ProductCategory")]
    public class ProductCategory : CommonModel
    {
        [Key]
        public int ProductCategoryAutoId { get; set; }
        public string Category { get; set; }
    }
}