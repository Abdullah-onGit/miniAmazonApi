using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace miniAmazonApi.Models
{
    [Table("CustomerMaster")]
    public class CustomerMaster : CommonModel
    {
        [Key]
        public int CustomerMasterAutoId { get; set; }
        public int UserMasterAutoId { get; set; }
        public string CustomerName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
    }

}