using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace miniAmazonApi.Models
{
    [Table("Orders")]
    public class Orders : CommonModel
    {
        [Key]
        public int OrdersAutoId { get; set; }
        public int AddressMasterAutoId { get; set; }
        public int CusmoterMasterAutoId { get; set; }
        public int ProductMasterAutoId { get; set; }
        public DateTime ETA { get; set; }
        public DateTime? ATA { get; set; }
        public decimal ProductPriceOnOrder { get; set; }
        public decimal? Discount { get; set; }
        public decimal ActualAmount { get; set; }
        public string CurrentStatus { get; set; }
    }
}