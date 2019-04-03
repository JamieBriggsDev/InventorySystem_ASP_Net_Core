using Database.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;

namespace Database
{
    public class DatabaseController
    {

        /// <summary>
        /// Adds Item to database.
        /// </summary>
        /// <param name="_item">Item to Add.</param>
        /// <returns>True if successful.</returns>
        public bool AddItem(Item _item)
        {
            try
            {
                Item temp = _item;
                // Using database context.
                using (var db = new InventorySystemContext())
                {
                    // Check if item exists first
                    if (db.Items.Any(i => i.Name == _item.Name))
                        return false;

                    temp.ID = db.Items.Count();
                    // Add Item and save changes.
                    db.Items.Add(temp);
                    //db.SaveChanges();


                    Transaction transaction = new Transaction
                    {
                        Item = temp,
                        ItemID = temp.ID,
                        Change = temp.Quantity,
                        Time = DateTime.Now,
                        Reason = "Added entry to inventory"
                    };

                    

                    db.Transactions.Add(transaction);
                    db.SaveChanges();

                    
                }

            }
            catch (Exception e)
            {
                // Return false if failed
                return false;
            }
            // Return true if successful
            return true;
        }

        /// <summary>
        /// Adds CPU to database
        /// </summary>
        /// <param name="_item">Item details of CPU.</param>
        /// <param name="_cpu">CPU details.</param>
        /// <returns></returns>
        public bool AddCPU(Item _item, CPU _cpu)
        {
            try
            {
                // Using database context
                using (var db = new InventorySystemContext())
                {
                    // Add CPU to database if item does not fail.
                    if(AddItem(_item))
                    {
                        // Get item ID
                        var item = db.Items.First(c => c.Name == _item.Name);

                        // Add Item to cpu
                        CPU cpu = _cpu;
                        cpu.Item = item;

                        db.CPUs.Add(_cpu);
                        db.SaveChanges();

                    }
                    else
                    {
                        // Returns false if name exists.
                        return false;
                    }
                }
            }
            catch (Exception e)
            {
                // Return false if failed.
                return false;
            }
            // Return true if successful.
            return true;
        }


        /// <summary>
        /// Adds CP
        /// </summary>
        /// <param name="_item">Item details of CPU.</param>
        /// <param name="_cpuCooler"></param>
        /// <returns></returns>
        public bool AddCPUCooler(Item _item, CPUCooler _cpuCooler)
        {
            try
            {
                // Using database context
                using (var db = new InventorySystemContext())
                {
                    // Add CPU to database if item does not fail.
                    if (AddItem(_item))
                    {
                        // Get item ID
                        var item = db.Items.First(c => c.Name == _item.Name);

                        // Add Item to cpu
                        CPUCooler cpuCooler = _cpuCooler;
                        cpuCooler.Item = item;

                        db.CPUCoolers.Add(_cpuCooler);
                        db.SaveChanges();
                    }
                    else
                    {
                        // Returns false if name exists.
                        return false;
                    }
                }
            }
            catch (Exception e)
            {
                // Return false if failed.
                return false;
            }
            // Return true if successful.
            return true;
        }


        /// <summary>
        /// Adds motherboard to the database.
        /// </summary>
        /// <param name="_item">Item details of CPU.</param>
        /// <param name="_motherboard"></param>
        /// <returns></returns>
        public bool AddMotherboard(Item _item, Motherboard _motherboard)
        {
            try
            {
                // Using database context
                using (var db = new InventorySystemContext())
                {
                    // Add CPU to database if item does not fail.
                    if (AddItem(_item))
                    {
                        // Get item ID
                        var item = db.Items.First(c => c.Name == _item.Name);

                        // Add Item to cpu
                        Motherboard motherboard = _motherboard;
                        motherboard.Item = item;

                        db.Motherboards.Add(_motherboard);
                        db.SaveChanges();
                    }
                    else
                    {
                        // Returns false if name exists.
                        return false;
                    }
                }
            }
            catch (Exception e)
            {
                // Return false if failed.
                return false;
            }
            // Return true if successful.
            return true;
        }

        public bool AddGPU(Item _item, GPU _gpu)
        {
            try
            {
                // Using database context
                using (var db = new InventorySystemContext())
                {
                    // Add CPU to database if item does not fail.
                    if (AddItem(_item))
                    {
                        // Get item ID
                        var item = db.Items.First(c => c.Name == _item.Name);

                        // Add Item to cpu
                        GPU gpu = _gpu;
                        gpu.Item = item;

                        db.GPUs.Add(_gpu);
                        db.SaveChanges();
                    }
                    else
                    {
                        // Returns false if name exists.
                        return false;
                    }
                }
            }
            catch (Exception e)
            {
                // Return false if failed.
                return false;
            }
            // Return true if successful.
            return true;
        }


        public bool AddRAM(Item _item, RAM _ram)
        {
            try
            {
                // Using database context
                using (var db = new InventorySystemContext())
                {
                    // Add CPU to database if item does not fail.
                    if (AddItem(_item))
                    {
                        // Get item ID
                        var item = db.Items.First(c => c.Name == _item.Name);

                        // Add Item to RAM
                        RAM ram = _ram;
                        ram.Item = item;

                        db.RAMs.Add(_ram);
                        db.SaveChanges();
                    }
                    else
                    {
                        // Returns false if name exists.
                        return false;
                    }
                }
            }
            catch (Exception e)
            {
                // Return false if failed.
                return false;
            }
            // Return true if successful.
            return true;
        }

        public bool AddCase(Item _item, Case _case)
        {
            try
            {
                // Using database context
                using (var db = new InventorySystemContext())
                {
                    // Add CPU to database if item does not fail.
                    if (AddItem(_item))
                    {
                        // Get item ID
                        var item = db.Items.First(c => c.Name == _item.Name);

                        // Add Item to Case
                        Case @case = _case;
                        @case.Item = item;

                        db.Cases.Add(_case);
                        db.SaveChanges();
                    }
                    else
                    {
                        // Returns false if name exists.
                        return false;
                    }
                }
            }
            catch (Exception e)
            {
                // Return false if failed.
                return false;
            }
            // Return true if successful.
            return true;
        }

        public bool AddPSU(Item _item, PSU _psu)
        {
            try
            {
                // Using database context
                using (var db = new InventorySystemContext())
                {
                    // Add CPU to database if item does not fail.
                    if (AddItem(_item))
                    {
                        // Get item ID
                        var item = db.Items.First(c => c.Name == _item.Name);

                        // Add Item to RAM
                        PSU psu = _psu;
                        psu.Item = item;

                        db.PSUs.Add(_psu);
                        db.SaveChanges();
                    }
                    else
                    {
                        // Returns false if name exists.
                        return false;
                    }
                }
            }
            catch (Exception e)
            {
                // Return false if failed.
                return false;
            }
            // Return true if successful.
            return true;
        }

        public bool ItemExists(string _name)
        {
            using (var db = new InventorySystemContext())
            {
                if (db.Items.Any(i => i.Name == _name))
                    return true;
                else
                    return false;
            }
        }

        //////////////////
        ///To List Methods
        //////////////////

        public List<Item> GetItems()
        {
            using (var db = new InventorySystemContext())
            {
                return db.Items.ToList();
            }
        }

        public List<Transaction> GetTransactions()
        {
            using (var db = new InventorySystemContext())
            {
                var transactions = db.Transactions.Include(t => t.Item);
                return transactions.ToList();
                
            }
        }

        // Print Methods

        /// <summary>
        /// Prints all Items.
        /// </summary>
        public void PrintAll()
        {
            using (var db = new InventorySystemContext())
            {
                var query = from i in db.Items
                            orderby i.Price
                            select i;

                Console.WriteLine("____All Items____");
                Console.WriteLine();
                foreach (var item in query)
                {
                    // Print ID
                    Console.WriteLine("ID: {0}", item.ID);
                    // Print Name
                    Console.WriteLine("Name: {0}", item.Name);
                    // Print Price
                    Console.WriteLine("Price: £{0}", item.Price);
                    // Quantity
                    Console.WriteLine("Quantity: {0}", item.Quantity);
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
        }

        /// <summary>
        /// Prints all CPUs
        /// </summary>
        public void PrintCPUs()
        {
            using (var db = new InventorySystemContext())
            {
                var query = from c in db.CPUs
                            orderby c.Power
                            select c;

                Console.WriteLine("____CPUs____");
                Console.WriteLine();
                foreach(var cpu in query)
                {
                    Item temp = db.Items.First(i => i.ID == cpu.ItemID);
                    // ID
                    Console.WriteLine("ID: {0}", temp.ID);
                    // Name
                    Console.WriteLine("Name: {0}", temp.Name);
                    // Speed
                    Console.WriteLine("Speed: {0}", cpu.Speed);
                    // Cores
                    Console.WriteLine("Cores: {0}", cpu.Cores);
                    // Power
                    Console.WriteLine("Power: {0}", cpu.Power);
                    // Price
                    Console.WriteLine("Price: £{0}", temp.Price);
                    // Quantity
                    Console.WriteLine("Quantity: {0}", temp.Quantity);
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
        }

        /// <summary>
        /// Prints CPU Coolers.
        /// </summary>
        public void PrintCPUCoolers()
        {
            using (var db = new InventorySystemContext())
            {
                var query = from c in db.CPUCoolers
                            orderby c.NoiseLevel
                            select c;

                Console.WriteLine("____CPUCoolers____");
                Console.WriteLine();
                foreach (var cooler in query)
                {
                    Item temp = db.Items.First(i => i.ID == cooler.ItemID);
                    // ID
                    Console.WriteLine("ID: {0}", temp.ID);
                    // Name
                    Console.WriteLine("Name: {0}", temp.Name);
                    // Speed
                    Console.WriteLine("Fan RPM: {0}", cooler.FanRPM);
                    // Cores
                    Console.WriteLine("Noise Level: {0}dB", cooler.NoiseLevel);
                    // Price
                    Console.WriteLine("Price: £{0}", temp.Price);
                    // Quantity
                    Console.WriteLine("Quantity: {0}", temp.Quantity);
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
        }

        /// <summary>
        /// Prints CPU Coolers.
        /// </summary>
        public void PrintMotherboards()
        {
            using (var db = new InventorySystemContext())
            {
                var query = from c in db.Motherboards
                            orderby c.ID
                            select c;

                Console.WriteLine("____Motherboards____");
                Console.WriteLine();
                foreach (var motherboard in query)
                {
                    Item temp = db.Items.First(i => i.ID == motherboard.ItemID);
                    // ID
                    Console.WriteLine("ID: {0}", temp.ID);
                    // Name
                    Console.WriteLine("Name: {0}", temp.Name);
                    // Socket
                    Console.WriteLine("Socket: {0}", motherboard.Socket);
                    // Form Factor
                    Console.WriteLine("Form Factor: {0}", motherboard.FormFactor);
                    // Socket
                    Console.WriteLine("Ram Slots: {0}", motherboard.RamSlots);
                    // Socket
                    Console.WriteLine("Max Ram: {0}", motherboard.MaxRam);
                    // Price
                    Console.WriteLine("Price: £{0}", temp.Price);
                    // Quantity
                    Console.WriteLine("Quantity: {0}", temp.Quantity);
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
        }

        /// <summary>
        /// Prints GPUs.
        /// </summary>
        public void PrintGPUs()
        {
            using (var db = new InventorySystemContext())
            {
                var query = from c in db.GPUs
                            orderby c.ID
                            select c;

                Console.WriteLine("____GPUs____");
                Console.WriteLine();
                foreach (var gpu in query)
                {
                    Item temp = db.Items.First(i => i.ID == gpu.ItemID);
                    // ID
                    Console.WriteLine("ID: {0}", temp.ID);
                    // Name
                    Console.WriteLine("Name: {0}", temp.Name);
                    // Socket
                    Console.WriteLine("Series: {0}", gpu.Series);
                    // Form Factor
                    Console.WriteLine("Chipset: {0}", gpu.Chipset);
                    // Socket
                    Console.WriteLine("Memory: {0}", gpu.Memory);
                    // Socket
                    Console.WriteLine("CoreClock: {0} GHz", gpu.CoreClock);
                    // Price
                    Console.WriteLine("Price: £{0}", temp.Price);
                    // Quantity
                    Console.WriteLine("Quantity: {0}", temp.Quantity);
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
        }

        /// <summary>
        /// Prints RAMs.
        /// </summary>
        public void PrintRAMs()
        {
            using (var db = new InventorySystemContext())
            {
                var query = from c in db.RAMs
                            orderby c.ID
                            select c;

                Console.WriteLine("____RAMs____");
                Console.WriteLine();
                foreach (var ram in query)
                {
                    Item temp = db.Items.First(i => i.ID == ram.ItemID);
                    // ID
                    Console.WriteLine("ID: {0}", temp.ID);
                    // Name
                    Console.WriteLine("Name: {0}", temp.Name);
                    // Speed
                    Console.WriteLine("Speed: {0}", ram.Speed);
                    // Type
                    Console.WriteLine("Type: {0}", ram.Type);
                    // CAS
                    Console.WriteLine("CAS: {0}", ram.CAS);
                    // Modules
                    Console.WriteLine("Modules: {0}", ram.Modules);
                    // Size
                    Console.WriteLine("Size: {0}", ram.Size);
                    // Price
                    Console.WriteLine("Price: £{0}", temp.Price);
                    // Quantity
                    Console.WriteLine("Quantity: {0}", temp.Quantity);
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
        }


        public void PrintCases()
        {
            using (var db = new InventorySystemContext())
            {
                var query = from c in db.Cases
                            orderby c.ID
                            select c;

                Console.WriteLine("____Cases____");
                Console.WriteLine();
                foreach (var cases in query)
                {
                    Item temp = db.Items.First(i => i.ID == cases.ItemID);
                    // ID
                    Console.WriteLine("ID: {0}", temp.ID);
                    // Name
                    Console.WriteLine("Name: {0}", temp.Name);
                    // Type
                    Console.WriteLine("Type: {0}", cases.Type);
                    // External 5" bays
                    Console.WriteLine("Ext. 5\" bays: {0}", cases.ExtFiveBays);
                    // Internal 5" bays
                    Console.WriteLine("Int. 3\" bays: {0}", cases.IntThreeBays);
                    // Price
                    Console.WriteLine("Price: £{0}", temp.Price);
                    // Quantity
                    Console.WriteLine("Quantity: {0}", temp.Quantity);
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
        }


        public void PrintPSUs()
        {
            using (var db = new InventorySystemContext())
            {
                var query = from c in db.PSUs
                            orderby c.ID
                            select c;

                Console.WriteLine("____PSUs____");
                Console.WriteLine();
                foreach (var psu in query)
                {
                    Item temp = db.Items.First(i => i.ID == psu.ItemID);
                    // ID
                    Console.WriteLine("ID: {0}", temp.ID);
                    // Name
                    Console.WriteLine("Name: {0}", temp.Name);
                    // Series
                    Console.WriteLine("Series: {0}", psu.Series);
                    // Form
                    Console.WriteLine("Form: {0}", psu.Form);
                    // Efficiency
                    Console.WriteLine("Efficiency: {0}", psu.Efficiency);
                    // Watts
                    Console.WriteLine("Watts: {0}w", psu.Watts);
                    // Modular
                    Console.WriteLine("Modular: {0}", psu.Modular);
                    // Price
                    Console.WriteLine("Price: £{0}", temp.Price);
                    // Quantity
                    Console.WriteLine("Quantity: {0}", temp.Quantity);
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
        }


        public void PrintTransactions()
        {
            using (var db = new InventorySystemContext())
            {
                var query = from c in db.Transactions
                            orderby c.ID
                            select c;

                Console.WriteLine("____TRANSACTIONS____");
                Console.WriteLine();
                foreach (var transaction in query)
                {
                    Item item = db.Items.First(i => i.ID == transaction.ID);
                    Console.WriteLine("Name:{0}", item.Name);
                    Console.WriteLine("Change:{0}", transaction.Change);
                    Console.WriteLine("Time:{0}", transaction.Time.ToLongTimeString());
                    Console.WriteLine("Reason: {0}\n", transaction.Reason);
                }
            }
        }
    }
}
