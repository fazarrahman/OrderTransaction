using OrderTransaction.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTransaction.Repository.Abstract
{
    public interface IProductRepository
    {
        Collection<Product> GetAllProducts();

        Product GetProductById(int id);
    }
}
