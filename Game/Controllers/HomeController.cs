using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Game.Models;

namespace Game.Controllers
{
    [Authorize] 
    public class HomeController : Controller
    {
        dbContext _db = new dbContext();
        public ActionResult Index()
        {
            var mapa = _db.Mapy.Where(r => r.Username == User.Identity.Name).First();
            var budynki = _db.Budynki.ToList();
            var produktyUzytkownika = _db.ProduktyUzytkownika.Where(r => r.Username == User.Identity.Name).ToList();
            ViewBag.Mapa = mapa;
            ViewBag.Budynki = budynki;
            ViewBag.ProduktyUzytkownika = produktyUzytkownika;
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