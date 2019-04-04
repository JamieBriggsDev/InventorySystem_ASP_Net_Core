using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Database;
using Database.Model;

namespace Site.Controllers
{
    public class InventoryController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Index Page!";
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

        // POST: /Inventory/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DatabaseController db = new DatabaseController();
            Item item = db.GetItems().First(i => i.ID == id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        // POST: /Inventory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DatabaseController db = new DatabaseController();
            db.DeleteItem(id);

            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            DatabaseController db = new DatabaseController();
            Item temp = db.GetItems().First(i => i.ID == id);
            object tempObject = db.GetObject(id);

            // Make list and add base item
            //List<object[]> list = new List<object[]> { new object[] { temp.Name, temp.Price, temp.Quantity } };

            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            keyValuePairs.Add("Name", temp.Name);
            keyValuePairs.Add("Price", "£" + temp.Price.ToString());
            keyValuePairs.Add("Quantity", temp.Quantity.ToString());

            foreach(var item in db.GetObject(id))
            {
                keyValuePairs.Add(item.Key, item.Value);
            }
            //keyValuePairs.Add("Type", (Type)tempObject.GetType());
            //list.Add(list);



            return View(keyValuePairs);
        }

        public ActionResult Edit(int id)
        {
            DatabaseController db = new DatabaseController();
            Item item = db.GetItems().First(i => i.ID == id);

            return View(item);
        }

        [HttpPost]
        public ActionResult Edit(Item item)
        {
            DatabaseController db = new DatabaseController();
            db.EditItem(item);
            return RedirectToAction("Index");
        }

    }
}