using System.Collections.Generic;
using System.IO;

namespace recur_dir
{
    public class RecUtils
    {
        public static List<string> lst = new List<string>();

        public static void GetAllFiles(string dir)
        {
            foreach (string file in Directory.GetFiles(dir))
            {
                lst.Add(file);
            }
            foreach (string d in Directory.GetDirectories(dir))
            {
                GetAllFiles(d); // тут рекурсивный вызов
            }
        }
    }
}
