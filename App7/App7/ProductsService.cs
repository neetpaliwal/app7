    using System;
using System.Collections.Generic;
using System.Text;

namespace App7
{
    public interface IProductsService
    {
        IEnumerable<Product> Getproducts();
    }

    public class ProductsService : IProductsService
    {
        public IEnumerable<Product> Getproducts()
        {
            return new List<Product>
        {
            new Product { Name = "Surface Laptop", Price = 1500 },
            new Product { Name = "XBox One", Price = 400 },
        };
        }
    }
}
