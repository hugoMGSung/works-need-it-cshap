using DiTestApp.Models;
using System.Collections.Generic;

namespace DiTestApp.Services
{
    public class EbayProductService : IProductService
    {
        public List<Product> GetProducts()
        {
            return new List<Product>()
        {
            new Product() { Id = 2001, Name = "Apple iPhone XS Max", Price = 660.00m },
            new Product() { Id = 2002, Name = "Apple iPhone 7", Price = 134.00m },
            new Product() { Id = 2003, Name = "Sony Cyber Shot Camera", Price = 109.00m }
        };
        }
    }
}
