using System;
using CsvHelper;
using System.IO;
using System.Globalization;
using System.Collections;

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

            string line = "";

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
                        Console.WriteLine(((Language)getIn.Current).Name);
                    }
                }
            }
            #endregion

            Console.WriteLine("Hello World!");
        }
    }
}
