using System.Collections.Generic;
using Iris.Models;
using Iris.Services.Interfaces;
using static System.Web.HttpContext;

namespace Iris.Services
{
  public class SessionStateService : ISessionStateServie
  {
    public List<Product> ProductsList
    {
      get
      {
        if (Current.Session["products"] == null)
        {
          Current.Session["products"] = new List<Product>();
        }

        return (List<Product>) Current.Session["products"];
      }
      set
      {
        Current.Session["products"] = value;
      }
    }
  }
}