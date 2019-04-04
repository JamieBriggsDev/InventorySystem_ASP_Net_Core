using Database.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site.Models
{
    public class ItemViewModel
    {
        public List<Item> Items;

        public List<SelectListItem> Types { get; } = new List<SelectListItem>()
        {
            new SelectListItem { Value = "All", Text = "All" },
            new SelectListItem { Value = "Case", Text = "Case" },
            new SelectListItem { Value = "CPU", Text = "CPU" },
            new SelectListItem { Value = "CPUCooler", Text = "CPUCooler" },
            new SelectListItem { Value = "GPU", Text = "GPU" },
            new SelectListItem { Value = "Motherboard", Text = "Motherboard" },
            new SelectListItem { Value = "PSU", Text = "PSU" },
            new SelectListItem { Value = "RAM", Text = "RAM" }
        };

        public string ComponentCategory { get; set; }

        public string SearchString { get; set; }
    }
}