namespace ShowSQLView
{
    partial class FormShowTable
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
            this.btn = new System.Windows.Forms.Button();
            this.dataGridViewSmart = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSmart)).BeginInit();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(12, 12);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(551, 63);
            this.btn.TabIndex = 0;
            this.btn.Text = "get result from query";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // dataGridViewSmart
            // 
            this.dataGridViewSmart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSmart.Location = new System.Drawing.Point(12, 81);
            this.dataGridViewSmart.Name = "dataGridViewSmart";
            this.dataGridViewSmart.RowTemplate.Height = 24;
            this.dataGridViewSmart.Size = new System.Drawing.Size(551, 404);
            this.dataGridViewSmart.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 497);
            this.Controls.Add(this.dataGridViewSmart);
            this.Controls.Add(this.btn);
            this.Name = "Form1";
            this.Text = "Как отобразить результаты запроса";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSmart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.DataGridView dataGridViewSmart;
    }
}

