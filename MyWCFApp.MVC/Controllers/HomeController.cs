using MyWCFApp.MVC.FirstWebServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWCFApp.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            FirstWebServiceClient client = new FirstWebServiceClient();
            ViewBag.Message = client.Message();
            ViewBag.Addition = client.add(34, 45);

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}