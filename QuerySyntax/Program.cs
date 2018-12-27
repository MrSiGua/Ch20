using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuerySyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Alonso", "Zheng", "Simith", "Jones", "Smythe", "Small",
            "Ruiz", "Hsieh", "Jorgenson", "Ilyich", "Singh", "Samba", "Fatimah" };

            var queryResults =
                from n in names where n.StartsWith("S") orderby n select n;

            Console.WriteLine("Names beginning with S ordered alphabetically:");
            foreach (var item in queryResults)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Program finished, press Enter/Return to continues:");
            Console.ReadLine();
        }
    }
}
