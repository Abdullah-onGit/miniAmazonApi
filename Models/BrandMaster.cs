using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace miniAmazonApi.Models
{
    [Table("BrandMaster")]
    public class BrandMaster : CommonModel
    {
        [Key]
        public int BrandMasterAutoId { get; set; }
        public string BrandName { get; set; }
    }
}