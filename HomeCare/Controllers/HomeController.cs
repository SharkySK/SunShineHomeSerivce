using HomeCare.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;


namespace HomeCare.Controllers
{
    public class HomeController : Controller
    {
      
        public ActionResult Login()
        {
            return View();
        }
       [HttpPost]
        public ActionResult Login(string Email, string Password)
        {
            Debug.WriteLine("Verify driggered");
            DBConnect dbConnect = new DBConnect();
            dbConnect.OpenConnection();
            return View("Admin");
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