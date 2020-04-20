namespace ChartRandom
{
    partial class FormChartRandom
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.chartRandom = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartRandom)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Location = new System.Drawing.Point(12, 12);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(525, 99);
            this.BtnGenerate.TabIndex = 0;
            this.BtnGenerate.Text = "Random Generate";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(13, 500);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(524, 94);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "Save Result";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // chartRandom
            // 
            this.chartRandom.BackColor = System.Drawing.SystemColors.MenuBar;
            chartArea1.Name = "ChartArea1";
            this.chartRandom.ChartAreas.Add(chartArea1);
            this.chartRandom.Location = new System.Drawing.Point(13, 117);
            this.chartRandom.Name = "chartRandom";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series1.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            series1.MarkerSize = 7;
            series1.Name = "Series1";
            this.chartRandom.Series.Add(series1);
            this.chartRandom.Size = new System.Drawing.Size(524, 377);
            this.chartRandom.TabIndex = 3;
            this.chartRandom.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Pareto";
            this.chartRandom.Titles.Add(title1);
            // 
            // FormChartRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 606);
            this.Controls.Add(this.chartRandom);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnGenerate);
            this.Name = "FormChartRandom";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chartRandom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGenerate;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRandom;
    }
}

