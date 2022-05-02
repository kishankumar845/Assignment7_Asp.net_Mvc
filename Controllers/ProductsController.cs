using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment4_ASP.NET_MVC.Models;

namespace Assignment4_ASP.NET_MVC.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            Products p = new Products();
            return View(p.GetProducts());
        }
    }
}