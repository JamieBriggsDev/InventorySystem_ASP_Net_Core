using Database;
using Database.Model;
using Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site.Controllers
{
    public class CreateController : Controller
    {

        // Required for saving changes
        private static CreateViewModel newItem;

        #region Create
        public ActionResult Index()
        {

            newItem = new CreateViewModel();

            return View();
        }

        [HttpPost]
        public ActionResult Index(Item item)
        {
            
            newItem.Item = item;
            if (item.Component == Database.Model.Type.CASE)
                return RedirectToAction("CASE");
            else if (item.Component == Database.Model.Type.CPU)
                return RedirectToAction("CPU", item);
            else if (item.Component == Database.Model.Type.CPUCOOLER)
                return RedirectToAction("CPUCooler", item);
            else if (item.Component == Database.Model.Type.GPU)
                return RedirectToAction("GPU", item);
            else if (item.Component == Database.Model.Type.MOTHERBOARD)
                return RedirectToAction("Motherboard", item);
            else if (item.Component == Database.Model.Type.PSU)
                return RedirectToAction("PSU", item);
            else if (item.Component == Database.Model.Type.RAM)
                return RedirectToAction("RAM", item);
            else
                return RedirectToAction("Index", "Inventory");
        }
        #endregion

        #region Case
        public ActionResult Case()
        {
            //CreateViewModel model = new CreateViewModel();
            return View(newItem);
        }

        [HttpPost]
        public ActionResult Case(Case @case)
        {
            newItem.Case = @case;

            // save to database
            DatabaseController db = new DatabaseController();
            db.AddItem(newItem.Item, newItem.Case);
            

            newItem = null;
            return RedirectToAction("Index", "Inventory");
        }
        #endregion

        #region CPU
        public ActionResult CPU()
        {
            //CreateViewModel model = new CreateViewModel();
            return View(newItem);
        }

        [HttpPost]
        public ActionResult CPU(CPU cpu)
        {
            newItem.CPU = cpu;

            // save to database
            DatabaseController db = new DatabaseController();
            db.AddItem(newItem.Item, newItem.CPU);


            newItem = null;
            return RedirectToAction("Index", "Inventory");
        }
        #endregion

        #region CPU Cooler
        public ActionResult CPUCooler()
        {
            //CreateViewModel model = new CreateViewModel();
            return View(newItem);
        }

        [HttpPost]
        public ActionResult CPUCooler(CPUCooler cpuCooler)
        {
            newItem.CPUCooler = cpuCooler;

            // save to database
            DatabaseController db = new DatabaseController();
            db.AddItem(newItem.Item, newItem.CPUCooler);


            newItem = null;
            return RedirectToAction("Index", "Inventory");
        }
        #endregion

        #region GPU
        public ActionResult GPU()
        {
            //CreateViewModel model = new CreateViewModel();
            return View(newItem);
        }

        [HttpPost]
        public ActionResult GPU(GPU gpu)
        {
            newItem.GPU = gpu;

            // save to database
            DatabaseController db = new DatabaseController();
            db.AddItem(newItem.Item, newItem.GPU);


            newItem = null;
            return RedirectToAction("Index", "Inventory");
        }
        #endregion

        #region Motherboard
        public ActionResult Motherboard()
        {
            //CreateViewModel model = new CreateViewModel();
            return View(newItem);
        }

        [HttpPost]
        public ActionResult Motherboard(Motherboard motherboard)
        {
            newItem.Motherboard = motherboard;

            // save to database
            DatabaseController db = new DatabaseController();
            db.AddItem(newItem.Item, newItem.Motherboard);


            newItem = null;
            return RedirectToAction("Index", "Inventory");
        }
        #endregion

        #region PSU
        public ActionResult PSU()
        {
            //CreateViewModel model = new CreateViewModel();
            return View(newItem);
        }

        [HttpPost]
        public ActionResult PSU(PSU psu)
        {
            newItem.PSU = psu;

            // save to database
            DatabaseController db = new DatabaseController();
            db.AddItem(newItem.Item, newItem.PSU);


            newItem = null;
            return RedirectToAction("Index", "Inventory");
        }
        #endregion

        #region RAM
        public ActionResult RAM()
        {
            //CreateViewModel model = new CreateViewModel();
            return View(newItem);
        }

        [HttpPost]
        public ActionResult RAM(RAM ram)
        {
            newItem.RAM = ram;

            // save to database
            DatabaseController db = new DatabaseController();
            db.AddItem(newItem.Item, newItem.RAM);


            newItem = null;
            return RedirectToAction("Index", "Inventory");
        }
        #endregion
    }
}