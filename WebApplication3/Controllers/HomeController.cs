using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models.DataContext;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        private TMKmuhContext db = new TMKmuhContext();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SliderPartial()
        {
            return View(db.Slider.ToList().OrderByDescending(x=>x.SliderId));
        }
        public ActionResult Hakkimizda()
        {
            ViewBag.Blog = db.Blog.ToList().OrderByDescending(x => x.BlogId);

            return View(db.Hakkimizda.SingleOrDefault());
        }
        public ActionResult Blog()
        {
           
         
            return View(db.Blog.Include("Kategori").OrderByDescending(x => x.BlogId));
        }
        public ActionResult BlogDetay(int id)
        {
            var b = db.Blog.Include("Kategori").Where(x => x.BlogId == id).SingleOrDefault();

            return View(b);
        }
        public ActionResult Iletisim()
        {
            return View(db.Iletisim.SingleOrDefault());
        }
        public ActionResult FooterPartial()
        {
            ViewBag.Blog = db.Blog.ToList().OrderByDescending(x => x.BlogId);

            return PartialView();
        }
    }
}