using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication6.Models
{
    [Table("Product")]
    public partial class Product
    {
        public Product()
        {
            this.Order = new List<Order>();
        }
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string productName { get; set; }

        public string productType { get; set; }
        public ICollection<Order> Order { get; set; }
    }
}