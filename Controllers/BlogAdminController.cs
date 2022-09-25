using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
using YapayAntenor.Models.EntityFramework;

namespace YapayAntenor.Controllers
{
    public class BlogAdminController : Controller
    {
        // GET: BlogAdmin

        TEZEntities db = new TEZEntities();       
        public ActionResult Blog(int sayfa=1)
        {
            var blg = db.TBL_Blog.OrderByDescending(x => x.BlogID).Where(x => x.Durum == true).ToPagedList(sayfa, 6);
            return View(blg);
        }
        [HttpGet]
        public ActionResult BlogEkle()
        {
            List<SelectListItem> deger1 = (from x in db.TBL_Kategori.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.KategoriAd,
                                               Value = x.KategoriID.ToString()
                                           }).ToList();
            ViewBag.dgr1 = deger1;

            List<SelectListItem> deger2 = (from x in db.TBL_Admin.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.KullaniciAdi,
                                               Value = x.AdminID.ToString()
                                           }).ToList();
            ViewBag.dgr2 = deger2;
            return View();
        }

        [HttpPost]
        public ActionResult BlogEkle(TBL_Blog b)
        {
            db.TBL_Blog.Add(b);
            db.SaveChanges();
            return RedirectToAction("Blog");
        }
        public ActionResult BlogSil(int id)
        {
            var blg = db.TBL_Blog.Find(id);
            blg.Durum = false;
            db.SaveChanges();
            return RedirectToAction("Blog");
        }

        public ActionResult BlogGetir(int id)
        {
            List<SelectListItem> deger1 = (from x in db.TBL_Kategori.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.KategoriAd,
                                               Value = x.KategoriID.ToString()
                                           }).ToList();
            ViewBag.dgr1 = deger1;

            List<SelectListItem> deger2 = (from x in db.TBL_Admin.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.KullaniciAdi,
                                               Value = x.AdminID.ToString()
                                           }).ToList();
            ViewBag.dgr2 = deger2;
            var blg = db.TBL_Blog.Find(id);
            return View("BlogGetir", blg);
        }
        public ActionResult BlogGuncelle(TBL_Blog b)
        {
            var blg = db.TBL_Blog.Find(b.BlogID);
            blg.BlogBaslik = b.BlogBaslik;
            blg.BlogTarih = b.BlogTarih;
            blg.BlogAciklama = b.BlogAciklama;
            blg.BlogYazar = b.BlogYazar;
            blg.BlogImage = b.BlogImage;
            blg.BlogKategori = b.BlogKategori;
            blg.Durum = b.Durum;
            db.SaveChanges();
            return RedirectToAction("Blog");

        }
    }
}