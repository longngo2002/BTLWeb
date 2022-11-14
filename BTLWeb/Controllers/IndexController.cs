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
            List<category> lstcate;

            int pagesize = 16; //so sp toi da tren 1 trang 
            int pagenumber = (page ?? 1); //neu null thi nhan 1

            return View();
        }


    }
}    