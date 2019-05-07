using Database.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Database
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Environment.SetEnvironmentVariable("USERPROFILE", "c:\\temp");

            DatabaseController DC = new DatabaseController();

            DC.PrintTransactions();

            Console.ReadKey();

        }
    }
}
