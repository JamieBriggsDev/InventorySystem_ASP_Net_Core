using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Database.Model
{
    public enum Type { CASE, CPU, CPUCOOLER, GPU, MOTHERBOARD, PSU, RAM};

    public class Item
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public Type Component { get; set; }

        public virtual List<Item> Items { get; set; }


    }
}
