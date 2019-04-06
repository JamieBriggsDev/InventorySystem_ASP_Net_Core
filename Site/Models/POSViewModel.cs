using Database.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site.Models
{
    public class POSViewModel
    {
        public POSViewModel()
        {
            Sales = new Dictionary<int, int>();
        }

        public List<Item> Items { get; set; }

        public Dictionary<int, int> Sales { get; set; }

        public POSViewModel Add(int key, int value)
        {
            Sales.Add(key, value);
            return this;
        }
    }
}