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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMainForm));
            this.userMainFormGridView = new System.Windows.Forms.DataGridView();
            this.userMainFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменаПароляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходИзСистемыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новаяЗаявкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.моиЗаявкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всеЗаявкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.принятыеВРаботуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отмененныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выполненныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переоткрытыеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отклоненныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выгрузкаВExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.userMainFormGridView)).BeginInit();
            this.userMainFormMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // userMainFormGridView
            // 
            this.userMainFormGridView.AllowUserToAddRows = false;
            this.userMainFormGridView.AllowUserToDeleteRows = false;
            this.userMainFormGridView.AllowUserToResizeColumns = false;
            this.userMainFormGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.userMainFormGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.userMainFormGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userMainFormGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.userMainFormGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userMainFormGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userMainFormGridView.Location = new System.Drawing.Point(0, 24);
            this.userMainFormGridView.Name = "userMainFormGridView";
            this.userMainFormGridView.ReadOnly = true;
            this.userMainFormGridView.Size = new System.Drawing.Size(1249, 426);
            this.userMainFormGridView.TabIndex = 0;
            this.userMainFormGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.userMainFormGridView_CellMouseDoubleClick);
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
            this.userMainFormMenuStrip.Size = new System.Drawing.Size(1249, 24);
            this.userMainFormMenuStrip.TabIndex = 1;
            this.userMainFormMenuStrip.Text = "menuStrip1";
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
            this.сменаПароляToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сменаПароляToolStripMenuItem.Image")));
            this.сменаПароляToolStripMenuItem.Name = "сменаПароляToolStripMenuItem";
            this.сменаПароляToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сменаПароляToolStripMenuItem.Text = "Смена пароля";
            this.сменаПароляToolStripMenuItem.Click += new System.EventHandler(this.сменаПароляToolStripMenuItem_Click);
            // 
            // выходИзСистемыToolStripMenuItem
            // 
            this.выходИзСистемыToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("выходИзСистемыToolStripMenuItem.Image")));
            this.выходИзСистемыToolStripMenuItem.Name = "выходИзСистемыToolStripMenuItem";
            this.выходИзСистемыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходИзСистемыToolStripMenuItem.Text = "Выход из системы";
            this.выходИзСистемыToolStripMenuItem.Click += new System.EventHandler(this.выходИзСистемыToolStripMenuItem_Click);
            // 
            // новаяЗаявкаToolStripMenuItem
            // 
            this.новаяЗаявкаToolStripMenuItem.Name = "новаяЗаявкаToolStripMenuItem";
            this.новаяЗаявкаToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.новаяЗаявкаToolStripMenuItem.Text = "Новая заявка";
            this.новаяЗаявкаToolStripMenuItem.Click += new System.EventHandler(this.новаяЗаявкаToolStripMenuItem_Click);
            // 
            // моиЗаявкиToolStripMenuItem
            // 
            this.моиЗаявкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.всеЗаявкиToolStripMenuItem,
            this.новыеToolStripMenuItem,
            this.принятыеВРаботуToolStripMenuItem,
            this.выполненныеToolStripMenuItem,
            this.переоткрытыеToolStripMenuItem,
            this.отклоненныеToolStripMenuItem,
            this.отмененныеToolStripMenuItem});
            this.моиЗаявкиToolStripMenuItem.Name = "моиЗаявкиToolStripMenuItem";
            this.моиЗаявкиToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.моиЗаявкиToolStripMenuItem.Text = "Мои заявки";
            // 
            // всеЗаявкиToolStripMenuItem
            // 
            this.всеЗаявкиToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("всеЗаявкиToolStripMenuItem.Image")));
            this.всеЗаявкиToolStripMenuItem.Name = "всеЗаявкиToolStripMenuItem";
            this.всеЗаявкиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.всеЗаявкиToolStripMenuItem.Text = "Все заявки";
            this.всеЗаявкиToolStripMenuItem.Click += new System.EventHandler(this.всеЗаявкиToolStripMenuItem_Click);
            // 
            // новыеToolStripMenuItem
            // 
            this.новыеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("новыеToolStripMenuItem.Image")));
            this.новыеToolStripMenuItem.Name = "новыеToolStripMenuItem";
            this.новыеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.новыеToolStripMenuItem.Text = "Новые";
            this.новыеToolStripMenuItem.Click += new System.EventHandler(this.новыеToolStripMenuItem_Click);
            // 
            // принятыеВРаботуToolStripMenuItem
            // 
            this.принятыеВРаботуToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("принятыеВРаботуToolStripMenuItem.Image")));
            this.принятыеВРаботуToolStripMenuItem.Name = "принятыеВРаботуToolStripMenuItem";
            this.принятыеВРаботуToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.принятыеВРаботуToolStripMenuItem.Text = "Принятые в работу";
            this.принятыеВРаботуToolStripMenuItem.Click += new System.EventHandler(this.принятыеВРаботуToolStripMenuItem_Click);
            // 
            // отмененныеToolStripMenuItem
            // 
            this.отмененныеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("отмененныеToolStripMenuItem.Image")));
            this.отмененныеToolStripMenuItem.Name = "отмененныеToolStripMenuItem";
            this.отмененныеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.отмененныеToolStripMenuItem.Text = "Отмененные";
            this.отмененныеToolStripMenuItem.Click += new System.EventHandler(this.отмененныеToolStripMenuItem_Click);
            // 
            // выполненныеToolStripMenuItem
            // 
            this.выполненныеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("выполненныеToolStripMenuItem.Image")));
            this.выполненныеToolStripMenuItem.Name = "выполненныеToolStripMenuItem";
            this.выполненныеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выполненныеToolStripMenuItem.Text = "Выполненные";
            this.выполненныеToolStripMenuItem.Click += new System.EventHandler(this.выполненныеToolStripMenuItem_Click);
            // 
            // переоткрытыеToolStripMenuItem
            // 
            this.переоткрытыеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("переоткрытыеToolStripMenuItem.Image")));
            this.переоткрытыеToolStripMenuItem.Name = "переоткрытыеToolStripMenuItem";
            this.переоткрытыеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.переоткрытыеToolStripMenuItem.Text = "Переоткрытые";
            this.переоткрытыеToolStripMenuItem.Click += new System.EventHandler(this.переоткрытыеToolStripMenuItem_Click);
            // 
            // отклоненныеToolStripMenuItem
            // 
            this.отклоненныеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("отклоненныеToolStripMenuItem.Image")));
            this.отклоненныеToolStripMenuItem.Name = "отклоненныеToolStripMenuItem";
            this.отклоненныеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.отклоненныеToolStripMenuItem.Text = "Отклоненные";
            this.отклоненныеToolStripMenuItem.Click += new System.EventHandler(this.отклоненныеToolStripMenuItem_Click);
            // 
            // выгрузкаВExcelToolStripMenuItem
            // 
            this.выгрузкаВExcelToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("выгрузкаВExcelToolStripMenuItem.Image")));
            this.выгрузкаВExcelToolStripMenuItem.Name = "выгрузкаВExcelToolStripMenuItem";
            this.выгрузкаВExcelToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.выгрузкаВExcelToolStripMenuItem.Text = "Выгрузка в Excel";
            this.выгрузкаВExcelToolStripMenuItem.Click += new System.EventHandler(this.выгрузкаВExcelToolStripMenuItem_Click);
            // 
            // UserMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 450);
            this.Controls.Add(this.userMainFormGridView);
            this.Controls.Add(this.userMainFormMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.userMainFormMenuStrip;
            this.Name = "UserMainForm";
            this.Text = "Пользователь";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UserMainForm_Load);
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
        private System.Windows.Forms.ToolStripMenuItem всеЗаявкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выполненныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отклоненныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переоткрытыеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отмененныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem принятыеВРаботуToolStripMenuItem;
    }
}