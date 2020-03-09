using System;
//using Utils;
using Conv = Utils.Convert;

namespace prog_convert
{
    class RRR
    {

    }
    class MainClass
    {
        public static void Main()
        {
            var obj1 = new Conv(13);
            var obj2 = new Conv("1101");
            var obj3 = new Conv();

            Console.WriteLine(obj1.Num_bin);
            Console.WriteLine(obj2.Num_dec);
            Console.WriteLine(obj3.Num_bin);
            Console.WriteLine(obj3.Num_dec);
        }
    }
}
