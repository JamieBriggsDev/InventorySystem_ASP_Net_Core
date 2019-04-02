using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Database.Model
{
    public class CPU
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("Item")]
        public int ItemID { get; set; }
        public Item Item { get; set; }

        public string Speed { get; set; }

        public int Cores { get; set; }

        public int Power { get; set; }
        public virtual List<CPU> CPUs { get; set; }
    }
}
