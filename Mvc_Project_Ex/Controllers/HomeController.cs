using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mob_dal;
using System.Data;
using Mvc_Project_Ex.Models;


namespace Mvc_Project_Ex.Controllers
{
    public class HomeController : Controller
    {
        MobdetailsDAL mdal = new MobdetailsDAL();
        DataTable dt;

        // GET: Home
        public ActionResult Index()
        {

            string mycmd = "select * from MobData";
            dt = new DataTable();
            dt = mdal.SalectAll(mycmd);

            List<Mobiles> list = new List<Mobiles>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Mobiles mob = new Mobiles();
                mob.MobId = Convert.ToInt32(dt.Rows[i]["mobId"]);
                mob.Mobname = dt.Rows[i]["Mobname"].ToString();
                mob.price = Convert.ToInt32(dt.Rows[i]["price"]);
                mob.Description = dt.Rows[i]["Desription"].ToString();
                mob.ZoomUrl = dt.Rows[i]["ZoomUrl"].ToString();
                mob.url = dt.Rows[i]["url"].ToString();
                list.Add(mob);

            }

            return View(list);
        }


        public ActionResult EachproductDetails(Mobiles m)
        {
            string mycmd = "select m.MobId,m.MobName,m.price,M.Desription,m.Url,md.Features,md.Models,md.Colors,md.Sim_type from Mobdata m inner join MobDetails md  on m.MobId=md.MobId where m.MobId=" + m.MobId+ "";

            dt = new DataTable();
            dt = mdal.SalectAll(mycmd);
            List<ProductDetails> list = new List<ProductDetails>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ProductDetails mob = new ProductDetails();
                mob.MobId = Convert.ToInt32(dt.Rows[i]["Mobid"].ToString());
                mob.Mobname = dt.Rows[i]["MobName"].ToString();
                mob.price = Convert.ToInt32( dt.Rows[i]["Price"].ToString());
                mob.Description =( dt.Rows[i]["Desription"].ToString());
                mob.Url = dt.Rows[i]["Url"].ToString();
                mob.Features = dt.Rows[i]["Features"].ToString();
                mob.Models = dt.Rows[i]["Models"].ToString();
                mob.Colors = dt.Rows[i]["Colors"].ToString();
                mob.Sim_type = dt.Rows[i]["Sim_type"].ToString();

                list.Add(mob);

            }
            return View(list);
        }

        public ActionResult Loptop(Loptops L)
        {
            string mycmd = "Select * from LoptopData";
            dt = new DataTable();

            dt = mdal.SalectAll(mycmd);
            List<Loptops> list = new List<Loptops>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Loptops lop = new Loptops();
                lop.LopId = Convert.ToInt32(dt.Rows[i]["LopId"].ToString());
                lop.lopname = dt.Rows[i]["Lopname"].ToString();
                lop.LopModel = dt.Rows[i]["LopModel"].ToString();
                lop.Lopprice = Convert.ToInt32(dt.Rows[i]["Lopprice"].ToString());
                lop.LopDetails = dt.Rows[i]["LopDetails"].ToString();
                lop.LopUrl = dt.Rows[i]["LopUrl"].ToString();

                list.Add(lop);
            }


            return View(list);
        }
        public ActionResult LoptopProduct(Loptops Lp)
        {
           
            string mycmd = "select * from LoptopData where LopId=" + Lp.LopId;

            dt = new DataTable();


            dt = mdal.SalectAll(mycmd);
            List<Loptops> list = new List<Loptops>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Loptops lop = new Loptops();
                lop.LopId = Convert.ToInt32(dt.Rows[i]["LopId"].ToString());
                lop.lopname = dt.Rows[i]["Lopname"].ToString();
                lop.LopModel = dt.Rows[i]["LopModel"].ToString();
                lop.Lopprice = Convert.ToInt32(dt.Rows[i]["Lopprice"].ToString());
                lop.LopDetails = dt.Rows[i]["LopDetails"].ToString();
                lop.LopUrl = dt.Rows[i]["LopUrl"].ToString();

                list.Add(lop);
            }
            return View(list);
        }
    }
}