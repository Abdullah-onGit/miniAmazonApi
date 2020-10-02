using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace miniAmazonApi.Models
{
    public partial class UserMaster : CommonModel
    {
        [Key]
        public int UserMasterAutoId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        
    }
}
