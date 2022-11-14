using BTLWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTLWeb.Controllers
{
    public class LoginController : Controller
    {
        private banlaptopEntities db = new banlaptopEntities();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Autherize(user userModel)
        {
            var userDetail = db.users.Where(x => x.name == userModel.name
            && x.password == userModel.password)
                .FirstOrDefault();
            if (userDetail == null)
            {
          
                return View("Index", userModel);

            }
            else
            {
                Session["userName"] = userDetail.name;
                Session["userId"] = userDetail.id;
                Session["avatarUrl"] = userDetail.img_url;
                return RedirectToAction("Index", "products");
            }
        }
    }
}