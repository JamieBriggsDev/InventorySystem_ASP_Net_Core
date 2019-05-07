using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Database;
using Database.Model;

namespace DatabaseTests
{
    [TestClass]
    public class EditDatabase
    {

        DatabaseController DC = new DatabaseController();

        [TestMethod]
        public void EditName()
        {
            // Get total history
            int totalHistory = DC.GetTransactions().Count;
            // Get CPU
            Assert.IsTrue(DC.GetItems().Exists(a => a.Name == "Corsair Vengance LPX"), "Item doesnt Exist.");
            Item item = DC.GetItems().Find(a => a.Name == "Corsair Vengance LPX");
            // Edit Price
            item.Name = "Corsair Vengance LPX 16GB";
            // Edit Item in Database Controller
            Assert.IsTrue(DC.EditItem(item, false), "Item failed to edit.");
            // Check if price was updated.
            Assert.IsTrue(DC.GetItems().Exists(a => a.Name == "Corsair Vengance LPX 16GB"), "Couldn't Edit Name.");
            // Check if entry added to history
            Assert.IsTrue(DC.GetTransactions().Count == totalHistory, "Transaction added when it shouldn't have.");
        }

        [TestMethod]
        public void EditPrice()
        {
            // Get total history
            int totalHistory = DC.GetTransactions().Count;
            // Get CPU
            Item item = DC.GetItems().Find(a => a.Name == "i5 4690k");
            // Edit Price
            item.Price = 79.99m;
            // Edit Item in Database Controller
            Assert.IsTrue(DC.EditItem(item, false), "Item failed to edit.");
            // Check if price was updated.
            Assert.IsTrue(DC.GetItems().Find(a => a.Name == "i5 4690k").Price == 79.99m, "Couldn't Edit Price.");
            // Check if entry added to history
            Assert.IsTrue(DC.GetTransactions().Count == totalHistory, "Transaction added when it shouldn't have.");
        }

        [TestMethod]
        public void EditQuantity()
        {
            // Get total history
            int totalHistory = DC.GetTransactions().Count;
            // Get CPU
            Item item = DC.GetItems().Find(a => a.Name == "Cooler Master Hyper 212 EVO");
            // Edit Price
            item.Quantity = 2;
            // Edit Item in Database Controller
            DC.EditItem(item, true);
            // Check if price was updated.
            Assert.IsTrue(DC.GetItems().Find(a => a.Name == "Cooler Master Hyper 212 EVO").Quantity == 2, "Couldn't Edit Quantity.");
            // Check if entry added to history
            Assert.IsTrue(DC.GetTransactions().Count == (totalHistory + 1), "Transactions not Updated");
        }



    }
}