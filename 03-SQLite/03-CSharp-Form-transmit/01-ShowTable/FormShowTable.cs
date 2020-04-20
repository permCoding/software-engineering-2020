using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace ShowSQLView
{
    public partial class FormShowTable : Form
    {
        SQLiteConnection conn;
        SQLiteCommand cmd;
        SQLiteDataReader reader;
        DataTable dt;

        public FormShowTable()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            conn = new SQLiteConnection("Data Source=Pareto.db");

            string query = "Select nameSmart, time, power from Smartphones";
            cmd = new SQLiteCommand(query, conn);

            dt = new DataTable();
            dataGridViewSmart.DataSource = dt;

            conn.Open();
            reader = cmd.ExecuteReader();
            dt.Clear();
            dt.Load(reader);

            conn.Close();
        }
    }
}
