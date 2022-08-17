using DiTestApp.Models;
using System.Collections.Generic;

namespace DiTestApp.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}
