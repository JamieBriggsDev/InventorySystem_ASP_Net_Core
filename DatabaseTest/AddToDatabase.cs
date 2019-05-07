using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Database;
using Database.Model;

namespace DatabaseTests
{
    [TestClass]
    public class AddToDatabase
    {

        DatabaseController DC = new DatabaseController();

        [TestMethod]
        public void AddCPU()
        {
            // Remove item from database if it already exists
            if(DC.ItemExists("i5 4690k"))
            {
                int id = DC.GetItems().Find(a => a.Name == "i5 4690k").ID;
                DC.DeleteItem(id, false);
            }

            // Test CPU to add to database
            Item item = new Item
            {
                Name = "i5 4690k",
                Price = 89.99m,
                Quantity = 2,
                Component = Database.Model.Type.CPU
            };
            CPU cpu = new CPU
            {
                Speed = "4.2Ghz",
                Cores = 6,
                Power = 145,
                Item = item
            };

            Assert.IsTrue(DC.AddItem(item, cpu), "Failed to add test CPU.");

            Assert.IsTrue(DC.ItemExists("i5 4690k"), "Can't find test CPU in database.");
        }

        [TestMethod]
        public void AddCPUCooler()
        {
            // Remove item from database if it already exists
            if (DC.ItemExists("Cooler Master Hyper 212 EVO"))
            {
                int id = DC.GetItems().Find(a => a.Name == "Cooler Master Hyper 212 EVO").ID;
                DC.DeleteItem(id, false);
            }
            // Test CPU
            Item item = new Item
            {
                Name = "Cooler Master Hyper 212 EVO",
                Price = 27.95m,
                Quantity = 3,
                Component = Database.Model.Type.CPUCOOLER
            };
            CPUCooler cpuCooler = new CPUCooler
            {
                FanRPM = "600 - 2000 RPM",
                NoiseLevel = 37d
            };

            Assert.IsTrue(DC.AddItem(item, cpuCooler), "Failed to add test CPU Cooler.");

            Assert.IsTrue(DC.ItemExists("Cooler Master Hyper 212 EVO"), "Can't find test CPU Cooler in database.");
        }

        [TestMethod]
        public void AddMotherboard()
        {
            // Remove item from database if it already exists
            if (DC.ItemExists("Gigabyte - X470 AORUS ULTRA GAMING ATX AM4 Motherboard"))
            {
                int id = DC.GetItems().Find(a => a.Name == "Gigabyte - X470 AORUS ULTRA GAMING ATX AM4 Motherboard").ID;
                DC.DeleteItem(id, false);
            }
            // Test CPU
            Item item = new Item
            {
                Name = "Gigabyte - X470 AORUS ULTRA GAMING ATX AM4 Motherboard",
                Price = 134.95m,
                Quantity = 7,
                Component = Database.Model.Type.MOTHERBOARD
            };
            Motherboard motherboard = new Motherboard
            {
                Socket = "AM4",
                FormFactor = "ATX",
                RamSlots = 4,
                MaxRam = "64GB"
            };

            Assert.IsTrue(DC.AddItem(item, motherboard), "Failed to add test motherboard.");

            Assert.IsTrue(DC.ItemExists("Gigabyte - X470 AORUS ULTRA GAMING ATX AM4 Motherboard"), "Can't find test motherboard in database.");
        }

        [TestMethod]
        public void AddGPU()
        {
            // Remove item from database if it already exists
            if (DC.ItemExists("Gigabyte GV-N208TAORUSX W-11GC"))
            {
                int id = DC.GetItems().Find(a => a.Name == "Gigabyte GV-N208TAORUSX W-11GC").ID;
                DC.DeleteItem(id, false);
            }
            // Test CPU
            Item item = new Item
            {
                Name = "Gigabyte GV-N208TAORUSX W-11GC",
                Price = 1175.60m,
                Quantity = 3,
                Component = Database.Model.Type.GPU
            };
            GPU gpu = new GPU
            {
                Series = "AORUS XTREME WATERFORCE",
                Chipset = "GeForce RTX 2080 Ti",
                Memory = "11GB",
                CoreClock = 1.545
            };

            Assert.IsTrue(DC.AddItem(item, gpu), "Failed to add test gpu.");

            Assert.IsTrue(DC.ItemExists("Gigabyte GV-N208TAORUSX W-11GC"), "Can't find test gpu in database.");
        }

        [TestMethod]
        public void AddRAM()
        {
            // Remove item from database if it already exists
            if (DC.ItemExists("Corsair Vengance LPX"))
            {
                int id = DC.GetItems().Find(a => a.Name == "Corsair Vengance LPX").ID;
                DC.DeleteItem(id, false);
            }
            // Test CPU
            Item item = new Item
            {
                Name = "Corsair Vengance LPX",
                Price = 95.94m,
                Quantity = 1,
                Component = Database.Model.Type.RAM
            };
            RAM ram = new RAM
            {
                Speed = "DDR4-3000",
                Type = "288-pin DIMM",
                CAS = 15,
                Modules = "2x8GB",
                Size = "16GB"
            };

            Assert.IsTrue(DC.AddItem(item, ram), "Failed to add test RAM.");

            Assert.IsTrue(DC.ItemExists("Corsair Vengance LPX"));

        }

        [TestMethod]
        public void AddCase()
        {
            // Remove item from database if it already exists
            if (DC.ItemExists("NZXT H500 (Black)"))
            {
                int id = DC.GetItems().Find(a => a.Name == "NZXT H500 (Black)").ID;
                DC.DeleteItem(id, false);
            }
            // Test CPU
            Item item = new Item
            {
                Name = "NZXT H500 (Black)",
                Price = 69.99m,
                Quantity = 3,
                Component = Database.Model.Type.CASE
            };
            Case @case = new Case
            {
                Type = "Full Tower",
                ExtFiveBays = 0,
                IntThreeBays = 3
            };

            Assert.IsTrue(DC.AddItem(item, @case), "Failed to add test Case.");

            Assert.IsTrue(DC.ItemExists("NZXT H500 (Black)"));

        }

        [TestMethod]
        public void AddPSU()
        {
            // Remove item from database if it already exists
            if (DC.ItemExists("EVGA SuperNOVA 750"))
            {
                int id = DC.GetItems().Find(a => a.Name == "EVGA SuperNOVA 750").ID;
                DC.DeleteItem(id, false);
            }
            // Test CPU
            Item item = new Item
            {
                Name = "EVGA SuperNOVA 750",
                Price = 93.16m,
                Quantity = 2,
                Component = Database.Model.Type.PSU
            };
            PSU psu = new PSU
            {
                Series = "SuperNOVA G3",
                Form = "ATX",
                Efficiency = "80+ Gold",
                Watts = 750,
                Modular = "Full"

            };

            Assert.IsTrue(DC.AddItem(item, psu), "Failed to add test PSU.");

            Assert.IsTrue(DC.ItemExists("EVGA SuperNOVA 750"));

        }
    }
}