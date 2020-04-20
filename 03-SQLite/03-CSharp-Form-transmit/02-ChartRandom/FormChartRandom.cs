using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChartRandom
{
    public partial class FormChartRandom : Form
    {
        Random rnd = new Random();

        public FormChartRandom()
        {
            InitializeComponent();
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            chartRandom.Series[0].Points.Clear();
            int min = 5, max = 95;
            chartRandom.ChartAreas[0].AxisX.Minimum = 0;
            chartRandom.ChartAreas[0].AxisX.Maximum = max;
            chartRandom.ChartAreas[0].AxisY.Minimum = 0;
            chartRandom.ChartAreas[0].AxisY.Maximum = max;
            for (int i=0; i<15; i++)
                chartRandom.Series[0].Points.AddXY(rnd.Next(min, max), rnd.Next(min, max));
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.InitialDirectory = Environment.CurrentDirectory;
                sfd.Title = "Сохранить изображение как ...";
                sfd.Filter = "*.jpg|*.jpg|*.png|*.png;|*.bmp|*.bmp;";
                sfd.AddExtension = true;
                sfd.FileName = "graphicImage";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    switch (sfd.FilterIndex)
                    {
                        case 1:
                            chartRandom.SaveImage(sfd.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Bmp);
                            break;
                        case 2:
                            chartRandom.SaveImage(sfd.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
                            break;
                        case 3:
                            chartRandom.SaveImage(sfd.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Jpeg);
                            break;
                    }
                }
            }
        }
    }
}
