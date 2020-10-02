using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace miniAmazonApi.Models
{
    [Table("ProductMaster")]
    public class ProductMaster : CommonModel
    {
        [Key]
        public int ProductMasterAutoId { get; set; }
        public string ProductName { get; set; }
        public int BrandMasterAutoId { get; set; }
        public int CategoryMasterAutoId { get; set; }
        public decimal Price { get; set; }
        public decimal? Discount { get; set; }
        public int StocksAvailable { get; set; }
    }
}