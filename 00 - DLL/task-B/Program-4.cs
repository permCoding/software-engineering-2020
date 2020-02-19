using System;
using System.IO;

namespace DirTry
{
    class Program
    {
        public static void PrintAllFiles(DirectoryInfo dir)
        {
            FileInfo[] files = null;
            try
            {
                files = dir.GetFiles();
                foreach (var namefile in files)
                {
                    Console.WriteLine(namefile);
                }
                //Console.WriteLine(files.Length);
            }
            catch (DirectoryNotFoundException exD)
            {
                Console.WriteLine(exD.Message);
            }
            catch (UnauthorizedAccessException exU)
            {
                Console.WriteLine(exU.Message);
            }
            catch (NullReferenceException exN)
            {
                Console.WriteLine(exN.Message);
            }
            finally
            {   
                foreach (var dirInfo in dir.GetDirectories())
                {
                    PrintAllFiles(dirInfo);
                }
            }
        }

        static void Main(string[] args)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
            PrintAllFiles(dirInfo);

            /*
            Console.WriteLine("***** Информация о каталоге *****\n");
            Console.WriteLine("Полный путь: {0}\nНазвание папки: {1}\nРодительский каталог: {2}\n" +
                         "Время создания: {3}\nАтрибуты: {4}\nКорневой каталог: {5}",
                         dirInfo.FullName, 
                         dirInfo.Name, 
                         dirInfo.Parent, 
                         dirInfo.CreationTime, 
                         dirInfo.Attributes, 
                         dirInfo.Root);
            */

            Console.ReadKey(true);
        }
    }
}
