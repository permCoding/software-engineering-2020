using System;
using System.IO;
using System.Collections.Generic;

namespace recurs_files
{
    public static class UtilsFiles
    {
        public static List<string> lst = new List<string>();

        public static void GetAllFiles(string dir)
        {
            foreach(var item in Directory.GetFiles(dir))
            {
                lst.Add(item);
            }
            foreach (var item in Directory.GetDirectories(dir))
            {
                GetAllFiles(item);
            }
        }
    }
    class MainClass
    {
        public static void Main()
        {
            string cur_dir = AppDomain.CurrentDomain.BaseDirectory;
            UtilsFiles.GetAllFiles(cur_dir);
            foreach (var item in UtilsFiles.lst)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey(true);
        }
    }
}
