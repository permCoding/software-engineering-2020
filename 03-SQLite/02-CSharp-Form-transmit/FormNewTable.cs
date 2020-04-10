using System;
using System.Windows.Forms;

namespace transmit_form
{
    public partial class FormNewTable : Form
    {
        public FormNewTable()
        {
            InitializeComponent();
        }

        private void BtnCreateTable_Click(object sender, EventArgs e)
        {
            SQLiteUtils.RefreshTable();
            SQLiteUtils.InsertRecord();
            this.Text = SQLiteUtils.GetCountRecord().ToString();
        }
    }
}
