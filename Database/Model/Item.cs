using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Database.Model
{
    public enum Type { CASE, CPU, CPUCOOLER, GPU, MOTHERBOARD, PSU, RAM, OTHER};
    public class Item
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public Type Component { get; set; }

        public virtual List<Item> Items { get; set; }


    }
}
