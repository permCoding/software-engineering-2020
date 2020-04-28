using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ShowSQLView
{
    public partial class FormShowTable : Form
    {
        MySqlCommand cmd;
        MySqlDataReader reader;
        MySqlConnectionStringBuilder csb = new MySqlConnectionStringBuilder
        {
            Server = "remotemysql.com", // хостинг БД
            Database = "H9ACFDuK8o", // Имя БД
            UserID = "H9ACFDuK8o", // Имя пользователя БД
            Password = "mhc8632ADa", // Пароль пользователя БД
            CharacterSet = "utf8" // Кодировка Базы Данных
        };

        public FormShowTable()
        {
            InitializeComponent();
        }

        private void BtnTest_Click(object sender, EventArgs e)
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

        private DataTable GetData()
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(csb.ConnectionString))
                {
                    string query = "Select nameSmart, timeSmart, powerSmart from Smartphones";
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

        private void BtnGetData_Click(object sender, EventArgs e)
        {
            dataGridViewSmart.DataSource = GetData();
        }

        private async void BtnGetAsync_Click(object sender, EventArgs e)
        {
            dataGridViewSmart.DataSource = await Task.Run(() => GetData());
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            dataGridViewSmart.DataSource = null;
        }
    }
}
