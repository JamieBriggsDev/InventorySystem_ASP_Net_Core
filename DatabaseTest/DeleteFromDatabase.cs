using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Database;
using Database.Model;

namespace DatabaseTests
{
    [TestClass]
    public class DeleteFromDatabase
    {
        DatabaseController DC = new DatabaseController();

        [TestMethod]
        public void DeleteCPU()
        {
            // Remove item from database if it already exists
            if (DC.ItemExists("AMD Ryzen 5 2600"))
            {
                int tempID = DC.GetItems().Find(a => a.Name == "AMD Ryzen 5 2600").ID;
                DC.DeleteItem(tempID, false);
            }

            // Test CPU to add to database
            Item item = new Item
            {
                Name = "AMD Ryzen 5 2600",
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
            // Add Item
            Assert.IsTrue(DC.AddItem(item, cpu), "Couldnt Add Item for test.");
            // Delete Item (Returns false if transaction couldnt be added)
            int id = DC.GetItems().Find(a => a.Name == item.Name).ID;
            Assert.IsTrue(DC.DeleteItem(id), "Failed to delete from database");
            

        }

        [TestMethod]
        public void DeleteCPUCooler()
        {
            // Remove item from database if it already exists
            if (DC.ItemExists("Corsair H100i PRO"))
            {
                int tempID = DC.GetItems().Find(a => a.Name == "Corsair H100i PRO").ID;
                DC.DeleteItem(tempID, false);
            }
            // Test CPU
            Item item = new Item
            {
                Name = "Corsair H100i PRO",
                Price = 27.95m,
                Quantity = 3,
                Component = Database.Model.Type.CPUCOOLER
            };
            CPUCooler cpuCooler = new CPUCooler
            {
                FanRPM = "600 - 2000 RPM",
                NoiseLevel = 37d
            };
            // Add Item
            Assert.IsTrue(DC.AddItem(item, cpuCooler), "Couldnt Add Item for test.");
            // Delete Item (Returns false if transaction couldnt be added)
            int id = DC.GetItems().Find(a => a.Name == item.Name).ID;
            Assert.IsTrue(DC.DeleteItem(id), "Failed to delete from database");
        }

        [TestMethod]
        public void DeleteMotherboard()
        {
            // Remove item from database if it already exists
            if (DC.ItemExists("MSI B450 TOMAHAWK"))
            {
                int tempID = DC.GetItems().Find(a => a.Name == "MSI B450 TOMAHAWK").ID;
                DC.DeleteItem(tempID, false);
            }
            // Test CPU
            Item item = new Item
            {
                Name = "MSI B450 TOMAHAWK",
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
            // Add Item
            Assert.IsTrue(DC.AddItem(item, motherboard), "Couldnt Add Item for test.");
            // Delete Item (Returns false if transaction couldnt be added)
            int id = DC.GetItems().Find(a => a.Name == item.Name).ID;
            Assert.IsTrue(DC.DeleteItem(id), "Failed to delete from database");
        }

        [TestMethod]
        public void DeleteGPU()
        {
            // Remove item from database if it already exists
            if (DC.ItemExists("Gigabyte GV-N2070WF3-8GC"))
            {
                int tempID = DC.GetItems().Find(a => a.Name == "Gigabyte GV-N2070WF3-8GC").ID;
                DC.DeleteItem(tempID, false);
            }
            // Test CPU
            Item item = new Item
            {
                Name = "Gigabyte GV-N2070WF3-8GC",
                Price = 1175.60m,
                Quantity = 3,
                Component = Database.Model.Type.GPU
            };
            GPU gpu = new GPU
            {
                Series = "AORUS XTREME WATERFORCE",
                Chipset = "GeForce RTX 2070",
                Memory = "11GB",
                CoreClock = 1.545
            };
            // Add Item
            Assert.IsTrue(DC.AddItem(item, gpu), "Couldnt Add Item for test.");
            // Delete Item (Returns false if transaction couldnt be added)
            int id = DC.GetItems().Find(a => a.Name == item.Name).ID;
            Assert.IsTrue(DC.DeleteItem(id), "Failed to delete from database");
        }

        [TestMethod]
        public void DeleteRAM()
        {
            // Remove item from database if it already exists
            if (DC.ItemExists("G.Skill Trident Z RGB"))
            {
                int tempID = DC.GetItems().Find(a => a.Name == "G.Skill Trident Z RGB").ID;
                DC.DeleteItem(tempID, false);
            }
            // Test CPU
            Item item = new Item
            {
                Name = "G.Skill Trident Z RGB",
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
            // Add Item
            Assert.IsTrue(DC.AddItem(item, ram), "Couldnt Add Item for test.");
            // Delete Item (Returns false if transaction couldnt be added)
            int id = DC.GetItems().Find(a => a.Name == item.Name).ID;
            Assert.IsTrue(DC.DeleteItem(id), "Failed to delete from database");

        }

        [TestMethod]
        public void DeleteCase()
        {
            // Remove item from database if it already exists
            if (DC.ItemExists("Corsair 200R"))
            {
                int tempID = DC.GetItems().Find(a => a.Name == "Corsair 200R").ID;
                DC.DeleteItem(tempID, false);
            }
            // Test CPU
            Item item = new Item
            {
                Name = "Corsair 200R",
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
            // Add Item
            Assert.IsTrue(DC.AddItem(item, @case), "Couldnt Add Item for test.");
            // Delete Item (Returns false if transaction couldnt be added)
            int id = DC.GetItems().Find(a => a.Name == item.Name).ID;
            Assert.IsTrue(DC.DeleteItem(id), "Failed to delete from database");
        }

        [TestMethod]
        public void DeletePSU()
        {
            // Remove item from database if it already exists
            if (DC.ItemExists("Corsair CX550M"))
            {
                int tempID = DC.GetItems().Find(a => a.Name == "Corsair CX550M").ID;
                DC.DeleteItem(tempID, false);
            }
            // Test CPU
            Item item = new Item
            {
                Name = "Corsair CX550M",
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
            // Add Item
            Assert.IsTrue(DC.AddItem(item, psu), "Couldnt Add Item for test.");
            // Delete Item (Returns false if transaction couldnt be added)
            int id = DC.GetItems().Find(a => a.Name == item.Name).ID;
            Assert.IsTrue(DC.DeleteItem(id), "Failed to delete from database");
        }

    }
}