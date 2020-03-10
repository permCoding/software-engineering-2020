using System;
using CsvHelper;
using System.IO;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace csv
{
    public class Language
    {
        public string Name { get; set; }
        public string Mask { get; set; }
    }

    class Program
    {
        public static List<Language> GetList(string nameFile)
        {
            List<Language> lst = new List<Language>();
            using (StreamReader sr = new StreamReader(nameFile))
            {
                using (CsvReader cr = new CsvReader(sr, CultureInfo.CurrentCulture))
                {
                    //lst = cr.GetRecords<Language>().ToList(); // добавить сразу всё

                    // или добавить по записям с фильтрами, сортировкой, преобразованиями
                    // версия 1 - в функциональном стиле
                    lst = cr
                        .GetRecords<Language>()
                        .Where(item => item.Name[0].ToString().ToLower() == "p")
                        .OrderBy(item => item.Name)
                        .ToList();
                    lst
                       .ForEach(item => item.Mask = item.Mask.Substring(1));
                }
            }
            return lst;
        }

        private static void writeList(List<Language> lst, string nameFile)
        {
            using (StreamWriter sw = new StreamWriter('_' + nameFile))
            {
                using (CsvWriter cw = new CsvWriter(sw, CultureInfo.CurrentCulture))
                {
                    cw.Configuration.NewLine = CsvHelper.Configuration.NewLine.LF;
                    cw.WriteHeader<Language>();
                    cw.NextRecord();
                    foreach (var item in lst)
                    {
                        Console.WriteLine($"Name: {item.Name}; Mask: {item.Mask}");
                        cw.WriteRecord(item);
                        cw.NextRecord();
                    }
                }
            }
        }

        public static void Main(string[] args)
        {
            string nameFile = "Languages.csv";
            List<Language> lst = GetList(nameFile);
            writeList(lst, nameFile);
            Console.WriteLine("The end...");
            Console.ReadLine();
        }
    }
}