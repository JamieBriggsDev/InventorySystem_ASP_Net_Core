using Database;
using Site.Models;
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

            POSViewModel posVM = new POSViewModel();
            posVM.Items = items;
            return View(posVM);
        }

        [HttpPost]
        public ActionResult Index(POSViewModel posVM)
        {
            var values = posVM.Items;

            return View(posVM);
        }
    }
}