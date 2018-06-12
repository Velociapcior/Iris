using System;
using Bogus;
using Iris.Services.DTO;

namespace Iris.Services.Interfaces
{
  public static class RandomDataGenerator
  {
    public static Product GetNewProduct()
    {
      var fakerProduct = new Faker<Product>()
        .RuleFor(p => p.Description, f => f.Lorem.Text())
        .RuleFor(p => p.Name, f => f.Commerce.Product())
        .RuleFor(p => p.PictureUrl, f => f.Internet.Url())
        .RuleFor(p => p.Price, f => decimal.Round(f.Random.Decimal(0, 2000), 2))
        .RuleFor(p => p.ProductId, f => Guid.NewGuid());

      return fakerProduct.Generate();
    }
  }
}
