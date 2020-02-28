using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace con_recurs
{
    class Program
    {
        static void Main(string[] args)
        {
            string bin = Console.ReadLine();
            Console.WriteLine(Solver.BinToDec(bin));
            Console.WriteLine(Solver.BinToDec_(bin));

            Console.WriteLine(Solver.BinToDec__(Solver.GetReverseString(bin)));

            Console.ReadKey(true);
        }
    }
}
