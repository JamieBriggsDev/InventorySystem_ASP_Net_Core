using Database.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site.Models
{
    public class CreateViewModel
    {
        public CreateViewModel()
        {
            Item = new Item();
            CPU = new CPU();
            CPUCooler = new CPUCooler();
            GPU = new GPU();
            Motherboard = new Motherboard();
            PSU = new PSU();
            RAM = new RAM();
            Case = new Case();

        }



        public Item Item {get; set;}

        public Case Case {get; set;}

        public CPU CPU {get; set;}

        public CPUCooler CPUCooler {get; set;}

        public GPU GPU {get; set;}

        public Motherboard Motherboard {get; set;}

        public PSU PSU {get; set;}

        public RAM RAM {get; set;}

    }
}