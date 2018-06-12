namespace Iris.Models.Converters
{
  public static class ProductConverter
  {
    public static Product ConvertToModelProduct(Services.DTO.Product source)
    {
      return new Product
      {
        PictureUrl = source.PictureUrl,
        Price = source.Price,
        Description = source.Description,
        Name = source.Name,
        ProductId = source.ProductId
      };
    }

    public static Services.DTO.Product ConvertToDtoProduct(Product source)
    {
      return new Services.DTO.Product
      {
        PictureUrl = source.PictureUrl,
        Price = source.Price,
        Description = source.Description,
        Name = source.Name,
        ProductId = source.ProductId
      };
    }
  }
}