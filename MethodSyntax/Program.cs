using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace MethodSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Alonso", "Zheng", "Simith", "Jones", "Smythe", "Small",
            "Ruiz", "Hsieh", "Jorgenson", "Ilyich", "Singh", "Samba", "Fatimah" };
            var queryResults = names.Where(n => n.StartsWith("A"));

            WriteLine("Names beginning with A:");
            foreach (var item in queryResults)
                WriteLine(item);

            Write("Program finished, press Enter/Return to continue:");
            ReadLine();
        }
    }
}
