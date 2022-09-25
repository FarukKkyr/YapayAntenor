using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using YapayAntenor.Models.EntityFramework;


namespace YapayAntenor.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        TEZEntities db = new TEZEntities();
               
        public ActionResult Index()
        {
            return View();
        }

       [HttpPost]
        public ActionResult Index(TBL_Admin a)
        {
            var admin = db.TBL_Admin.FirstOrDefault(x => x.KullaniciAdi == a.KullaniciAdi && x.Sifre == a.Sifre);
            if(admin!=null)
            {
                FormsAuthentication.SetAuthCookie(admin.KullaniciAdi,false);
                //Session["KullaniciAdi"] = admin.KullaniciAdi.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
           
        }
    }
}