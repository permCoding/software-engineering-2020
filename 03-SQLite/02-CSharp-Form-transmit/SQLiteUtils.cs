using System;
using System.IO;
using System.Data.SQLite; // через NuGet установить System.Data.SQLite

namespace transmit_form
{
    public class SQLiteUtils
    {
        public static string NameFileDB { set; get; } = "db.db";
        public static string connectionString = "Data Source=" + NameFileDB + ";";
        public static string QueryCreate = @"CREATE TABLE Smartphones (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                power DOUBLE NOT NULL DEFAULT(0),
                price INTEGER NOT NULL DEFAULT(0)
            );"; // так можно переносить строки в коде
        public static string QueryReset = "DELETE FROM Smartphones";
        public static string QueryInsert = "INSERT INTO Smartphones(power, price) VALUES(10.0, 15000)";
        public static string QuerySelect = "SELECT count(*) FROM Smartphones";

        public static void RefreshTable()
        {
            if (!File.Exists(NameFileDB)) {
                CreateTable();
            }
            else
            {
                ResetTable();
            }
        }

        public static void CreateTable()
        {
            SQLiteConnection.CreateFile(NameFileDB);
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                SQLiteCommand comm = new SQLiteCommand(QueryCreate, conn);
                comm.ExecuteNonQuery();
            };
        }

        public static void ResetTable()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                SQLiteCommand comm = new SQLiteCommand(QueryReset, conn);
                comm.ExecuteNonQuery();
            };
        }

        public static void InsertRecord()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                SQLiteCommand comm = new SQLiteCommand(QueryInsert, conn);
                comm.ExecuteNonQuery();
            }
        }

        public static int GetCountRecord()
        {
            int count = 0;
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                SQLiteCommand comm = new SQLiteCommand(QuerySelect, conn);
                count = Convert.ToInt32(comm.ExecuteScalar());
            }
            return count;
        }
    }
}
