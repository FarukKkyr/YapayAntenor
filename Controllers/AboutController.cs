using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YapayAntenor.Models.EntityFramework;

namespace YapayAntenor.Controllers
{
    public class AboutController : Controller
    {
        // GET: About

        TEZEntities db = new TEZEntities();
        public ActionResult Index()
        {
            var about = db.TBL_Hakkimizda.ToList();
            return View(about);
        }
    }
}