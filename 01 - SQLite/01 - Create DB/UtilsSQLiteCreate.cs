using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqlite_02
{
    public class UtilsSQLiteCreate
    {
        public static string NameFileDB { set; get; } = "db.db";
        public static string queryCreate = @"CREATE TABLE Smartphones (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    power DOUBLE NOT NULL DEFAULT(0),
                    price INTEGER NOT NULL DEFAULT(0)
                );"; // так можно переносить строки в коде
        public static string queryReset = "DELETE FROM Smartphones";

        public static void RefreshTable()
        {
            if (!File.Exists(NameFileDB))
                SQLiteConnection.CreateFile(NameFileDB);

            SQLiteConnection conn = new SQLiteConnection();
            conn.ConnectionString = "Data Source=" + NameFileDB + ";Version=3;";

            try
            {
                conn.Open();
                SQLiteCommand comm = new SQLiteCommand();
                comm.Connection = conn;
                comm.CommandText = queryCreate;
                comm.ExecuteNonQuery();
                Console.WriteLine("Создали новую таблицу");
            }
            catch (SQLiteException ex)
            {
                conn.Close();
                Console.WriteLine("Error: " + ex.Message);
                conn.Open();
                SQLiteCommand comm = new SQLiteCommand(queryReset, conn);
                comm.ExecuteNonQuery();
                conn.Close();
                Console.WriteLine("Очистили существующую таблицу");
            }

            finally
            {
                Console.WriteLine("The end...");
            }
        }

        public static void tableInsertRandomRecodrd(double power = 10.0, int price = 10000, string nameTable = "Smartphones")
        {
            string connString = "Data Source=" + NameFileDB + ";";
            string query = "INSERT INTO Smartphones(power, price) VALUES(" +
                // power.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US")) + "," +
                power.ToString().Replace(',','.') + "," +
                price.ToString() + ");";

            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                try
                {
                    conn.Open();
                    SQLiteCommand comm = new SQLiteCommand(query, conn);
                    comm.ExecuteNonQuery();
                }
                catch (SQLiteException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        public static void printTable(string nameTable = "Smartphones")
        {
            string connString = "Data Source=" + NameFileDB + ";";
            string query = "SELECT * FROM " + nameTable;

            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                try
                {
                    conn.Open();
                    SQLiteCommand comm = new SQLiteCommand(query, conn);
                    SQLiteDataReader reader = comm.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine("{0}\t{1}", reader.GetValue(1), reader.GetValue(2));
                        }
                    }
                }
                catch (SQLiteException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}
