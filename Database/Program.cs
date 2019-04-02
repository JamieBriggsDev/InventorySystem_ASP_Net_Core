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

            DatabaseController DC = new DatabaseController();

            //DC.PrintAll();

            //DC.PrintCPUs();

            //DC.PrintCPUCoolers();

            //DC.PrintMotherboards();

            //DC.PrintGPUs();

            //DC.PrintRAMs();

            //DC.PrintCases();

            //DC.PrintPSUs();

            DC.PrintTransactions();

            Console.ReadKey();

        }
    }
}
