namespace WebApplication6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using WebApplication6.Models;

    [Table("Order")]
    public partial class Order
    {
        public int Id { get; set; } //pk

        [Required]
        public DateTime OrderDt { get; set; }

        [Required]
        [StringLength(100)]
        public string OrderLoation { get; set; }

        public int productId { get; set; } //fk
        public Product Product { get; set; }

        public int? Quentity { get; set; }

        public int customerId { get; set; }  //fk
        public Customer Customer { get; set; }

    }
}
