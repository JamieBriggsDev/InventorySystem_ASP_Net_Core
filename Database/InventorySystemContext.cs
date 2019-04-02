using Database.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Database
{
    class InventorySystemContext : DbContext
    {
        public DbSet<Item> Items { get; set; }

        public DbSet<CPU> CPUs { get; set; }

        public DbSet<CPUCooler> CPUCoolers { get; set; }

        public DbSet<Motherboard> Motherboards { get; set; }

        public DbSet<GPU> GPUs { get; set; }

        public DbSet<RAM> RAMs { get; set; }

        public DbSet<Case> Cases { get; set; }

        public DbSet<PSU> PSUs { get; set; }

        public DbSet<Transaction> Transactions { get; set; }
    }
}
