using System;

namespace WebApplication.Models
{
    public class Product
    {
        public Product()
        {
            Id = new Random((int)DateTime.UtcNow.Ticks).Next(1000);
            Name = $"Product #{Id}";
            Price = Id*1.3333;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}