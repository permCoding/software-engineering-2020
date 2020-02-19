using System;

namespace recur_dir
{
    class Program
    {
        static void Main(string[] args)
        {
            string dir = AppDomain.CurrentDomain.BaseDirectory;

            RecUtils.GetAllFiles(dir);
            foreach (string line in RecUtils.lst)
            {
                Console.WriteLine(line);
            }

            Console.ReadKey(true);
        }
    }
}