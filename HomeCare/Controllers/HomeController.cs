using HomeCare.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeCare.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Login()
        {
            DBConnect dbConnect = new DBConnect();
            dbConnect.OpenConnection();
            return View();
        }
        //[HttpGet]
        //public JsonResult Test()
        //{  
            //DataClasses1DataContext dataContext = new DataClasses1DataContext();
            //List<User> data = (from p in dataContext.Users select p).ToList();
            //return Json(data, JsonRequestBehavior.AllowGet);
        //}

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