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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShowTable));
            this.BtnGetData = new System.Windows.Forms.Button();
            this.dataGridViewSmart = new System.Windows.Forms.DataGridView();
            this.BtnTest = new System.Windows.Forms.Button();
            this.BtnGetAsync = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSmart)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGetData
            // 
            this.BtnGetData.Location = new System.Drawing.Point(198, 12);
            this.BtnGetData.Name = "BtnGetData";
            this.BtnGetData.Size = new System.Drawing.Size(176, 63);
            this.BtnGetData.TabIndex = 0;
            this.BtnGetData.Text = "get result from query";
            this.BtnGetData.UseVisualStyleBackColor = true;
            this.BtnGetData.Click += new System.EventHandler(this.BtnGetData_Click);
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
            // BtnTest
            // 
            this.BtnTest.Location = new System.Drawing.Point(12, 12);
            this.BtnTest.Name = "BtnTest";
            this.BtnTest.Size = new System.Drawing.Size(176, 63);
            this.BtnTest.TabIndex = 2;
            this.BtnTest.Text = "test connection";
            this.BtnTest.UseVisualStyleBackColor = true;
            this.BtnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // BtnGetAsync
            // 
            this.BtnGetAsync.Location = new System.Drawing.Point(385, 12);
            this.BtnGetAsync.Name = "BtnGetAsync";
            this.BtnGetAsync.Size = new System.Drawing.Size(176, 63);
            this.BtnGetAsync.TabIndex = 0;
            this.BtnGetAsync.Text = "get ASYNC result";
            this.BtnGetAsync.UseVisualStyleBackColor = true;
            this.BtnGetAsync.Click += new System.EventHandler(this.BtnGetAsync_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(457, 439);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(106, 46);
            this.BtnReset.TabIndex = 3;
            this.BtnReset.Text = "Reset Data";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // FormShowTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 497);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnTest);
            this.Controls.Add(this.dataGridViewSmart);
            this.Controls.Add(this.BtnGetAsync);
            this.Controls.Add(this.BtnGetData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormShowTable";
            this.Text = "Как отобразить результаты запроса";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSmart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGetData;
        private System.Windows.Forms.DataGridView dataGridViewSmart;
        private System.Windows.Forms.Button BtnTest;
        private System.Windows.Forms.Button BtnGetAsync;
        private System.Windows.Forms.Button BtnReset;
    }
}

