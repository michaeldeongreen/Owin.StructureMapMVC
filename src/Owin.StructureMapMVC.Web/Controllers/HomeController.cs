using Owin.StructureMapMVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Owin.StructureMapMVC.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISomeService _someService;

        public HomeController(ISomeService someService)
        {
            _someService = someService;
        }

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
