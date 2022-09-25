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
    public class BeslenmeController : Controller
    {
        // GET: Beslenme

        TEZEntities db = new TEZEntities();
        BeslenmeYorum by = new BeslenmeYorum();
        public ActionResult Index(int sayfa=1)
        {
            var bs = db.TBL_Beslenme.OrderByDescending(x => x.BeslenmeID).Where(x => x.Durum == true).ToPagedList(sayfa, 6);

            return View(bs);
        }
        public ActionResult BeslenmeDetay(int id)
        {
            by.Deger1 = db.TBL_Beslenme.Where(x => x.BeslenmeID == id).ToList();
            by.Deger2 = db.TBL_Yorumlar.Where(x => x.Beslenme == id).ToList();
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