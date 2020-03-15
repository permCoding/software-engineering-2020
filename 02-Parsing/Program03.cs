using System;
using System.Collections.Generic;
using System.Linq;
using HtmlAgilityPack;

namespace Parser2020
{
    public class Agility
    {
        public string Title { get; } = "Title";
        private HtmlDocument content;

        public Agility(string channel)
        {
            string url = "https://tv.yandex.ru/channel/" + channel;
            content = new HtmlWeb().Load(url);
        }
        public List<string> GetListTime()
        {
            List<string> lst = new List<string>();
            HtmlNodeCollection nodes = content.DocumentNode.SelectNodes("//time");
            foreach (var tag in nodes)
                if (tag.Attributes["class"].Value == "channel-schedule__time")
                    lst.Add(tag.InnerText);
            return lst;
            //return content // перепишем в функциональном стиле вместе
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            string channel = "rossiya-1-31";
            Agility agi = new Agility(channel);
            Console.WriteLine(agi.Title);
            foreach (string time in agi.GetListTime())
                Console.WriteLine(time);

            Console.ReadLine();
        }
    }
}

// var id = html.GetElementbyId("mouse-click"); // можно тег искать по id
// tag.Attributes["id"].Value // можно в теге искать по атрибутам