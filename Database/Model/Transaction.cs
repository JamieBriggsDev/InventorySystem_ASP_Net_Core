using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Database.Model
{
    public class Transaction
    {
        [Key]
        public int ID { get; set; }

        public string Item { get; set; }

        public int Change { get; set; }

        public DateTime Time { get; set; }

        public string Reason { get; set; }

        public string Description { get; set; }

        public virtual List<Transaction> Transactions { get; set; }
    }
}
