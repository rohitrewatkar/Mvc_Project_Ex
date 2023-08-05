using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Project_Ex.Controllers
{
    public class productController : Controller
    {
        // GET: product
        public ActionResult Index()
        {
            return View();
        }
    }
}