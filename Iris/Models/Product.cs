using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Iris.Models
{
  public class Product
  {
    public string Name { get; set; }

    public string Description { get; set; }

    public decimal Price { get; set; }

    public string PictureUrl { get; set; }

    public Guid ProductId { get; set; }
  }
}