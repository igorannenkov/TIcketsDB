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
            this.свободныеТехникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выгрузкаВExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdmFormMenuStrip.SuspendLayout();
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
            this.AdmFormMenuStrip.Size = new System.Drawing.Size(800, 24);
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
            this.ПользователиToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.ПользователиToolStripMenuItem.Text = "Пользователи";
            this.ПользователиToolStripMenuItem.Click += new System.EventHandler(this.ПользователиToolStripMenuItem_Click);
            // 
            // техникиToolStripMenuItem
            // 
            this.техникиToolStripMenuItem.Name = "техникиToolStripMenuItem";
            this.техникиToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.техникиToolStripMenuItem.Text = "Техники";
            // 
            // администраторыToolStripMenuItem
            // 
            this.администраторыToolStripMenuItem.Name = "администраторыToolStripMenuItem";
            this.администраторыToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.администраторыToolStripMenuItem.Text = "Администраторы";
            // 
            // статусыToolStripMenuItem
            // 
            this.статусыToolStripMenuItem.Name = "статусыToolStripMenuItem";
            this.статусыToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.статусыToolStripMenuItem.Text = "Статусы пользователей";
            // 
            // ролиToolStripMenuItem
            // 
            this.ролиToolStripMenuItem.Name = "ролиToolStripMenuItem";
            this.ролиToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.ролиToolStripMenuItem.Text = "Роли";
            this.ролиToolStripMenuItem.Click += new System.EventHandler(this.ролиToolStripMenuItem_Click);
            // 
            // ТипыУстройствToolStripMenuItem
            // 
            this.ТипыУстройствToolStripMenuItem.Name = "ТипыУстройствToolStripMenuItem";
            this.ТипыУстройствToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.ТипыУстройствToolStripMenuItem.Text = "Категории комплектующих";
            this.ТипыУстройствToolStripMenuItem.Click += new System.EventHandler(this.ТипыУстройствToolStripMenuItem_Click);
            // 
            // статусыЗаявокToolStripMenuItem
            // 
            this.статусыЗаявокToolStripMenuItem.Name = "статусыЗаявокToolStripMenuItem";
            this.статусыЗаявокToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.статусыЗаявокToolStripMenuItem.Text = "Статусы заявок";
            // 
            // складУстройствToolStripMenuItem
            // 
            this.складУстройствToolStripMenuItem.Name = "складУстройствToolStripMenuItem";
            this.складУстройствToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.складУстройствToolStripMenuItem.Text = "Склад комплектующих";
            // 
            // запросыToolStripMenuItem
            // 
            this.запросыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заявкиВРазрезеТехниковToolStripMenuItem,
            this.свободныеТехникиToolStripMenuItem});
            this.запросыToolStripMenuItem.Name = "запросыToolStripMenuItem";
            this.запросыToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.запросыToolStripMenuItem.Text = "Запросы";
            // 
            // заявкиВРазрезеТехниковToolStripMenuItem
            // 
            this.заявкиВРазрезеТехниковToolStripMenuItem.Name = "заявкиВРазрезеТехниковToolStripMenuItem";
            this.заявкиВРазрезеТехниковToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.заявкиВРазрезеТехниковToolStripMenuItem.Text = "Заявки в разрезе техников";
            // 
            // свободныеТехникиToolStripMenuItem
            // 
            this.свободныеТехникиToolStripMenuItem.Name = "свободныеТехникиToolStripMenuItem";
            this.свободныеТехникиToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.свободныеТехникиToolStripMenuItem.Text = "Свободные техники";
            // 
            // выгрузкаВExcelToolStripMenuItem
            // 
            this.выгрузкаВExcelToolStripMenuItem.Name = "выгрузкаВExcelToolStripMenuItem";
            this.выгрузкаВExcelToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.выгрузкаВExcelToolStripMenuItem.Text = "Выгрузка в Excel";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AdmFormMenuStrip);
            this.MainMenuStrip = this.AdmFormMenuStrip;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Администратор";
            this.AdmFormMenuStrip.ResumeLayout(false);
            this.AdmFormMenuStrip.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem свободныеТехникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выгрузкаВExcelToolStripMenuItem;
    }
}