namespace TIckets
{
    partial class UserMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userMainFormGridView = new System.Windows.Forms.DataGridView();
            this.userMainFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.новаяЗаявкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выгрузкаВExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.моиЗаявкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменаПароляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходИзСистемыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.userMainFormGridView)).BeginInit();
            this.userMainFormMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // userMainFormGridView
            // 
            this.userMainFormGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userMainFormGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userMainFormGridView.Location = new System.Drawing.Point(12, 27);
            this.userMainFormGridView.Name = "userMainFormGridView";
            this.userMainFormGridView.Size = new System.Drawing.Size(776, 411);
            this.userMainFormGridView.TabIndex = 0;
            // 
            // userMainFormMenuStrip
            // 
            this.userMainFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.новаяЗаявкаToolStripMenuItem,
            this.моиЗаявкиToolStripMenuItem,
            this.выгрузкаВExcelToolStripMenuItem});
            this.userMainFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.userMainFormMenuStrip.Name = "userMainFormMenuStrip";
            this.userMainFormMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.userMainFormMenuStrip.TabIndex = 1;
            this.userMainFormMenuStrip.Text = "menuStrip1";
            // 
            // новаяЗаявкаToolStripMenuItem
            // 
            this.новаяЗаявкаToolStripMenuItem.Name = "новаяЗаявкаToolStripMenuItem";
            this.новаяЗаявкаToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.новаяЗаявкаToolStripMenuItem.Text = "Новая заявка";
            this.новаяЗаявкаToolStripMenuItem.Click += new System.EventHandler(this.новаяЗаявкаToolStripMenuItem_Click);
            // 
            // выгрузкаВExcelToolStripMenuItem
            // 
            this.выгрузкаВExcelToolStripMenuItem.Name = "выгрузкаВExcelToolStripMenuItem";
            this.выгрузкаВExcelToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.выгрузкаВExcelToolStripMenuItem.Text = "Выгрузка в Excel";
            this.выгрузкаВExcelToolStripMenuItem.Click += new System.EventHandler(this.выгрузкаВExcelToolStripMenuItem_Click);
            // 
            // моиЗаявкиToolStripMenuItem
            // 
            this.моиЗаявкиToolStripMenuItem.Name = "моиЗаявкиToolStripMenuItem";
            this.моиЗаявкиToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.моиЗаявкиToolStripMenuItem.Text = "Мои заявки";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сменаПароляToolStripMenuItem,
            this.выходИзСистемыToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // сменаПароляToolStripMenuItem
            // 
            this.сменаПароляToolStripMenuItem.Name = "сменаПароляToolStripMenuItem";
            this.сменаПароляToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сменаПароляToolStripMenuItem.Text = "Смена пароля";
            this.сменаПароляToolStripMenuItem.Click += new System.EventHandler(this.сменаПароляToolStripMenuItem_Click);
            // 
            // выходИзСистемыToolStripMenuItem
            // 
            this.выходИзСистемыToolStripMenuItem.Name = "выходИзСистемыToolStripMenuItem";
            this.выходИзСистемыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходИзСистемыToolStripMenuItem.Text = "Выход из системы";
            this.выходИзСистемыToolStripMenuItem.Click += new System.EventHandler(this.выходИзСистемыToolStripMenuItem_Click);
            // 
            // UserMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userMainFormGridView);
            this.Controls.Add(this.userMainFormMenuStrip);
            this.MainMenuStrip = this.userMainFormMenuStrip;
            this.Name = "UserMainForm";
            this.Text = "Пользователь";
            ((System.ComponentModel.ISupportInitialize)(this.userMainFormGridView)).EndInit();
            this.userMainFormMenuStrip.ResumeLayout(false);
            this.userMainFormMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView userMainFormGridView;
        private System.Windows.Forms.MenuStrip userMainFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem новаяЗаявкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменаПароляToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходИзСистемыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem моиЗаявкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выгрузкаВExcelToolStripMenuItem;
    }
}