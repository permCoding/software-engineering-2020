using System;
using System.IO;

namespace con00
{
    class MainClass
    {
        public static void PrintDir(string dir)
        {
            string[] files = Directory.GetFiles(dir);
            string[] dirs = Directory.GetDirectories(dir);

            foreach (string d in dirs)
            {
                PrintDir(d);
            }

            Console.WriteLine('\n' + dir);
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
        }

        public static void Main(string[] args)
        {
            string dir = AppDomain.CurrentDomain.BaseDirectory;

            PrintDir(dir);

            Console.ReadKey(true);
        }
    }
}
