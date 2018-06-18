using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Iris.Services.Interfaces;

namespace Iris.Controllers
{
  public class HomeController : Controller
  {
    private readonly ISessionStateServie _sessionStateServie;

    public HomeController(ISessionStateServie sessionStateServie)
    {
      _sessionStateServie = sessionStateServie;
    }

    // GET: Home
    public ActionResult Index()
    {

      return View();
    }
  }
}