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
            List<POSViewModel> posVM = new List<POSViewModel>();

            foreach(var item in items)
            {
                posVM.Add(new POSViewModel()
                {
                    Item = item,
                    ID = item.ID,
                    Quantity = 0
                });
            }
            //foreach(var item in items)
            //{

            //    posVM.Items.Add(item);
            //    posVM.Quantitys.Add(0);
            //    posVM.Quantities.Add(item.ID, 0);
            //    //posVM.Add(temp);
            //}
            //posVM.Items = items;
             return View(posVM);
        }

        [HttpPost]
        public ActionResult Index(List<POSViewModel> posVM)
        {
            var values = posVM;
            values = values.Where(i => i.Quantity > 0).ToList();
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            foreach(var value in values)
            {
                keyValuePairs.Add(value.ID, value.Quantity);
            }

            DatabaseController db = new DatabaseController();
            db.RemoveStock(keyValuePairs);

            return RedirectToAction("Index", "Inventory");
        }

    }
}