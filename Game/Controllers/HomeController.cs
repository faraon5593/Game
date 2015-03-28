using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Game.Models;

namespace Game.Controllers
{
    public class HomeController : Controller
    {
        dbContext _db = new dbContext();
        public ActionResult Index()
        {
            _db.Budynki.Add(new Buildings { Destr_price = 10, Name = "Tartak", Height = 1, Percent_price_per_lvl = 110, Percent_product_per_lvl = 120, Price = 100, Product_per_h = 3, Width = 1 });
            _db.SaveChanges();
            return View();
        }

        public ActionResult About()
        {
            var model = _db.Budynki.ToList();

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if(_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}