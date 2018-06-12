using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Iris.Services.DTO;
using Iris.Services.Interfaces;

namespace Iris.Services
{
  public class ProductsService : IProductsService
  {
    public List<Product> GetAllProducts()
    {
      List<Product> products = new List<Product>();

      for (int i = 0; i < 20; i++)
      {
        Product product = RandomDataGenerator.GetNewProduct();
        
        products.Add(product);
      }

      return products;
    }
  }
}