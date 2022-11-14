using BTLWeb.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTLWeb.Controllers
{
    public class IndexController : Controller
    {
        banlaptopEntities db = new banlaptopEntities();
        // GET: Index
        public ActionResult Index(int? page)
        {
            List<product> lstpd;
            lstpd = db.products.ToList();

            return View(lstpd);
        }

        public ActionResult Detail(string masp)
        {
            product sp = db.products.Where(n => n.id.Equals(masp)).FirstOrDefault();
            return View(sp);
        }
        
        public PartialViewResult Banner()
        {
            List<banner> banner = db.banners.ToList();

            return PartialView(banner);
        }
        
    }
}    