using System;
using System.Collections.Generic;
using TradeBankCategoryApp.Entities;
using TradeBankCategoryApp.Logic;

namespace TradeBankCategoryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trade Gategory Finder");

            List<Trade> portfolio = new List<Trade>()
            {
                new Trade(2000000, "Private"),
                new Trade(400000, "Public"),
                new Trade(500000, "Public"),
                new Trade(3000000, "Public")
            };

            Console.WriteLine();
            Console.Write("Trade Values Inputed;");
            Console.WriteLine();

            Console.WriteLine("ClientSector - Value");
            Console.WriteLine();

            foreach (Trade t in portfolio)
            {
                Console.WriteLine($"{t.ClientSector} - {t.Value}");
            }

            List<string> categories = new TradeCategoryLogic().GetGategoriesFromTrades(portfolio);

            Console.WriteLine();
            Console.WriteLine($"Trade Categirues {string.Join(", ", categories)}");

            Console.ReadKey();
        }
    }
}
