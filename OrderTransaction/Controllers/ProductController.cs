using OrderTransaction.Models;
using OrderTransaction.Repository.Abstract;
using OrderTransaction.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OrderTransaction.Controllers
{
    public class ProductController : ApiController
    {
        IProductRepository _productRepository;

        public IEnumerable<Product> GetAllProducts()
        {
            _productRepository = new ProductRepository();
            Collection<Product> products = _productRepository.GetAllProducts();

            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            _productRepository = new ProductRepository();

            var product = _productRepository.GetProductById(id);
            if (product == null)
            {
                product.SetMessage("Product tidak ditemukan");
            }
            return Ok(product);
        }
    }
}
