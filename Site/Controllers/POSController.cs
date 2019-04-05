using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site.Controllers
{
    public class POSController : Controller
    {
        // GET: POS
        public ActionResult Index()
        {
            DatabaseController db = new DatabaseController();
            var items = db.GetItems();
            return View(items);
        }
    }
}