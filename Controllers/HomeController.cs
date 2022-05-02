using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace Assignment4_ASP.NET_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string id)
        {
            if (id == null) 
            { 
                return Content("<h1>This is a demo of ContentResult</h1>"); 
            }
            else if(id.ToLower()=="plain")
            {
                return Content("<h1>This is a demo of ContentResult</h1>", "text/plain");
            }
            else if (id.ToLower() == "html") 
            { 
                return Content("<h1>This is a demo of ContentResult</h1>", "text/html"); 
            }
            else if (id.ToLower() == "xml") 
            {
                return Content("<h1>This is a demo of ContentResult</h1>", "text/xml");
            }
            return Content("Invalid content type");
        }

        public FileResult DownloadFile()
        {
            if (!System.IO.File.Exists(@"c:\lighthouse.jpg"))
            {
                Console.WriteLine("<h3>File to be Downloaded not found</h3>");
            }
            return File(@"c:\lighthouse.jpg", "image/jpg", "default.jpg");
        }
        public ActionResult Google()
        { 
            return Redirect("http://www.google.com");  //opening google web page
        }

        public ActionResult StartPage()  //redirecting to the Index with xml page
        { 
            return RedirectToAction("Index", new { id = "xml" });  
        }

        public ActionResult Login()
        {
            return View();  
        }
        public ActionResult AboutUs()
        {
            return View();
        }
    }
}