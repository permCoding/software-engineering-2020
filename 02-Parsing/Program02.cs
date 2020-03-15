using System;
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

            // можно взять тег title из блока head
            //Title = content.DocumentNode.SelectSingleNode("//title").InnerText; // .InnerHtml

            // лучше взять текст из тега <h1 class="channel-header__text">Россия 1</h1> по имени класса напрямую
            //Title = content.DocumentNode.SelectSingleNode("//h1[@class='channel-header__text']").InnerText;

            // или взять больший блок (внешний тег) и поискать во внутренних
            var nodeTitle = content.DocumentNode.SelectSingleNode("//div[@class='channel-header__title']");
            // обычным циклом
            //if (nodeTitle != null)
            //    foreach (var tag in nodeTitle.ChildNodes)
            //        if (tag.Name == "h1")
            //            Title = tag.InnerText;
            // или в функциональном стиле
            Title = nodeTitle
                .ChildNodes
                .Where(tag => tag.Name == "h1")
                .ToList()[0]
                .InnerText;
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            string channel = "rossiya-1-31";
            Agility agi = new Agility(channel);
            Console.WriteLine(agi.Title);

            Console.ReadLine();
        }
    }
}