using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using HtmlAgilityPack;

namespace Parser2020
{
    public class Agility
    {
        public string Title { get; } = "Title";
        private HtmlDocument content;
        private string prefix = "https://tv.yandex.ru";

        public Agility(string channel)
        {
            string url = "https://tv.yandex.ru/channel/" + channel;
            content = new HtmlWeb().Load(url);
        }

        //< a class="link channel-schedule__link" href="/program/akula-789564?eventId=153027799"></a>
        public List<string> GetRefsOnProgram()
        {
            HtmlNodeCollection nodes = content.DocumentNode.SelectNodes("//a");
            List<string> refs = new List<string>();
            foreach (var tag in nodes)
            {
                if (tag.Attributes["class"].Value == "link channel-schedule__link")
                {
                    Console.WriteLine(prefix + tag.Attributes["href"].Value); // просто для контроля
                    refs.Add(prefix + tag.Attributes["href"].Value);
                }
            }
            return refs;
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            string channel = "rossiya-1-31";
            Agility agi = new Agility(channel);

            File.WriteAllText(
                "refs.txt", 
                String.Join(Environment.NewLine, agi.GetRefsOnProgram()), 
                Encoding.GetEncoding("windows-1251")
            );

            Console.ReadLine();
        }
    }
}