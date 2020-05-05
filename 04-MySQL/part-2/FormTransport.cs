using System;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;

using MetroFramework.Forms;
using MySql.Data.MySqlClient;

namespace Metro_Example
{
    public partial class FormTransport : MetroForm
    {
        MySqlCommand cmd;
        MySqlDataReader reader;
        MySqlConnectionStringBuilder csb = new MySqlConnectionStringBuilder
        {
            Server = "localhost", // хостинг БД
            Database = "transport", // Имя БД
            UserID = "root", // Имя пользователя БД
            Password = "0000", // Пароль пользователя БД
            CharacterSet = "utf8" // Кодировка Базы Данных
        };

        public FormTransport() => InitializeComponent();

        private DataTable GetData()
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(csb.ConnectionString))
                {
                    string query =
                        @"select 
                            cities.name_city, 
                            prices.name_shop, 
                            prices.price, 
                            cities.way
                        from 
                            cities
                        inner join merge on cities.id_city = merge.id_city
                        inner join prices on prices.id_shop = merge.id_shop";
                    cmd = new MySqlCommand(query, conn);
                    conn.Open();
                    reader = cmd.ExecuteReader();
                    dt.Load(reader);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проблемы с подключением к БД \n\r" + ex.ToString());
            }
            return dt;
        }

        private async void MBtnGet_Click(object sender, System.EventArgs e)
        {
            DGView.DataSource = await Task.Run(() => GetData());
        }

        private void CheckConnection()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(csb.ConnectionString))
                {
                    conn.Open();
                    MessageBox.Show("Подключение к БД установлено");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проблемы с подключением к БД \n\r" + ex.ToString());
            }
        }

        private async void ItemCheckConnection_Click(object sender, EventArgs e)
        {
            await Task.Run(() => CheckConnection());
        }
    }
}
