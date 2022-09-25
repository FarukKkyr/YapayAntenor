using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using PagedList;
using PagedList.Mvc;
using System.Web.Mvc;
using YapayAntenor.Models.EntityFramework;

namespace YapayAntenor.Controllers
{
    public class BeslenmeAdminController : Controller
    {
        // GET: BeslenmeAdmin
        TEZEntities db = new TEZEntities();        
        public ActionResult Beslenme(int sayfa=1)
        {
            var bs = db.TBL_Beslenme.OrderByDescending(x => x.BeslenmeID).Where(x => x.Durum == true).ToPagedList(sayfa,6);
            return View(bs);
        }
        public ActionResult BeslenmeSil(int id)
        {
            var beslenme = db.TBL_Beslenme.Find(id);
            beslenme.Durum = false;
            db.SaveChanges();
            return RedirectToAction("Beslenme");

        }
        [HttpGet]
        public ActionResult BeslenmeEkle()
        {
           
            List<SelectListItem> deger1 = (from x in db.TBL_Admin.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.Nickname,
                                               Value = x.AdminID.ToString()
                                           }).ToList();
            ViewBag.dgr1 = deger1;
            return View();
        }
        [HttpPost]
        public ActionResult BeslenmeEkle(TBL_Beslenme b)
        {
            //if (Request.Files.Count > 0)
            //{
            //    string dosyaadi = Path.GetFileName(Request.Files[0].FileName);
            //    string uzanti = Path.GetExtension(Request.Files[0].FileName);
            //    string yol = "~/Resimler/" + dosyaadi + uzanti;
            //    Request.Files[0].SaveAs(Server.MapPath(yol));
            //    b.BeslenmeResim = "/Resimler/" + dosyaadi + uzanti;
            //}
            db.TBL_Beslenme.Add(b);
            db.SaveChanges();
            return RedirectToAction("Beslenme");

        }
        public ActionResult BeslenmeGetir(int id)
        {
            List<SelectListItem> deger1 = (from x in db.TBL_Admin.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.Nickname,
                                               Value = x.AdminID.ToString()
                                           }).ToList();
            ViewBag.dgr1 = deger1;
            var beslenme = db.TBL_Beslenme.Find(id);
            return View("BeslenmeGetir", beslenme);
        }
        public ActionResult BeslenmeGuncelle(TBL_Beslenme b)
        {
            var bslnm = db.TBL_Beslenme.Find(b.BeslenmeID);
            bslnm.BeslenmeBaslik = b.BeslenmeBaslik;
            bslnm.BeslenmeResim = b.BeslenmeResim;
            bslnm.BeslenmeTarih = b.BeslenmeTarih;
            bslnm.BeslenmeYazar = b.BeslenmeYazar;
            bslnm.BeslenmeAciklama = b.BeslenmeAciklama;
            bslnm.Durum = b.Durum;
            db.SaveChanges();
            return RedirectToAction("Beslenme");
        }
    }
}