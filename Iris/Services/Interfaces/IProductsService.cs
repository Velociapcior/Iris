using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iris.Services.DTO;

namespace Iris.Services.Interfaces
{
  public interface IProductsService
  {
    List<Product> GetAllProducts();
  }
}
