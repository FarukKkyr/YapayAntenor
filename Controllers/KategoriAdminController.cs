using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YapayAntenor.Models.EntityFramework;

namespace YapayAntenor.Controllers
{
    public class KategoriAdminController : Controller
    {
        // GET: KategoriAdmin
        TEZEntities db = new TEZEntities();        
        public ActionResult Kategori()
        {
            var ktgr = db.TBL_Kategori.Where(x => x.Durum == true).ToList();
            return View(ktgr);
        }
        public ActionResult KategoriSil(int id)
        {
            var ktg = db.TBL_Kategori.Find(id);
            ktg.Durum = false;
            db.SaveChanges();
            return RedirectToAction("Kategori");
        }
        public ActionResult KategoriGetir(int id)
        {
            var ktg = db.TBL_Kategori.Find(id);
            return View("KategoriGetir", ktg);
        }
        public ActionResult KategoriGuncelle(TBL_Kategori k)
        {
            var ktg = db.TBL_Kategori.Find(k.KategoriID);
            ktg.KategoriAd = k.KategoriAd;
            db.SaveChanges();
            return RedirectToAction("Kategori");
        }
        [HttpGet]
        public ActionResult KategoriEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult KategoriEkle(TBL_Kategori k)
        {
            db.TBL_Kategori.Add(k);
            db.SaveChanges();
            return RedirectToAction("Kategori");
        }
    }
}