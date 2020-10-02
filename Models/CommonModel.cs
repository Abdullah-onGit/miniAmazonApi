using System;

namespace miniAmazonApi.Models
{
    public class CommonModel
    {
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool DeleteFlag { get; set; } = false;

    }
}