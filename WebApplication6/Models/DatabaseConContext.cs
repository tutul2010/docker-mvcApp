namespace WebApplication6
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using WebApplication6.Models;

    public partial class DatabaseConContext : DbContext
    {
        public DatabaseConContext()
            : base("name=DatabaseConContext")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(e => e.Fname)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Lname)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.OrderLoation)
                .IsUnicode(false);
        }
    }
}
