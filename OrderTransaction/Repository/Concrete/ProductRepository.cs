using OrderTransaction.Models;
using OrderTransaction.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace OrderTransaction.Repository.Concrete
{
    public class ProductRepository : IProductRepository
    {
        private Collection<Product> products = new Collection<Product>()
        {
            new Product { ProductId = 1, Name = "Tomato Soup", Stock = 10, Price = 100000 },
            new Product { ProductId = 2, Name = "Yo-yo", Stock = 10, Price = 150000 },
            new Product { ProductId = 3, Name = "Hammer", Stock = 10, Price = 40000 }
        };

        public Collection<Product> GetAllProducts()
        {
            return products;
        }

        public Product GetProductById(int id)
        {
            Product product = products
                .Where(p => p.ProductId == id)
                .FirstOrDefault();

            return product;
        }
    }
}