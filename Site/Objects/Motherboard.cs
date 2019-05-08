using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Database.Model
{
    public class Motherboard
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("Item")]
        public int ItemID { get; set; }
        public Item Item { get; set; }


        public string Socket { get; set; }

        public string FormFactor { get; set; }

        public int RamSlots { get; set; }

        public string MaxRam { get; set; }


        public virtual List<Motherboard> Motherboards { get; set; }
    }
}
