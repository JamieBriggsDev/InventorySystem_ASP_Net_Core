using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Database.Model
{
    public class CPUCooler
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("Item")]
        public int ItemID { get; set; }
        public Item Item { get; set; }

        public string FanRPM { get; set; }

        public double NoiseLevel { get; set; }

        public virtual List<CPUCooler> CPUCoolers { get; set; }
    }
}
