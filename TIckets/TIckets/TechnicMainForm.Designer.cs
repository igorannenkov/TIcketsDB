namespace TIckets
{
    partial class TechnicMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TechnicMainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TechnicFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.складToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменаПароляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходИзСистемыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.моиЗаявкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.моиЗаявкиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.новыеЗаявкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выполненныеЗаявкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.возобновленныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.историяЗаявокКлиентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выгрузкаВExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.technicGridView = new System.Windows.Forms.DataGridView();
            this.TechnicFormMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.technicGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TechnicFormMenuStrip
            // 
            this.TechnicFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.моиЗаявкиToolStripMenuItem,
            this.выгрузкаВExcelToolStripMenuItem});
            this.TechnicFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.TechnicFormMenuStrip.Name = "TechnicFormMenuStrip";
            this.TechnicFormMenuStrip.Size = new System.Drawing.Size(1291, 24);
            this.TechnicFormMenuStrip.TabIndex = 0;
            this.TechnicFormMenuStrip.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.складToolStripMenuItem,
            this.сменаПароляToolStripMenuItem,
            this.выходИзСистемыToolStripMenuItem});
            this.менюToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("менюToolStripMenuItem.Image")));
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // складToolStripMenuItem
            // 
            this.складToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("складToolStripMenuItem.Image")));
            this.складToolStripMenuItem.Name = "складToolStripMenuItem";
            this.складToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.складToolStripMenuItem.Text = "Оборудование на складе";
            this.складToolStripMenuItem.Click += new System.EventHandler(this.складToolStripMenuItem_Click);
            // 
            // сменаПароляToolStripMenuItem
            // 
            this.сменаПароляToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сменаПароляToolStripMenuItem.Image")));
            this.сменаПароляToolStripMenuItem.Name = "сменаПароляToolStripMenuItem";
            this.сменаПароляToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.сменаПароляToolStripMenuItem.Text = "Смена пароля";
            this.сменаПароляToolStripMenuItem.Click += new System.EventHandler(this.сменаПароляToolStripMenuItem_Click);
            // 
            // выходИзСистемыToolStripMenuItem
            // 
            this.выходИзСистемыToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("выходИзСистемыToolStripMenuItem.Image")));
            this.выходИзСистемыToolStripMenuItem.Name = "выходИзСистемыToolStripMenuItem";
            this.выходИзСистемыToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.выходИзСистемыToolStripMenuItem.Text = "Выход из системы";
            this.выходИзСистемыToolStripMenuItem.Click += new System.EventHandler(this.выходИзСистемыToolStripMenuItem_Click);
            // 
            // моиЗаявкиToolStripMenuItem
            // 
            this.моиЗаявкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.моиЗаявкиToolStripMenuItem1,
            this.новыеЗаявкиToolStripMenuItem,
            this.выполненныеЗаявкиToolStripMenuItem,
            this.возобновленныеToolStripMenuItem,
            this.историяЗаявокКлиентаToolStripMenuItem});
            this.моиЗаявкиToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("моиЗаявкиToolStripMenuItem.Image")));
            this.моиЗаявкиToolStripMenuItem.Name = "моиЗаявкиToolStripMenuItem";
            this.моиЗаявкиToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.моиЗаявкиToolStripMenuItem.Text = "Заявки";
            // 
            // моиЗаявкиToolStripMenuItem1
            // 
            this.моиЗаявкиToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("моиЗаявкиToolStripMenuItem1.Image")));
            this.моиЗаявкиToolStripMenuItem1.Name = "моиЗаявкиToolStripMenuItem1";
            this.моиЗаявкиToolStripMenuItem1.Size = new System.Drawing.Size(207, 22);
            this.моиЗаявкиToolStripMenuItem1.Text = "Все заявки на мне";
            this.моиЗаявкиToolStripMenuItem1.Click += new System.EventHandler(this.моиЗаявкиToolStripMenuItem1_Click);
            // 
            // новыеЗаявкиToolStripMenuItem
            // 
            this.новыеЗаявкиToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("новыеЗаявкиToolStripMenuItem.Image")));
            this.новыеЗаявкиToolStripMenuItem.Name = "новыеЗаявкиToolStripMenuItem";
            this.новыеЗаявкиToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.новыеЗаявкиToolStripMenuItem.Text = "Принятые в работу";
            this.новыеЗаявкиToolStripMenuItem.Click += new System.EventHandler(this.новыеЗаявкиToolStripMenuItem_Click);
            // 
            // выполненныеЗаявкиToolStripMenuItem
            // 
            this.выполненныеЗаявкиToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("выполненныеЗаявкиToolStripMenuItem.Image")));
            this.выполненныеЗаявкиToolStripMenuItem.Name = "выполненныеЗаявкиToolStripMenuItem";
            this.выполненныеЗаявкиToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.выполненныеЗаявкиToolStripMenuItem.Text = "Выполненные";
            this.выполненныеЗаявкиToolStripMenuItem.Click += new System.EventHandler(this.выполненныеЗаявкиToolStripMenuItem_Click);
            // 
            // возобновленныеToolStripMenuItem
            // 
            this.возобновленныеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("возобновленныеToolStripMenuItem.Image")));
            this.возобновленныеToolStripMenuItem.Name = "возобновленныеToolStripMenuItem";
            this.возобновленныеToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.возобновленныеToolStripMenuItem.Text = "Переоткрытые";
            this.возобновленныеToolStripMenuItem.Click += new System.EventHandler(this.возобновленныеToolStripMenuItem_Click);
            // 
            // историяЗаявокКлиентаToolStripMenuItem
            // 
            this.историяЗаявокКлиентаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("историяЗаявокКлиентаToolStripMenuItem.Image")));
            this.историяЗаявокКлиентаToolStripMenuItem.Name = "историяЗаявокКлиентаToolStripMenuItem";
            this.историяЗаявокКлиентаToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.историяЗаявокКлиентаToolStripMenuItem.Text = "История заявок клиента";
            this.историяЗаявокКлиентаToolStripMenuItem.Click += new System.EventHandler(this.историяЗаявокКлиентаToolStripMenuItem_Click);
            // 
            // выгрузкаВExcelToolStripMenuItem
            // 
            this.выгрузкаВExcelToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("выгрузкаВExcelToolStripMenuItem.Image")));
            this.выгрузкаВExcelToolStripMenuItem.Name = "выгрузкаВExcelToolStripMenuItem";
            this.выгрузкаВExcelToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.выгрузкаВExcelToolStripMenuItem.Text = "Выгрузка в Excel";
            this.выгрузкаВExcelToolStripMenuItem.Click += new System.EventHandler(this.выгрузкаВExcelToolStripMenuItem_Click);
            // 
            // technicGridView
            // 
            this.technicGridView.AllowUserToAddRows = false;
            this.technicGridView.AllowUserToDeleteRows = false;
            this.technicGridView.AllowUserToResizeColumns = false;
            this.technicGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.technicGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.technicGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.technicGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.technicGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.technicGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.technicGridView.Location = new System.Drawing.Point(0, 24);
            this.technicGridView.Name = "technicGridView";
            this.technicGridView.ReadOnly = true;
            this.technicGridView.Size = new System.Drawing.Size(1291, 426);
            this.technicGridView.TabIndex = 1;
            this.technicGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.technicGridView_CellMouseDoubleClick);
            // 
            // TechnicMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 450);
            this.Controls.Add(this.technicGridView);
            this.Controls.Add(this.TechnicFormMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.TechnicFormMenuStrip;
            this.Name = "TechnicMainForm";
            this.Text = "Техник";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TechnicMainForm_Load);
            this.TechnicFormMenuStrip.ResumeLayout(false);
            this.TechnicFormMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.technicGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip TechnicFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem моиЗаявкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem моиЗаявкиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem новыеЗаявкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выполненныеЗаявкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem историяЗаявокКлиентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выгрузкаВExcelToolStripMenuItem;
        private System.Windows.Forms.DataGridView technicGridView;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменаПароляToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходИзСистемыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem возобновленныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem складToolStripMenuItem;
    }
}