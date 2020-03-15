using System;
using System.IO;
using System.Net;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace Parser2020
{
    public class Parser
    {
        public static string GetHtmlAsString(string url)
        {
            //return new WebClient().DownloadString(url); // просто загрузка страницы
            using (WebClient wc = new WebClient()) // используем ограничитель видимости
            {
                //string str = wc.DownloadString(url);
                string str = Encoding.UTF8.GetString(wc.DownloadData(url)); // уточняем кодировку страницы
                //string str = Encoding.ASCII.GetString(wc.DownloadData(url));
                return str;
            }
        }

        public static void SaveFileToDisk(string url_file)
        {   // загружаем один файл в текущую папку
            new WebClient().DownloadFile(url_file, Path.GetFileName(url_file));
        }

        public static void SaveFileToDisk(string url_file, string path)
        {   // загружаем в указанную папку
            new WebClient().DownloadFile(url_file, path + Path.GetFileName(url_file));
        }

        public static List<String> getListFilesExample()
        {
            List<String> listFiles = new List<string> { // пример списка ссылок на файлы для загрузки
                "https://pcoding.ru/ref/192.txt",
                "https://harmony.perm.ru/prices/!Retail_website.xls",
                "https://pgsha.ru/export/sites/default/.content/images/pgtau_logo.png"
            };
            return listFiles;
        }

        public static List<String> getListFilesRegEx(string content)
        {
            List<String> listFiles = new List<string>(); // список ссылок на файлы для загрузки

            string mask = @"(?<=a href=)https://pcoding.ru/ref/.*?\d{3}\.txt(?=\starget=_blank)";
            Regex regex = new Regex(mask);
            MatchCollection matches = regex.Matches(content);
            
            //foreach (Match match in matches) listFiles.Add(match.Value); // вариант заполнения foreach
            listFiles = matches.Cast<Match>().Select(item => item.Value).ToList();

            return listFiles;
        }

        public static List<String> getListFilesWhile(string content, string query)
        {
            List<String> listFiles = new List<string>(); // список ссылок на файлы для загрузки
            // "<a href=https://pcoding.ru/ref/170.txt target=_blank>"
            Dictionary<string, string[]> queries = new Dictionary<string, string[]>
            {
                {"ref", new string[] {"<a href=https://pcoding.ru/ref/", " target=_blank>" } },
                {"pdf", new string[] {"<a href=https://pcoding.ru/pdf/", " target=_blank>" } }
            };
            int pos = 0, posLeft = 0;
            string[] limits = queries[query];
            while (content.IndexOf(limits[0], pos) >= 0)
            {
                posLeft = content.IndexOf(limits[0], pos) + limits[0].Length;
                pos = content.IndexOf(limits[1], posLeft);
                listFiles.Add(content.Substring(posLeft, pos- posLeft));
            }
            return listFiles;
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            string url = "https://pcoding.ru/darkNet.php";

            #region GetHtmlAsString and SaveToDisk
            string content = Parser.GetHtmlAsString(url);
            //string fileName = Path.GetFileName(url); // GetExtension(url);
            //File.WriteAllText(fileName, content, Encoding.GetEncoding("UTF-8"));
            #endregion

            #region SaveListFilesToDisk
            //var listFiles = Parser.getListFilesExample();
            //var listFiles = Parser.getListFilesRegEx(content);
            var listFiles = Parser.getListFilesWhile(content, "pdf"); // получает только список имён файлов
                        // задача: доделать так, чтобы возвращался список ссылок на файлы
            
            // сохраняем в тукущую папку
            //foreach (var item in listFiles) Parser.SaveFileToDisk(item); // немного файлов
            //listFiles.AsParallel().ForAll(item => Parser.SaveFileToDisk(item)); // много файлов
            // сохраняем в указанную папку
            //string directory = "saving";
            //string path = Directory.GetCurrentDirectory() + "/" + directory + "/";
            //Directory.CreateDirectory(path);
            //listFiles.AsParallel().ForAll(item => Parser.SaveFileToDisk(item, path));
            #endregion

        }
    }
}

