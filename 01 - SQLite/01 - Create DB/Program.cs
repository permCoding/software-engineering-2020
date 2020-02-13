using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using Worker = sqlite_02.UtilsSQLiteCreate;

namespace sqlite_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker.NameFileDB = "db-02.db";
            Worker.RefreshTable();

            for (int i = 0; i < 5; i++)
            {
                // тут используются необязательные параметры метода
                Worker.tableInsertRandomRecodrd(); 
            }

            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                double power = rnd.Next(80, 490) / 10.0; // пишем 0.0
                int price = rnd.Next(8, 90 + 1) * 1000;
                Worker.tableInsertRandomRecodrd(power, price);
            }

            Worker.printTable();

            Console.ReadLine();
        }
    }
}
