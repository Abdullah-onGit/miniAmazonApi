using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace miniAmazonApi.Models
{
    public partial class miniAmazonDBContext : DbContext
    {
        public miniAmazonDBContext(DbContextOptions<miniAmazonDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<UserMaster> UserMaster { get; set; }
        public virtual DbSet<CustomerMaster> CustomerMaster { get; set; }
        public virtual DbSet<AddressMaster> AddressMaster { get; set; }
        public virtual DbSet<ProductMaster> ProductMaster { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
    }

}
