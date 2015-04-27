using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PlanetDatabase.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //Needed for AzureWebSite - for MVC azure ignores index.html
            return Redirect("/index.html");
        }
    }
}