using System;

namespace con00
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string dir = AppDomain.CurrentDomain.BaseDirectory;

            Utils.GetDir(dir);
            foreach (string line in Utils.lst)
            {
                Console.WriteLine(line);
            }

            Console.ReadKey(true);
        }
    }
}

using System.IO;
using System.Collections.Generic;

namespace con00
{
    public class Utils
    {
        public static List<string> lst = new List<string>();

        public static void GetDir(string dir)
        {
            string[] files = Directory.GetFiles(dir);
            string[] dirs = Directory.GetDirectories(dir);

            foreach (string d in dirs)
            {
                GetDir(d);
            }

            lst.Add('\n' + dir);
            foreach (string file in files)
            {
                lst.Add(file);
            }
        }
    }
}
