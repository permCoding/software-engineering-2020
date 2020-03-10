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
        private static string GetHtmlAsString(string url)
        {
            //return new WebClient().DownloadString(url);
            return Encoding.UTF8.GetString(new WebClient().DownloadData(url)); // прочитать в правильной кодировке
        }
        private static List<string> GetListFormTagTime(string content, string[] Tags)
        {
            string mask = @"\d{2}:\d{2}";
            Regex regex = new Regex(mask);
            MatchCollection matches = regex.Matches(content);
            List<string> lst = new List<string>();
            foreach (Match match in matches) lst.Add(match.Value);
            return lst;
        }
        private static List<string> GetListFormTag(string content, string[] tags)
        {
            string mask = $@"(?<={tags[0]}).*?(?={tags[1]})";
            Regex regex = new Regex(mask);
            MatchCollection matches = regex.Matches(content);
            List<string> lst = new List<string>();
            foreach (Match match in matches) lst.Add(match.Value.Replace("&quot;", @""""));
            return lst;
        }
        
        public static void Main(string[] args)
        {
            string url = "https://tv.yandex.ru/50/channel/rossiya-1-31";
            string content = GetHtmlAsString(url);
            //var lst = GetListFormTagTime(content, new string[] { "", "" });
            //Console.WriteLine(String.Join("\n", lst));
            var lst1 = GetListFormTag(content, 
                new string[] { @"<time class=""channel-schedule__time"">", @"</time>" });
            var lst2 = GetListFormTag(content,
                new string[] { @"<span class=""channel-schedule__text"">", @"</span>" });
            var lstRecord = lst1.Zip(lst2,
                    (time, name) => new { Time = time, Name = name }
                );
            //string result = "";
            //foreach (var item in lstRecord)
            //    result += $"{item.Time}\t{item.Name}" + Environment.NewLine;
            string result = String.Join("\n", lstRecord.Select(item => $"{item.Time}\t{item.Name}"));
            Console.WriteLine(result);
            File.WriteAllText("result.txt", result, Encoding.GetEncoding("windows-1251"));

            Console.ReadLine();
        }
    }
}