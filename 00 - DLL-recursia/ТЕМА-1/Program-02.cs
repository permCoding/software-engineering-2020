using System;
using CsvHelper;
using System.IO;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;

namespace csvlection
{
    public class Language
    {
        public string Name { get; set; }
        public string Mask { get; set; }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            string nameFile = "Languages.csv";

            //string line = "";

            #region StreamReader
            //StreamReader sr = new StreamReader(nameFile);
            //while ( (line = sr.ReadLine()) != null )
            //{
            //    Console.WriteLine(line);
            //}
            //sr.Close();
            #endregion

            #region using
            //using (StreamReader sr = new StreamReader(nameFile))
            //{
            //    while ( (line = sr.ReadLine()) != null )
            //    {
            //        Console.WriteLine(line);
            //    }
            //}
            #endregion

            List<Language> lst = new List<Language>();
            #region CsvHelper
            using (StreamReader sr = new StreamReader(nameFile))
            {
                using (CsvReader cr = new CsvReader(sr, CultureInfo.CurrentCulture))
                {
                    //
                    //
                    IEnumerable getEnum = cr.GetRecords<Language>();
                    IEnumerator getIn = getEnum.GetEnumerator();
                    while (getIn.MoveNext())
                    {
                        Language item = (Language)getIn.Current;
                        Console.WriteLine(item.Name);
                        lst.Add(item);
                    }
                }
            }
            #endregion

            #region MyRegion
            using (StreamWriter sw = new StreamWriter('_' + nameFile))
            {
                using (CsvWriter cw = new CsvWriter(sw, CultureInfo.CurrentCulture))
                {
                    cw.Configuration.NewLine = CsvHelper.Configuration.NewLine.LF;
                    cw.WriteHeader<Language>();
                    cw.NextRecord();
                    foreach (var item in lst)
                    {
                        cw.WriteRecord(item);
                        cw.NextRecord();
                    }
                }
            }

            #endregion


            Console.WriteLine("The end...");
            Console.ReadLine();
        }
    }
}
