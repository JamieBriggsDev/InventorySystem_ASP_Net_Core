using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Database.Model
{
    public class Case
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("Item")]
        public int ItemID { get; set; }
        public Item Item { get; set; }

        public string Type { get; set; }

        public int ExtFiveBays { get; set; }

        public int IntThreeBays { get; set; }

        public virtual List<Case> Cases { get; set; }
    }
}
