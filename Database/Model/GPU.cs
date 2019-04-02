using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Database.Model
{
    public class GPU
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("Item")]
        public int ItemID { get; set; }
        public Item Item { get; set; }

        public string Series { get; set; }

        public string Chipset { get; set; }

        public string Memory { get; set; }

        public double CoreClock { get; set; }

        public virtual List<GPU> GPUs { get; set; }
    }
}
