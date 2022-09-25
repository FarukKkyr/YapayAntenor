using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YapayAntenor.Models.EntityFramework;
using PagedList.Mvc;
using PagedList;

namespace YapayAntenor.Controllers
{
    public class AdminYorumController : Controller
    {
        // GET: AdminYorum
        TEZEntities db = new TEZEntities();
       
        public ActionResult Index(int sayfa=1)
        {
            var yrm = db.TBL_Yorumlar.OrderByDescending(x => x.YorumID).ToPagedList(sayfa, 10); 
            return View(yrm);
        }
        public ActionResult YorumSil(int id)
        {
            var yrm = db.TBL_Yorumlar.Find(id);
            db.TBL_Yorumlar.Remove(yrm);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult YorumGetir(int id)
        {
            var yrm = db.TBL_Yorumlar.Find(id);
            return View("YorumGetir", yrm);
        }
        public ActionResult YorumGuncelle(TBL_Yorumlar y)
        {
            var yrm = db.TBL_Yorumlar.Find(y.YorumID);
            yrm.KullaniciAdi = y.KullaniciAdi;
            yrm.Mail = y.Mail;
            yrm.Yorum = y.Yorum;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}