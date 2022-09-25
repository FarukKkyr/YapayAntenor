using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YapayAntenor.Models.EntityFramework;

namespace YapayAntenor.Controllers
{
    public class HareketAdminController : Controller
    {
        // GET: HareketAdmin
        TEZEntities db = new TEZEntities();      
        public ActionResult Hareket()
        {
            return View();
        }

        //BACAK KODLARI BAŞLANGIÇ
        public ActionResult Bacak()
        {
            var bck = db.TBL_Bacak.ToList();
            return View(bck);
        }
        public ActionResult BacakSil(int id)
        {
            var bck = db.TBL_Bacak.Find(id);
            db.TBL_Bacak.Remove(bck);
            db.SaveChanges();
            return RedirectToAction("Bacak");
        }
        [HttpGet]
        public ActionResult BacakEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult BacakEkle(TBL_Bacak b)
        {
            //if(Request.Files.Count>0)
            //{
            //    string dosyaadi = Path.GetFileName(Request.Files[0].FileName);
            //    string uzanti = Path.GetExtension(Request.Files[0].FileName);
            //    string yol = "~/Resimler/" + dosyaadi + uzanti;
            //    Request.Files[0].SaveAs(Server.MapPath(yol));
            //    b.BacakResim = "/Resimler/" + dosyaadi + uzanti;
            //}
            db.TBL_Bacak.Add(b);
            db.SaveChanges();
            return RedirectToAction("Bacak");
        }
        public ActionResult BacakGetir(int id)
        {
            var bck = db.TBL_Bacak.Find(id);
            return View("BacakGetir", bck);
        }
        public ActionResult BacakGuncelle(TBL_Bacak b)
        {
            var bck = db.TBL_Bacak.Find(b.BacakID);
            bck.BacakAciklama = b.BacakAciklama;
            bck.BacakHareket = b.BacakHareket;
            bck.BacakResim = b.BacakResim;
            
            db.SaveChanges();
            return RedirectToAction("Bacak");
        }

        //BACAK KODLARI BİTİŞ
        // GÖĞÜS KODLARI BAŞLANIÇ

        public ActionResult Gogus()
        {
            var ggs = db.TBL_Gogus.ToList();
            return View(ggs);
        }
        public ActionResult GogusSil(int id)
        {
            var ggs = db.TBL_Gogus.Find(id);
            db.TBL_Gogus.Remove(ggs);
            db.SaveChanges();
            return RedirectToAction("Gogus");
        }
        [HttpGet]
        public ActionResult GogusEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GogusEkle(TBL_Gogus g)
        {
            //if (Request.Files.Count > 0)
            //{
            //    string dosyaadi = Path.GetFileName(Request.Files[0].FileName);
            //    string uzanti = Path.GetExtension(Request.Files[0].FileName);
            //    string yol = "~/Resimler/" + dosyaadi + uzanti;
            //    Request.Files[0].SaveAs(Server.MapPath(yol));
            //    g.GogusResim = "/Resimler/" + dosyaadi + uzanti;
            //}
            db.TBL_Gogus.Add(g);
            db.SaveChanges();
            return RedirectToAction("Gogus");
        }
        public ActionResult GogusGetir(int id)
        {
            var ggs = db.TBL_Gogus.Find(id);
            return View("GogusGetir", ggs);
        }
        public ActionResult GogusGuncelle(TBL_Gogus g)
        {
            var ggs = db.TBL_Gogus.Find(g.GogusID);
            ggs.GogusAciklama = g.GogusAciklama;
            ggs.GogusHareket = g.GogusHareket;
            ggs.GogusResim = g.GogusResim;

            db.SaveChanges();
            return RedirectToAction("Gogus");
        }

        //GÖĞÜS KODLARI BİTİŞ
        //SIRT KODLARI BAŞLANIÇ
        public ActionResult Sırt()
        {
            var srt = db.TBL_Sirt.ToList();
            return View(srt);
        }
        public ActionResult SırtSil(int id)
        {
            var srt = db.TBL_Sirt.Find(id);
            db.TBL_Sirt.Remove(srt);
            db.SaveChanges();
            return RedirectToAction("Sırt");
        }
       
        [HttpGet]
        public ActionResult SırtEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SırtEkle(TBL_Sirt s)
        {
            //if (Request.Files.Count > 0)
            //{
            //    string dosyaadi = Path.GetFileName(Request.Files[0].FileName);
            //    string uzanti = Path.GetExtension(Request.Files[0].FileName);
            //    string yol = "~/Resimler/" + dosyaadi + uzanti;
            //    Request.Files[0].SaveAs(Server.MapPath(yol));
            //    s.SırtResim = "/Resimler/" + dosyaadi + uzanti;
            //}
            db.TBL_Sirt.Add(s);
            db.SaveChanges();
            return RedirectToAction("Sırt");
        }

        public ActionResult SırtGetir(int id)
        {
            var srt = db.TBL_Sirt.Find(id);
            return View("SırtGetir", srt);
        }
        public ActionResult SırtGuncelle(TBL_Sirt s)
        {
            var srt = db.TBL_Sirt.Find(s.SirtID);
            srt.SırtAciklama = s.SırtAciklama;
            srt.SırtHareket = s.SırtHareket;
            srt.SırtResim = s.SırtResim;
            db.SaveChanges();
            return RedirectToAction("Sırt");
        }

        //SIRT KODLARI BİTİŞ
        //KOL KODLARI BAŞLANIÇ
        public ActionResult Kol()
        {
            var kol = db.TBL_Kol.ToList();
            return View(kol);
        }
        public ActionResult KolSil(int id)
        {
            var kol = db.TBL_Kol.Find(id);
            db.TBL_Kol.Remove(kol);
            db.SaveChanges();
            return RedirectToAction("Kol");
        }
        [HttpGet]
        public ActionResult KolEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult KolEkle(TBL_Kol kl)
        {
            //if (Request.Files.Count > 0)
            //{
            //    string dosyaadi = Path.GetFileName(Request.Files[0].FileName);
            //    string uzanti = Path.GetExtension(Request.Files[0].FileName);
            //    string yol = "~/Resimler/" + dosyaadi + uzanti;
            //    Request.Files[0].SaveAs(Server.MapPath(yol));
            //    kl.Resim= "/Resimler/" + dosyaadi + uzanti;
            //}
            db.TBL_Kol.Add(kl);
            db.SaveChanges();
            return RedirectToAction("Kol");
        }
        public ActionResult KolGetir(int id)
        {
            var kl = db.TBL_Kol.Find(id);
            return View("KolGetir",kl);
        }

        public ActionResult KolGuncelle(TBL_Kol k)
        {
            var kl = db.TBL_Kol.Find(k.KolID);
            kl.Aciklama = k.Aciklama;
            kl.Hareket = k.Hareket;
            kl.Resim = k.Resim;
            db.SaveChanges();
            return RedirectToAction("Kol");

        }
        //KOL KODLARI BİTİŞ
        //OMUZ KODLARI BAŞLANIÇ
        public ActionResult Omuz()
        {
            var omuz = db.TBL_Omuz.ToList();
            return View(omuz);
        }
        public ActionResult OmuzSil(int id)
        {
            var omuz= db.TBL_Omuz.Find(id);
            db.TBL_Omuz.Remove(omuz);
            db.SaveChanges();
            return RedirectToAction("Omuz");
        }
        [HttpGet]
        public ActionResult OmuzEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult OmuzEkle(TBL_Omuz omz)
        {
            //if (Request.Files.Count > 0)
            //{
            //    string dosyaadi = Path.GetFileName(Request.Files[0].FileName);
            //    string uzanti = Path.GetExtension(Request.Files[0].FileName);
            //    string yol = "~/Resimler/" + dosyaadi + uzanti;
            //    Request.Files[0].SaveAs(Server.MapPath(yol));
            //    omz.OmuzReism = "/Resimler/" + dosyaadi + uzanti;
            //}
            db.TBL_Omuz.Add(omz);
            db.SaveChanges();
            return RedirectToAction("Omuz");
        }
        public ActionResult OmuzGetir(int id)
        {
            var omz = db.TBL_Omuz.Find(id);
            return View("OmuzGetir", omz);
        }
        
        public ActionResult OmuzGuncelle(TBL_Omuz o)
        {
            var omz = db.TBL_Omuz.Find(o.OmuzID);
            omz.OmuzAciklama = o.OmuzAciklama;
            omz.OmuzHareket = o.OmuzHareket;
            omz.OmuzReism = o.OmuzReism;
            db.SaveChanges();
            return RedirectToAction("Omuz");
        }

        
        //OMUZ KODLARI BİTİŞ
        //KARIN KODLARI BAŞLANIÇ
        public ActionResult Karın()
        {
            var krn = db.TBL_Karin.ToList();
            return View(krn);
        }
        public ActionResult KarınSil(int id)
        {
            var krn = db.TBL_Karin.Find(id);
            db.TBL_Karin.Remove(krn);
            db.SaveChanges();
            return RedirectToAction("Karın");
        }
        [HttpGet]
        public ActionResult KarınEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult KarınEkle(TBL_Karin krn)
        {
            //if (Request.Files.Count > 0)
            //{
            //    string dosyaadi = Path.GetFileName(Request.Files[0].FileName);
            //    string uzanti = Path.GetExtension(Request.Files[0].FileName);
            //    string yol = "~/Resimler/" + dosyaadi + uzanti;
            //    Request.Files[0].SaveAs(Server.MapPath(yol));
            //    krn.KarinResim = "/Resimler/" + dosyaadi + uzanti;
            //}
            db.TBL_Karin.Add(krn);
            db.SaveChanges();
            return RedirectToAction("Karın");
        }

        public ActionResult KarınGetir(int id)
        {
            var krn = db.TBL_Karin.Find(id);
            return View("KarınGetir", krn);
        }

        public ActionResult KarınGuncelle(TBL_Karin k)
        {
            var krn = db.TBL_Karin.Find(k.KarinID);
            krn.KarinAciklama = k.KarinAciklama;
            krn.KarinHareket = k.KarinHareket;
            krn.KarinResim = k.KarinResim;
            db.SaveChanges();
            return RedirectToAction("Karın");

        }
    }
}