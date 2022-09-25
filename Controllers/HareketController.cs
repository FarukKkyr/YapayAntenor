using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YapayAntenor.Models.EntityFramework;

namespace YapayAntenor.Controllers
{
    public class HareketController : Controller
    {
        // GET: Hareket

        TEZEntities db = new TEZEntities();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Bacak()
        {
            var bck = db.TBL_Bacak.ToList();
            return View(bck);
        }
        public ActionResult Gogus()
        {
            var gs = db.TBL_Gogus.ToList();
            return View(gs);
        }
        public ActionResult Sırt()
        {
            var srt = db.TBL_Sirt.ToList();
            return View(srt);
        }
        public ActionResult Kol()
        {
            var kol = db.TBL_Kol.ToList();
            return View(kol);
        }
        public ActionResult Omuz()
        {
            var omz = db.TBL_Omuz.ToList();
            return View(omz);
        }
        public ActionResult Karın()
        {
            var krn = db.TBL_Karin.ToList();
            return View(krn);
        }
    }
}