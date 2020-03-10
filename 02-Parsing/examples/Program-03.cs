using System;
using System.IO;
using System.Net;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace headers
{
    class Program
    {
        public static void PrintHtmlAsString(string url)
        {
            using (WebClient wc = new WebClient())
            {
                //string str = wc.DownloadString(url);
                string str = Encoding.UTF8.GetString(wc.DownloadData(url)); // прочитать в правильной кодировке
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
                //File.WriteAllText(fileName, str, Encoding.GetEncoding("UTF-8")); // сохранить под линукс
                File.WriteAllText(fileName, str, Encoding.GetEncoding("windows-1251")); // сохранить под винду
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
            //return new WebClient().DownloadString(url);
            return Encoding.UTF8.GetString(new WebClient().DownloadData(url)); // прочитать в правильной кодировке
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
        private static List<string> GetListFormTagTime(string content, string[] Tags)
        {
            List<string> lst = new List<string>();
            string mask = @"\d{2}:\d{2}";
            Regex regex = new Regex(mask);
            MatchCollection matches = regex.Matches(content);
            foreach (Match match in matches)
            {
                lst.Add(match.Value);
            }
            return lst;
        }
        private static List<string> GetListFormTag(string content, string[] tags)
        {
            List<string> lst = new List<string>();
            string mask = $@"(?<={tags[0]}).*?(?={tags[1]})";
            Regex regex = new Regex(mask);
            MatchCollection matches = regex.Matches(content);
            foreach (Match match in matches)
            {
                lst.Add(match.Value.Replace("&quot;", @""""));
            }
            return lst;
        }

        public static void Main(string[] args)
        {
            string url = "https://pcoding.ru/darkNet.php";

            //PrintHtmlAsString(url);
            //SaveHtmlToDisk(url);

            //foreach (var item in getListFiles()) SaveFileToDisk(item);
            url = "https://tv.yandex.ru/50/channel/rossiya-1-31";
            //PrintHtmlAsString(url);
            //SaveHtmlToDisk(url);
            //Console.ReadLine();


            string content = GetHtmlAsString(url);
            //string directory = "saving";
            //SaveFilesToDirectory(content, directory);

            //var lst = GetListFormTagTime(content, new string[] { "", "" });
            //Console.WriteLine(String.Join("\n", lst));
            var lst1 = GetListFormTag(content, 
                new string[] { @"<time class=""channel-schedule__time"">", @"</time>" });
            var lst2 = GetListFormTag(content,
                new string[] { @"<span class=""channel-schedule__text"">", @"</span>" });
            //Console.WriteLine(String.Join("\n", lst2));
            var result = lst1.Zip(lst2,
                    (time, name) => new { Time = time, Name = name }
                );
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Time}\t{item.Name}");
            }
            Console.ReadLine();

        }
    }
}
// <li class="channel-schedule__event">
// <time class="channel-schedule__time">18:30</time>
// <span class="channel-schedule__text">Андрей Малахов. Прямой эфир.</span>
// </li>
// &quot;