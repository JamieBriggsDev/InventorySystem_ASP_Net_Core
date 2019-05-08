using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Database.Model
{
    public class PSU
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("Item")]
        public int ItemID { get; set; }
        public Item Item { get; set; }

        public string Series { get; set; }

        public string Form { get; set; }

        public string Efficiency { get; set; }

        public int Watts { get; set; }

        public string Modular { get; set; }

        public virtual List<PSU> PSUs { get; set; }
    }
}
