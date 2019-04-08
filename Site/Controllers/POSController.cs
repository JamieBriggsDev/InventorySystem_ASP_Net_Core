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

            //POSViewModel posVM = new POSViewModel();
            POSViewModel posVM = new POSViewModel();

            foreach(var item in items)
            {

                posVM.Items.Add(item);
                posVM.Quantitys.Add(0);
                //posVM.Add(temp);
            }
            //posVM.Items = items;
             return View(posVM);
        }

        [HttpPost]
        public ActionResult Index(POSViewModel posVM)
        {
            var values = posVM;

            return RedirectToAction("Index", "Inventory");
        }

    }
}