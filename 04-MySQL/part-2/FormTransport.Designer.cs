namespace Metro_Example
{
    partial class FormTransport
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
            this.components = new System.ComponentModel.Container();
            this.metroSM = new MetroFramework.Components.MetroStyleManager(this.components);
            this.MBtnGet = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroRadioButton4 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton3 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.DGView = new System.Windows.Forms.DataGridView();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.MenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ItemCheckConnection = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.metroSM)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGView)).BeginInit();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroSM
            // 
            this.metroSM.Owner = null;
            // 
            // MBtnGet
            // 
            this.MBtnGet.Location = new System.Drawing.Point(41, 77);
            this.MBtnGet.Name = "MBtnGet";
            this.MBtnGet.Size = new System.Drawing.Size(233, 78);
            this.MBtnGet.TabIndex = 0;
            this.MBtnGet.Text = "Получить данные";
            this.MBtnGet.Click += new System.EventHandler(this.MBtnGet_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroRadioButton4);
            this.metroPanel1.Controls.Add(this.metroRadioButton3);
            this.metroPanel1.Controls.Add(this.metroRadioButton2);
            this.metroPanel1.Controls.Add(this.metroRadioButton1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(41, 183);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(233, 180);
            this.metroPanel1.TabIndex = 8;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroRadioButton4
            // 
            this.metroRadioButton4.AutoSize = true;
            this.metroRadioButton4.Location = new System.Drawing.Point(46, 136);
            this.metroRadioButton4.Name = "metroRadioButton4";
            this.metroRadioButton4.Size = new System.Drawing.Size(83, 17);
            this.metroRadioButton4.TabIndex = 11;
            this.metroRadioButton4.Text = "Динамика";
            this.metroRadioButton4.UseVisualStyleBackColor = true;
            // 
            // metroRadioButton3
            // 
            this.metroRadioButton3.AutoSize = true;
            this.metroRadioButton3.Location = new System.Drawing.Point(46, 99);
            this.metroRadioButton3.Name = "metroRadioButton3";
            this.metroRadioButton3.Size = new System.Drawing.Size(78, 17);
            this.metroRadioButton3.TabIndex = 10;
            this.metroRadioButton3.Text = "Рекурсия";
            this.metroRadioButton3.UseVisualStyleBackColor = true;
            // 
            // metroRadioButton2
            // 
            this.metroRadioButton2.AutoSize = true;
            this.metroRadioButton2.Location = new System.Drawing.Point(46, 62);
            this.metroRadioButton2.Name = "metroRadioButton2";
            this.metroRadioButton2.Size = new System.Drawing.Size(122, 17);
            this.metroRadioButton2.TabIndex = 9;
            this.metroRadioButton2.Text = "Бинарные маски";
            this.metroRadioButton2.UseVisualStyleBackColor = true;
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.Checked = true;
            this.metroRadioButton1.Location = new System.Drawing.Point(46, 25);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(132, 17);
            this.metroRadioButton1.TabIndex = 8;
            this.metroRadioButton1.TabStop = true;
            this.metroRadioButton1.Text = "Жадный алгоритм";
            this.metroRadioButton1.UseVisualStyleBackColor = true;
            // 
            // DGView
            // 
            this.DGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGView.Location = new System.Drawing.Point(294, 77);
            this.DGView.Name = "DGView";
            this.DGView.RowHeadersWidth = 51;
            this.DGView.RowTemplate.Height = 24;
            this.DGView.Size = new System.Drawing.Size(529, 404);
            this.DGView.TabIndex = 9;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(41, 379);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(233, 102);
            this.metroButton2.TabIndex = 10;
            this.metroButton2.Text = "Найти решение";
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemCheckConnection});
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(297, 56);
            // 
            // ItemCheckConnection
            // 
            this.ItemCheckConnection.Name = "ItemCheckConnection";
            this.ItemCheckConnection.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F1)));
            this.ItemCheckConnection.Size = new System.Drawing.Size(296, 24);
            this.ItemCheckConnection.Text = "Проверить соединение";
            this.ItemCheckConnection.Click += new System.EventHandler(this.ItemCheckConnection_Click);
            // 
            // FormTransport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 504);
            this.ContextMenuStrip = this.MenuStrip;
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.DGView);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.MBtnGet);
            this.Name = "FormTransport";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Optimal Solution";
            ((System.ComponentModel.ISupportInitialize)(this.metroSM)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGView)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroSM;
        private MetroFramework.Controls.MetroButton MBtnGet;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton4;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton3;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private System.Windows.Forms.DataGridView DGView;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.ContextMenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ItemCheckConnection;
    }
}

