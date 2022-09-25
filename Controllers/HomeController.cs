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
    public class HomeController : Controller
    {
        // GET: Home
        TEZEntities db = new TEZEntities();
        
        public ActionResult Index(int sayfa=1)
        {
            var dgr = db.TBL_Blog.OrderByDescending(x => x.BlogID).ToPagedList(sayfa, 3);          
            return View(dgr);
            
        }
    }
}