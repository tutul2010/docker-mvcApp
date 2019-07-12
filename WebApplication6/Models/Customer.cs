namespace WebApplication6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        public Customer()
        {
            this.Order = new List<Order>();
        }
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Fname { get; set; }

        [Required]
        [StringLength(100)]
        public string Lname { get; set; }

        public int? status { get; set; }
        public ICollection<Order> Order { get; set; }
    }
}
