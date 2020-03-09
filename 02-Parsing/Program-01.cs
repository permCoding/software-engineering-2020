using System;
using System.IO;
using System.Net;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace requests
{
    class MainClass
    {
        public static void PrintHtmlAsString(string url)
        {
            using (WebClient wc = new WebClient())
            {
                string str = wc.DownloadString(url);
                //string str = Encoding.UTF8.GetString(wc.DownloadData(url));
                //string str = Encoding.ASCII.GetString(wc.DownloadData(url));
                Console.WriteLine(str);
            }
        }
        public static void SaveHtmlToDisk(string url)
        {
            using (WebClient wc = new WebClient())
            {
                string str = wc.DownloadString(url);
                string fileName = Path.GetFileName(url);
                //string fileName = Path.GetFileNameWithoutExtension(url);
                //string ext = Path.GetExtension(url);
                File.WriteAllText(fileName, str, Encoding.GetEncoding("UTF-8")); // (1251));
            }
        }
        public static void SaveFileToDisk(string url)
        {
            using (WebClient wc = new WebClient())
            {
                wc.DownloadFile(url, Path.GetFileName(url));
            }
        }
        public static void SaveFileToDisk(string url, string path)
        {
            using (WebClient wc = new WebClient())
            {
                wc.DownloadFile(url, path + Path.GetFileName(url));
            }
        }
        public static List<String> getListFiles()
        {
            List<String> listFiles = new List<string> {
                "https://pcoding.ru/ref/192.txt",
                "https://harmony.perm.ru/prices/!Comp_price.xls",
                "https://pgsha.ru/export/sites/default/.content/images/pgtau_logo.png"
            };
            return listFiles;
        }
        private static string GetHtmlAsString(string url)
        {
            return new WebClient().DownloadString(url);
        }
        private static void SaveFilesToDirectory(string content, string directory)
        {
            string path = Directory.GetCurrentDirectory() + "/" + directory + "/";
            Directory.CreateDirectory(path);

            string mask = @"(?<=a href=)https://pcoding.ru/ref/.*?\d{3}\.txt(?=\starget=_blank)";
            Regex regex = new Regex(mask);
            MatchCollection matches = regex.Matches(content);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    Console.WriteLine(match.Value);
                    SaveFileToDisk(match.Value, path);
                }
            }
            else
            {
                Console.WriteLine("Совпадений не найдено");
            }
        }


        public static void Main(string[] args)
        {
            string url = "https://pcoding.ru/darkNet.php";

            //PrintHtmlAsString(url);
            //SaveHtmlToDisk(url);

            //foreach (var item in getListFiles()) SaveFileToDisk(item);

            string content = GetHtmlAsString(url);
            string directory = "saving";
            SaveFilesToDirectory(content, directory);
        }
    }
}