using MVC_Test.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace MVC_Test.Controllers
{
    [MyLogActionFilter]
    public class HomeController : Controller
    {
        
         //GET: /Home/
        public ActionResult DefaultView()
        {
            return View();
        }

        [OutputCache(Duration = 10)]
        public string Index()
        {
            return "Hello world!! This is MVC dot net tutorial.";
        }

        public ActionResult Redirect() { return RedirectToAction("GetAllCustomers", "Customer"); }

        [OutputCache(Duration = 10)]
        [ActionName("CurrentTime")]
        //public string GetCurrentTime() { return DateTime.Now.ToString("T"); }
        public string GetCurrentTime() { return TimeString(); }

        [NonAction]
        public string TimeString() { return "Time is " + DateTime.Now.ToString("T"); }

        public ActionResult MyView() { return View(); }
    }
}