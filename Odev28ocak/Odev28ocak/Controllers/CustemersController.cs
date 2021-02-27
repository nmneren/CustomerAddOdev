using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Odev28ocak.Controllers
{
    public class CustemersController : Controller
    {
        // GET: Custemers
        NorthwindEntities db = new NorthwindEntities();

        public ActionResult Index()
        {
            return View(db.Customers.ToList());
        }

        public ActionResult Ekle()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Ekle(Customer model)
        {
            db.Customers.Add(model);

            db.SaveChanges();

            return View();
        }

    }
}