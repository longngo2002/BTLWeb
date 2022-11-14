using BTLWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTLWeb.Controllers
{
    public class CartController : Controller
    {

        private banlaptopEntities db = new banlaptopEntities();
        // GET: Cart
        public ActionResult Index()
        {
            Cart cartR = new Cart();
            List<product> list = new List<product>();
            if (Session["listCart"] != null)
            {
                list = (List<product>)Session["listCart"];
            }
            // viet tiep loop qua list san pham de tinh tien
            cartR.list = list;
            cartR.total = 0;
            foreach (var item in list)
            {
                cartR.total += item.price;
            }
            return View(cartR);
        }
        public int AddToCart(int productId)
        {
            int Count = 0;

            if (Session["listCart"] == null)
            {
                Session["listCart"] = new List<product>();
            }
            product pd = db.products.Where(n => n.id.Equals(productId)).SingleOrDefault();
            if (pd != null && pd.quantity > 0)
            {
                List<product> list = (List<product>)Session["listCart"];
                list.Add(pd);
                Session["listCart"] = list;
                Count = list.Count();

            }

            return Count;
        }
    }
}