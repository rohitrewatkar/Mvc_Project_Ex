using Mvc_Project_Ex.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Project_Ex.Controllers
{
    public class AddToCartController : Controller
    {
        // GET: AddToCart

        DataTable dt;
        Mobilesdetails mdal = new Mobilesdetails();

        public ActionResult Addloptop(Loptops lop)
        {
            if (Session["cart"] == null)
            {
                List<Loptops> li = new List<Loptops>();
                li.Add(lop);
                Session["cart"] = li;
                ViewBag.cart = li.Count();

                Session["count"] = 1;
            }
            else
            {
                List<Loptops> li = (List<Loptops>)Session["cart"];
                li.Add(lop);
                Session["cart"] = li;
                ViewBag.cart = li.Count();
                Session["count"] = Convert.ToInt32(Session["count"]) + 1;
            }
            return RedirectToAction("Loptop", "Home");

        }
        public ActionResult loptoporder()
        {
            return View((List<Loptops>)Session["cart"]);

        }



        public ActionResult Add(Mobiles mo)
        {
            if (Session["cart"]==null)
            {
                List<Mobiles> li = new List<Mobiles>();
                li.Add(mo);
                Session["cart"] = li;
                ViewBag.cart = li.Count();

                Session["count"] = 1;
            }
            else
            {
                List<Mobiles> li = (List < Mobiles >) Session["cart"];
                li.Add(mo);
                Session["cart"] = li;
                ViewBag.cart = li.Count();
                Session["count"] = Convert.ToInt32(Session["count"]) + 1;
            }
            return RedirectToAction("Index", "Home");

        }
        public ActionResult Myorder()
        {
           return View((List<Mobiles>)Session["cart"]);
        }
        public ActionResult Remove(Mobiles mob)
        {
            List<Mobiles> li = (List<Mobiles>)Session["cart"];
            li.RemoveAll(x => x.MobId == mob.MobId);
            Session["cart"] = li;
            Session["count"] = Convert.ToInt32(Session["count"]) - 1;
            return RedirectToAction("Myorder", "AddToCart");
        }
    }
}