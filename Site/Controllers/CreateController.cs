using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Database;
using Database.Model;
using Site.Models;

namespace Site.Controllers
{
    public class CreateController : Controller
    {
        public ActionResult Index()
        {
            //CreateViewModel model = new CreateViewModel();
            return View();
        }
        public ActionResult Create(CreateViewModel item)
        {
            //CreateViewModel model = new CreateViewModel();
            return View(item);
        }

    }
}