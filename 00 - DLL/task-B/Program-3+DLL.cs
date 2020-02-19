using System;
using Utils; // подключаем нашу DLL

namespace con00
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string dir = AppDomain.CurrentDomain.BaseDirectory;

            //Utils.GetDir(dir);
            //foreach (string line in Utils.lst)
            //{
            //    Console.WriteLine(line);
            //}

            foreach (string line in Worker.GetDir(dir))
            {
                Console.WriteLine(line);
            }

            Console.ReadKey(true);
        }
    }
}

// это DLL
using System.Collections.Generic;
using System.IO;

namespace Utils
{
    public class Worker
    {
        private static List<string> lst = new List<string>();

        public static void DirToList(string dir)
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

        public static List<string> GetDir(string dir)
        {
            DirToList(dir);
            return lst;
        }
    }
}
