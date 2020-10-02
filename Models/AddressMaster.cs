using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace miniAmazonApi.Models
{
    [Table("AddressMaster")]
    public class AddressMaster : CommonModel
    {
        [Key]
        public int AddressMasterAutoId { get; set; }
        public int CustomerMasterAutoId { get; set;}
        public string Address { get; set; }
        public int? CityMasterAutoId { get; set; }
        public int? StateMasterAuotId { get; set; }
        public string PinCode { get; set; }
        public bool IsPrimaryAddress { get; set; }
    }
}