namespace TIckets
{
    partial class AdminForm
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
            this.AdmFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.СправочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ПользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.техникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.администраторыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статусыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ролиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ТипыУстройствToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статусыЗаявокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.складУстройствToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заявкиВРазрезеТехниковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всеЗаявкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыеЗаявкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выгрузкаВExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.admGridView = new System.Windows.Forms.DataGridView();
            this.AdmFormMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AdmFormMenuStrip
            // 
            this.AdmFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.СправочникиToolStripMenuItem,
            this.запросыToolStripMenuItem,
            this.выгрузкаВExcelToolStripMenuItem});
            this.AdmFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.AdmFormMenuStrip.Name = "AdmFormMenuStrip";
            this.AdmFormMenuStrip.Size = new System.Drawing.Size(1222, 24);
            this.AdmFormMenuStrip.TabIndex = 0;
            this.AdmFormMenuStrip.Text = "menuStrip1";
            // 
            // СправочникиToolStripMenuItem
            // 
            this.СправочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ПользователиToolStripMenuItem,
            this.техникиToolStripMenuItem,
            this.администраторыToolStripMenuItem,
            this.статусыToolStripMenuItem,
            this.ролиToolStripMenuItem,
            this.ТипыУстройствToolStripMenuItem,
            this.статусыЗаявокToolStripMenuItem,
            this.складУстройствToolStripMenuItem});
            this.СправочникиToolStripMenuItem.Name = "СправочникиToolStripMenuItem";
            this.СправочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.СправочникиToolStripMenuItem.Text = "Справочники";
            // 
            // ПользователиToolStripMenuItem
            // 
            this.ПользователиToolStripMenuItem.Name = "ПользователиToolStripMenuItem";
            this.ПользователиToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.ПользователиToolStripMenuItem.Text = "Пользователи";
            this.ПользователиToolStripMenuItem.Click += new System.EventHandler(this.ПользователиToolStripMenuItem_Click);
            // 
            // техникиToolStripMenuItem
            // 
            this.техникиToolStripMenuItem.Name = "техникиToolStripMenuItem";
            this.техникиToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            // 
            // администраторыToolStripMenuItem
            // 
            this.администраторыToolStripMenuItem.Name = "администраторыToolStripMenuItem";
            this.администраторыToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.администраторыToolStripMenuItem.Text = "Администраторы";
            // 
            // статусыToolStripMenuItem
            // 
            this.статусыToolStripMenuItem.Name = "статусыToolStripMenuItem";
            this.статусыToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            // 
            // ролиToolStripMenuItem
            // 
            this.ролиToolStripMenuItem.Name = "ролиToolStripMenuItem";
            this.ролиToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.ролиToolStripMenuItem.Text = "Роли";
            this.ролиToolStripMenuItem.Click += new System.EventHandler(this.ролиToolStripMenuItem_Click);
            // 
            // ТипыУстройствToolStripMenuItem
            // 
            this.ТипыУстройствToolStripMenuItem.Name = "ТипыУстройствToolStripMenuItem";
            this.ТипыУстройствToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.ТипыУстройствToolStripMenuItem.Text = "Категории комплектующих";
            this.ТипыУстройствToolStripMenuItem.Click += new System.EventHandler(this.ТипыУстройствToolStripMenuItem_Click);
            // 
            // статусыЗаявокToolStripMenuItem
            // 
            this.статусыЗаявокToolStripMenuItem.Name = "статусыЗаявокToolStripMenuItem";
            this.статусыЗаявокToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.статусыЗаявокToolStripMenuItem.Text = "Статусы заявок";
            this.статусыЗаявокToolStripMenuItem.Click += new System.EventHandler(this.статусыЗаявокToolStripMenuItem_Click);
            // 
            // складУстройствToolStripMenuItem
            // 
            this.складУстройствToolStripMenuItem.Name = "складУстройствToolStripMenuItem";
            this.складУстройствToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.складУстройствToolStripMenuItem.Text = "Склад комплектующих";
            // 
            // запросыToolStripMenuItem
            // 
            this.запросыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заявкиВРазрезеТехниковToolStripMenuItem,
            this.всеЗаявкиToolStripMenuItem,
            this.новыеЗаявкиToolStripMenuItem});
            this.запросыToolStripMenuItem.Name = "запросыToolStripMenuItem";
            this.запросыToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.запросыToolStripMenuItem.Text = "Запросы";
            // 
            // заявкиВРазрезеТехниковToolStripMenuItem
            // 
            this.заявкиВРазрезеТехниковToolStripMenuItem.Name = "заявкиВРазрезеТехниковToolStripMenuItem";
            this.заявкиВРазрезеТехниковToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.заявкиВРазрезеТехниковToolStripMenuItem.Text = "Заявки в разрезе техников";
            // 
            // всеЗаявкиToolStripMenuItem
            // 
            this.всеЗаявкиToolStripMenuItem.Name = "всеЗаявкиToolStripMenuItem";
            this.всеЗаявкиToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.всеЗаявкиToolStripMenuItem.Text = "Все заявки";
            this.всеЗаявкиToolStripMenuItem.Click += new System.EventHandler(this.всеЗаявкиToolStripMenuItem_Click);
            // 
            // новыеЗаявкиToolStripMenuItem
            // 
            this.новыеЗаявкиToolStripMenuItem.Name = "новыеЗаявкиToolStripMenuItem";
            this.новыеЗаявкиToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.новыеЗаявкиToolStripMenuItem.Text = "Новые заявки";
            this.новыеЗаявкиToolStripMenuItem.Click += new System.EventHandler(this.новыеЗаявкиToolStripMenuItem_Click);
            // 
            // выгрузкаВExcelToolStripMenuItem
            // 
            this.выгрузкаВExcelToolStripMenuItem.Name = "выгрузкаВExcelToolStripMenuItem";
            this.выгрузкаВExcelToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.выгрузкаВExcelToolStripMenuItem.Text = "Выгрузка в Excel";
            this.выгрузкаВExcelToolStripMenuItem.Click += new System.EventHandler(this.выгрузкаВExcelToolStripMenuItem_Click);
            // 
            // admGridView
            // 
            this.admGridView.AllowUserToAddRows = false;
            this.admGridView.AllowUserToDeleteRows = false;
            this.admGridView.AllowUserToResizeColumns = false;
            this.admGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.admGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.admGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.admGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.admGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.admGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.admGridView.Location = new System.Drawing.Point(12, 38);
            this.admGridView.Name = "admGridView";
            this.admGridView.ReadOnly = true;
            this.admGridView.Size = new System.Drawing.Size(1198, 400);
            this.admGridView.TabIndex = 1;
            this.admGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.admGridView_CellMouseDoubleClick);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 450);
            this.Controls.Add(this.admGridView);
            this.Controls.Add(this.AdmFormMenuStrip);
            this.MainMenuStrip = this.AdmFormMenuStrip;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Администратор";
            this.AdmFormMenuStrip.ResumeLayout(false);
            this.AdmFormMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip AdmFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem СправочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ПользователиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ролиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статусыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ТипыУстройствToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статусыЗаявокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem техникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem складУстройствToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem администраторыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заявкиВРазрезеТехниковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выгрузкаВExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всеЗаявкиToolStripMenuItem;
        private System.Windows.Forms.DataGridView admGridView;
        private System.Windows.Forms.ToolStripMenuItem новыеЗаявкиToolStripMenuItem;
    }
}