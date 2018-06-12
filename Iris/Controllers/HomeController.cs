using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Iris.Models;
using Iris.Models.Converters;
using Iris.Services.Interfaces;

namespace Iris.Controllers
{
  public class HomeController : Controller
  {
    private readonly ISessionStateServie _sessionStateServie;
    private readonly IProductsService _productsService;

    public HomeController(ISessionStateServie sessionStateServie, IProductsService productsService)
    {
      _sessionStateServie = sessionStateServie;
      _productsService = productsService;
    }

    [HttpGet]
    public ActionResult GetNewListOfProducts()
    {
      try
      {
        List<Services.DTO.Product> productsDto = _productsService.GetAllProducts();

        List<Product> products = new List<Product>();

        foreach (Services.DTO.Product item in productsDto)
        {
          Product product = ProductConverter.ConvertToModelProduct(item);

          products.Add(product);
        }

        _sessionStateServie.ProductsList = products;

        return Json(products, JsonRequestBehavior.AllowGet);
      }
      catch
      {
        return View("Index");
      }
    }

    [HttpPost]
    public ActionResult DeleteProductFromList(string productId)
    {
      try
      {
        Guid productGuid = Guid.Parse(productId);

        List<Product> products = _sessionStateServie.ProductsList;

        products.RemoveAll(x => x.ProductId == productGuid);

        _sessionStateServie.ProductsList = products;

        return Json(new { success = true });
      }
      catch
      {
        return Json(new { success = false });
      }
    }

    // GET: Home
    public ActionResult Index()
    {

      return View();
    }
  }
}