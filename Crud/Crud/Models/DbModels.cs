using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Crud.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required, StringLength(40), Display(Name = "Product Name")]
        public string ProductName { get; set; }
        [Required, StringLength(40), Display(Name = "Product Price")]
        public string ProductPrice { get; set; }
        [Required, StringLength(40), Display(Name = "Product Quantity")]
        public string ProductQuantity { get; set; }
        [Required, StringLength(40), Display(Name = "Product Brand")]
        public string ProductBrand { get; set; }
    }
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {

        }
        public DbSet<Product> products { get; set; }
    }
}
