using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using con_recurs;
using rec = LibRec;

namespace con_recur_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string bin = Console.ReadLine();
            //Console.WriteLine(con_recurs.Solver.GetReverseString(bin));
            Console.WriteLine(Solver.GetReverseString(bin));
            Console.WriteLine(LibRec.Solver.GetReverseString(bin));
            Console.WriteLine(rec.Solver.GetReverseString(bin));

            Console.ReadKey(true);
        }
    }
}
