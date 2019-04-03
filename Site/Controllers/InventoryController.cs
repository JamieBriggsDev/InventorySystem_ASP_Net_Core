using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Database;

namespace Site.Controllers
{
    public class InventoryController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "History Page!";
            DatabaseController db = new DatabaseController();
            var Items = db.GetItems();
            return View(Items);
        }

        public ActionResult History()
        {
            ViewBag.Message = "History Page!";
            DatabaseController db = new DatabaseController();
            var Transactions = db.GetTransactions();
            return View(Transactions);
        }

    }
}