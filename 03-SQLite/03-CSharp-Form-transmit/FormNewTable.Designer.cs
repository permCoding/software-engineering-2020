namespace transmit_form
{
    partial class FormNewTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewTable));
            this.BtnCreateTable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCreateTable
            // 
            this.BtnCreateTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnCreateTable.Location = new System.Drawing.Point(29, 26);
            this.BtnCreateTable.Name = "BtnCreateTable";
            this.BtnCreateTable.Size = new System.Drawing.Size(421, 108);
            this.BtnCreateTable.TabIndex = 1;
            this.BtnCreateTable.Text = "get_count";
            this.BtnCreateTable.UseVisualStyleBackColor = true;
            this.BtnCreateTable.Click += new System.EventHandler(this.BtnCreateTable_Click);
            // 
            // FormNewTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(488, 173);
            this.Controls.Add(this.BtnCreateTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNewTable";
            this.Text = "check";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnCreateTable;
    }
}

