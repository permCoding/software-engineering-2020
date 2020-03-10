using System;
using System.IO;
using System.Net;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace requests
{
    class MainClass
    {
        private static string GetHtmlAsString(string url)
        {
            //return new WebClient().DownloadString(url);
            using (WebClient wc = new WebClient())
            {
                //string str = wc.DownloadString(url);
                string str = Encoding.UTF8.GetString(wc.DownloadData(url));
                //string str = Encoding.ASCII.GetString(wc.DownloadData(url));
                return str;
            }
        }
        public static void SaveFileToDisk(string url)
        {
            new WebClient().DownloadFile(url, Path.GetFileName(url));
        }
        public static void SaveFileToDisk(string url, string path)
        {
            new WebClient().DownloadFile(url, path + Path.GetFileName(url));
        }
        public static List<String> getListFiles(string content)
        {
            //List<String> listFiles = new List<string> {
            //    "https://pcoding.ru/ref/192.txt",
            //    "https://harmony.perm.ru/prices/!Comp_price.xls",
            //    "https://pgsha.ru/export/sites/default/.content/images/pgtau_logo.png"
            //};
            List<String> listFiles = new List<string>();
            string mask = @"(?<=a href=)https://pcoding.ru/ref/.*?\d{3}\.txt(?=\starget=_blank)";
            Regex regex = new Regex(mask);
            MatchCollection matches = regex.Matches(content);
            foreach (Match match in matches) listFiles.Add(match.Value);
            return listFiles;
        }
        public static void Main(string[] args)
        {
            string url = "https://pcoding.ru/darkNet.php";

            string content = GetHtmlAsString(url);
            string fileName = Path.GetFileName(url); // GetExtension(url);
            File.WriteAllText(fileName, content, Encoding.GetEncoding("UTF-8")); // SaveHtmlToDisk

            foreach (var item in getListFiles(content)) SaveFileToDisk(item);
            //getListFiles(content).AsParallel().ForAll(item => SaveFileToDisk(item));

            string directory = "saving";
            string path = Directory.GetCurrentDirectory() + "/" + directory + "/";
            Directory.CreateDirectory(path);
            getListFiles(content).AsParallel().ForAll(item => SaveFileToDisk(item, path));
        }
    }
}