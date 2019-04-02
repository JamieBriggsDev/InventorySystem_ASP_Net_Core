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
        public void AddItem()
        {
            // Test blank Item
            Item item = new Item
            {
                Name = "Item 1",
                Price = 19.99m,
                Quantity = 6
            };

            DC.AddItem(item);

            Assert.IsTrue(DC.ItemExists("Item 1"), "Can't find test Item in database.");
        }

        [TestMethod]
        public void AddCPU()
        {

            // Test CPU
            Item item = new Item
            {
                Name = "i5 4690k",
                Price = 89.99m,
                Quantity = 2
            };
            CPU cpu = new CPU
            {
                Speed = "4.2Ghz",
                Cores = 6,
                Power = 145,
                Item = item
            };

            Assert.IsTrue(DC.AddCPU(item, cpu), "Failed to add test CPU.");

            Assert.IsTrue(DC.ItemExists("i5 4690k"), "Can't find test CPU in database.");
        }

        [TestMethod]
        public void AddCPUCooler()
        {

            // Test CPU
            Item item = new Item
            {
                Name = "Cooler Master Hyper 212 EVO",
                Price = 27.95m,
                Quantity = 3
            };
            CPUCooler cpuCooler = new CPUCooler
            {
                FanRPM = "600 - 2000 RPM",
                NoiseLevel = 37d
            };

            Assert.IsTrue(DC.AddCPUCooler(item, cpuCooler), "Failed to add test CPU Cooler.");

            Assert.IsTrue(DC.ItemExists("Cooler Master Hyper 212 EVO"), "Can't find test CPU Cooler in database.");
        }

        [TestMethod]
        public void AddMotherboard()
        {

            // Test CPU
            Item item = new Item
            {
                Name = "Gigabyte - X470 AORUS ULTRA GAMING ATX AM4 Motherboard",
                Price = 134.95m,
                Quantity = 7
            };
            Motherboard motherboard = new Motherboard
            {
                Socket = "AM4",
                FormFactor = "ATX",
                RamSlots = 4,
                MaxRam = "64GB"
            };

            Assert.IsTrue(DC.AddMotherboard(item, motherboard), "Failed to add test motherboard.");

            Assert.IsTrue(DC.ItemExists("Gigabyte - X470 AORUS ULTRA GAMING ATX AM4 Motherboard"), "Can't find test motherboard in database.");
        }

        [TestMethod]
        public void AddGPU()
        {
            // Test CPU
            Item item = new Item
            {
                Name = "Gigabyte GV-N208TAORUSX W-11GC",
                Price = 1175.60m,
                Quantity = 3
            };
            GPU gpu = new GPU
            {
                Series = "AORUS XTREME WATERFORCE",
                Chipset = "GeForce RTX 2080 Ti",
                Memory = "11GB",
                CoreClock = 1.545
            };

            Assert.IsTrue(DC.AddGPU(item, gpu), "Failed to add test gpu.");

            Assert.IsTrue(DC.ItemExists("Gigabyte GV-N208TAORUSX W-11GC"), "Can't find test gpu in database.");
        }

        [TestMethod]
        public void AddRAM()
        {
            // Test CPU
            Item item = new Item
            {
                Name = "Corsair Vengance LPX",
                Price = 95.94m,
                Quantity = 1
            };
            RAM ram = new RAM
            {
                Speed = "DDR4-3000",
                Type = "288-pin DIMM",
                CAS = 15,
                Modules = "2x8GB",
                Size = "16GB"
            };

            Assert.IsTrue(DC.AddRAM(item, ram), "Failed to add test RAM.");

            Assert.IsTrue(DC.ItemExists("Corsair Vengance LPX"));

        }

        [TestMethod]
        public void AddCase()
        {
            // Test CPU
            Item item = new Item
            {
                Name = "NZXT Case",
                Price = 97.99m,
                Quantity = 3
            };
            Case @case = new Case
            {
                Type = "Full Tower",
                ExtFiveBays = 0,
                IntThreeBays = 3
            };

            Assert.IsTrue(DC.AddCase(item, @case), "Failed to add test Case.");

            Assert.IsTrue(DC.ItemExists("NZXT Case"));

        }

        [TestMethod]
        public void AddPSU()
        {
            // Test CPU
            Item item = new Item
            {
                Name = "EVGA SuperNOVA 750",
                Price = 93.16m,
                Quantity = 2
            };
            PSU psu = new PSU
            {
                Series = "SuperNOVA G3",
                Form = "ATX",
                Efficiency = "80+ Gold",
                Watts = 750,
                Modular = "Full"

            };

            Assert.IsTrue(DC.AddPSU(item, psu), "Failed to add test PSU.");

            Assert.IsTrue(DC.ItemExists("EVGA SuperNOVA 750"));

        }
    }
}
