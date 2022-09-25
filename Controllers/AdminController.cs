using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using YapayAntenor.Models.EntityFramework;

namespace YapayAntenor.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        TEZEntities db = new TEZEntities();

       
        public ActionResult Index()
        {
            return View();
        } 
        
        
       

    }
}