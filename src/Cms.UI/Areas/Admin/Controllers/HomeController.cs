﻿using Microsoft.AspNetCore.Mvc;

namespace Cms.UI.Areas.Admin.Controllers
{
  [Area("admin")]
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}
