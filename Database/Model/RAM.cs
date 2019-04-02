using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Database.Model
{
    public class RAM
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("Item")]
        public int ItemID { get; set; }
        public Item Item { get; set; }

        public string Speed { get; set; }

        public string Type { get; set; }

        public int CAS { get; set; }

        public string Modules { get; set; }

        public string Size { get; set; }

        public virtual List<RAM> RAMs { get; set; }
    }
}
