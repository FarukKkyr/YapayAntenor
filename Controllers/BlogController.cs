using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YapayAntenor.Models.EntityFramework;
using PagedList;
using PagedList.Mvc;

namespace YapayAntenor.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog

        TEZEntities db = new TEZEntities();
        BlogYorum by = new BlogYorum();
        public ActionResult Index(int sayfa=1)
        {
            var blog = db.TBL_Blog.OrderByDescending(x => x.BlogID).Where(x=>x.Durum==true).ToPagedList(sayfa, 6);
            return View(blog);
        }
       
        public ActionResult BlogDetay(int id)
        {
            // var blog = db.TBL_Blog.Where(x => x.BlogID == id).ToList();
            by.Deger1 = db.TBL_Blog.Where(x => x.BlogID == id).ToList();
            by.Deger2 = db.TBL_Yorumlar.Where(x => x.Blog == id).ToList();
            return View(by);
        }
        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }

        [HttpPost]
      public PartialViewResult YorumYap(TBL_Yorumlar y)
        {
            db.TBL_Yorumlar.Add(y);
            db.SaveChanges();
            return PartialView();
        }
    }
}