using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using HtmlAgilityPack;

namespace Parser2020
{
    public class TVRecord
    {
        public string Name { set; get; }
        public string Time { set; get; }
    }

    public class Agility
    {
        public string Title { get; } = "Title";
        private HtmlDocument content;

        public Agility(string channel)
        {
            string url = "https://tv.yandex.ru/channel/" + channel;
            content = new HtmlWeb().Load(url);
        }

        public List<TVRecord> GetShedule()
        {
            var rows_name = content.DocumentNode.SelectNodes("//span[@class='channel-schedule__text']");
            var rows_time = content.DocumentNode.SelectNodes("//time[@class='channel-schedule__time']");

            var names = rows_name.Select(item => item.InnerText.Replace("&quot;", @""""));
            var times = rows_time.Select(item => item.InnerText);

            var records = names
                .Zip(times, (name, time) => new TVRecord() { Name = name, Time = time })
                .ToList();

            return records;
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            string channel = "rossiya-1-31";
            Agility agi = new Agility(channel);

            foreach (var item in agi.GetShedule())
            {
                Console.WriteLine($"{item.Time}\t{item.Name}");
            }

            Console.ReadLine();
        }
    }
}
