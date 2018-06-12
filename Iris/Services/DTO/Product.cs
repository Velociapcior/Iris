using System;

namespace Iris.Services.DTO
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