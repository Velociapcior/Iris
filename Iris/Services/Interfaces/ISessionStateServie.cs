

using System.Collections.Generic;
using Iris.Models;

namespace Iris.Services.Interfaces
{
  public interface ISessionStateServie
  {
    List<Product> ProductsList { get; set; }
  }
}
