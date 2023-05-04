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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AdmFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменаПароляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файлБазыДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проверкаСоединенияСБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходИзСистемыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.СправочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ролиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статусыЗаявокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ТипыУстройствToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.складУстройствToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыеЗаявкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заявкиВРазрезеТехниковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выполненныеЗаявкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всеЗаявкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отклоненныеИлиОтмененныеЗаявкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запросыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.количествоЗаявокПоТехникамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.количествоЗаявокПоТипамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.техникСМаксимальнымОбъемомЗаявокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.admGridView = new System.Windows.Forms.DataGridView();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ПользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выгрузкаВExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdmFormMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AdmFormMenuStrip
            // 
            this.AdmFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.СправочникиToolStripMenuItem,
            this.запросыToolStripMenuItem,
            this.запросыToolStripMenuItem1,
            this.выгрузкаВExcelToolStripMenuItem});
            this.AdmFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.AdmFormMenuStrip.Name = "AdmFormMenuStrip";
            this.AdmFormMenuStrip.Size = new System.Drawing.Size(1222, 24);
            this.AdmFormMenuStrip.TabIndex = 0;
            this.AdmFormMenuStrip.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сменаПароляToolStripMenuItem,
            this.файлБазыДанныхToolStripMenuItem,
            this.проверкаСоединенияСБДToolStripMenuItem,
            this.выходИзСистемыToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "&Меню";
            // 
            // сменаПароляToolStripMenuItem
            // 
            this.сменаПароляToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сменаПароляToolStripMenuItem.Image")));
            this.сменаПароляToolStripMenuItem.Name = "сменаПароляToolStripMenuItem";
            this.сменаПароляToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.сменаПароляToolStripMenuItem.Text = "Смена &пароля";
            this.сменаПароляToolStripMenuItem.Click += new System.EventHandler(this.сменаПароляToolStripMenuItem_Click);
            // 
            // файлБазыДанныхToolStripMenuItem
            // 
            this.файлБазыДанныхToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("файлБазыДанныхToolStripMenuItem.Image")));
            this.файлБазыДанныхToolStripMenuItem.Name = "файлБазыДанныхToolStripMenuItem";
            this.файлБазыДанныхToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.файлБазыДанныхToolStripMenuItem.Text = "Файл базы данных...";
            this.файлБазыДанныхToolStripMenuItem.Click += new System.EventHandler(this.файлБазыДанныхToolStripMenuItem_Click);
            // 
            // проверкаСоединенияСБДToolStripMenuItem
            // 
            this.проверкаСоединенияСБДToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("проверкаСоединенияСБДToolStripMenuItem.Image")));
            this.проверкаСоединенияСБДToolStripMenuItem.Name = "проверкаСоединенияСБДToolStripMenuItem";
            this.проверкаСоединенияСБДToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.проверкаСоединенияСБДToolStripMenuItem.Text = "Проверка соединения с БД";
            this.проверкаСоединенияСБДToolStripMenuItem.Click += new System.EventHandler(this.проверкаСоединенияСБДToolStripMenuItem_Click);
            // 
            // выходИзСистемыToolStripMenuItem
            // 
            this.выходИзСистемыToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("выходИзСистемыToolStripMenuItem.Image")));
            this.выходИзСистемыToolStripMenuItem.Name = "выходИзСистемыToolStripMenuItem";
            this.выходИзСистемыToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.выходИзСистемыToolStripMenuItem.Text = "Вы&ход из системы";
            this.выходИзСистемыToolStripMenuItem.Click += new System.EventHandler(this.выходИзСистемыToolStripMenuItem_Click_1);
            // 
            // СправочникиToolStripMenuItem
            // 
            this.СправочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ПользователиToolStripMenuItem,
            this.ролиToolStripMenuItem,
            this.статусыЗаявокToolStripMenuItem,
            this.ТипыУстройствToolStripMenuItem,
            this.складУстройствToolStripMenuItem});
            this.СправочникиToolStripMenuItem.Name = "СправочникиToolStripMenuItem";
            this.СправочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.СправочникиToolStripMenuItem.Text = "&Справочники";
            // 
            // ролиToolStripMenuItem
            // 
            this.ролиToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ролиToolStripMenuItem.Image")));
            this.ролиToolStripMenuItem.Name = "ролиToolStripMenuItem";
            this.ролиToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.ролиToolStripMenuItem.Text = "&Роли";
            this.ролиToolStripMenuItem.Click += new System.EventHandler(this.ролиToolStripMenuItem_Click);
            // 
            // статусыЗаявокToolStripMenuItem
            // 
            this.статусыЗаявокToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("статусыЗаявокToolStripMenuItem.Image")));
            this.статусыЗаявокToolStripMenuItem.Name = "статусыЗаявокToolStripMenuItem";
            this.статусыЗаявокToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.статусыЗаявокToolStripMenuItem.Text = "Статусы заявок";
            this.статусыЗаявокToolStripMenuItem.Click += new System.EventHandler(this.статусыЗаявокToolStripMenuItem_Click);
            // 
            // ТипыУстройствToolStripMenuItem
            // 
            this.ТипыУстройствToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ТипыУстройствToolStripMenuItem.Image")));
            this.ТипыУстройствToolStripMenuItem.Name = "ТипыУстройствToolStripMenuItem";
            this.ТипыУстройствToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.ТипыУстройствToolStripMenuItem.Text = "&Каталог оборудования";
            this.ТипыУстройствToolStripMenuItem.Click += new System.EventHandler(this.ТипыУстройствToolStripMenuItem_Click);
            // 
            // складУстройствToolStripMenuItem
            // 
            this.складУстройствToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("складУстройствToolStripMenuItem.Image")));
            this.складУстройствToolStripMenuItem.Name = "складУстройствToolStripMenuItem";
            this.складУстройствToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.складУстройствToolStripMenuItem.Text = "Оборудование на складе";
            this.складУстройствToolStripMenuItem.Click += new System.EventHandler(this.складУстройствToolStripMenuItem_Click);
            // 
            // запросыToolStripMenuItem
            // 
            this.запросыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыеЗаявкиToolStripMenuItem,
            this.заявкиВРазрезеТехниковToolStripMenuItem,
            this.выполненныеЗаявкиToolStripMenuItem,
            this.всеЗаявкиToolStripMenuItem,
            this.отклоненныеИлиОтмененныеЗаявкиToolStripMenuItem});
            this.запросыToolStripMenuItem.Name = "запросыToolStripMenuItem";
            this.запросыToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.запросыToolStripMenuItem.Text = "&Заявки";
            // 
            // новыеЗаявкиToolStripMenuItem
            // 
            this.новыеЗаявкиToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("новыеЗаявкиToolStripMenuItem.Image")));
            this.новыеЗаявкиToolStripMenuItem.Name = "новыеЗаявкиToolStripMenuItem";
            this.новыеЗаявкиToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.новыеЗаявкиToolStripMenuItem.Text = "Новые";
            this.новыеЗаявкиToolStripMenuItem.Click += new System.EventHandler(this.новыеЗаявкиToolStripMenuItem_Click);
            // 
            // заявкиВРазрезеТехниковToolStripMenuItem
            // 
            this.заявкиВРазрезеТехниковToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("заявкиВРазрезеТехниковToolStripMenuItem.Image")));
            this.заявкиВРазрезеТехниковToolStripMenuItem.Name = "заявкиВРазрезеТехниковToolStripMenuItem";
            this.заявкиВРазрезеТехниковToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.заявкиВРазрезеТехниковToolStripMenuItem.Text = "Прин&ятые в работу";
            this.заявкиВРазрезеТехниковToolStripMenuItem.Click += new System.EventHandler(this.заявкиВРазрезеТехниковToolStripMenuItem_Click);
            // 
            // выполненныеЗаявкиToolStripMenuItem
            // 
            this.выполненныеЗаявкиToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("выполненныеЗаявкиToolStripMenuItem.Image")));
            this.выполненныеЗаявкиToolStripMenuItem.Name = "выполненныеЗаявкиToolStripMenuItem";
            this.выполненныеЗаявкиToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.выполненныеЗаявкиToolStripMenuItem.Text = "В&ыполненные";
            this.выполненныеЗаявкиToolStripMenuItem.Click += new System.EventHandler(this.выполненныеЗаявкиToolStripMenuItem_Click);
            // 
            // всеЗаявкиToolStripMenuItem
            // 
            this.всеЗаявкиToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("всеЗаявкиToolStripMenuItem.Image")));
            this.всеЗаявкиToolStripMenuItem.Name = "всеЗаявкиToolStripMenuItem";
            this.всеЗаявкиToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.всеЗаявкиToolStripMenuItem.Text = "Все";
            this.всеЗаявкиToolStripMenuItem.Click += new System.EventHandler(this.всеЗаявкиToolStripMenuItem_Click);
            // 
            // отклоненныеИлиОтмененныеЗаявкиToolStripMenuItem
            // 
            this.отклоненныеИлиОтмененныеЗаявкиToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("отклоненныеИлиОтмененныеЗаявкиToolStripMenuItem.Image")));
            this.отклоненныеИлиОтмененныеЗаявкиToolStripMenuItem.Name = "отклоненныеИлиОтмененныеЗаявкиToolStripMenuItem";
            this.отклоненныеИлиОтмененныеЗаявкиToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.отклоненныеИлиОтмененныеЗаявкиToolStripMenuItem.Text = "Отклоненные или отмененные";
            this.отклоненныеИлиОтмененныеЗаявкиToolStripMenuItem.Click += new System.EventHandler(this.отклоненныеИлиОтмененныеЗаявкиToolStripMenuItem_Click);
            // 
            // запросыToolStripMenuItem1
            // 
            this.запросыToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.количествоЗаявокПоТехникамToolStripMenuItem,
            this.количествоЗаявокПоТипамToolStripMenuItem,
            this.техникСМаксимальнымОбъемомЗаявокToolStripMenuItem});
            this.запросыToolStripMenuItem1.Name = "запросыToolStripMenuItem1";
            this.запросыToolStripMenuItem1.Size = new System.Drawing.Size(68, 20);
            this.запросыToolStripMenuItem1.Text = "Запросы";
            // 
            // количествоЗаявокПоТехникамToolStripMenuItem
            // 
            this.количествоЗаявокПоТехникамToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("количествоЗаявокПоТехникамToolStripMenuItem.Image")));
            this.количествоЗаявокПоТехникамToolStripMenuItem.Name = "количествоЗаявокПоТехникамToolStripMenuItem";
            this.количествоЗаявокПоТехникамToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.количествоЗаявокПоТехникамToolStripMenuItem.Text = "Количество заявок по техникам";
            this.количествоЗаявокПоТехникамToolStripMenuItem.Click += new System.EventHandler(this.количествоЗаявокПоТехникамToolStripMenuItem_Click);
            // 
            // количествоЗаявокПоТипамToolStripMenuItem
            // 
            this.количествоЗаявокПоТипамToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("количествоЗаявокПоТипамToolStripMenuItem.Image")));
            this.количествоЗаявокПоТипамToolStripMenuItem.Name = "количествоЗаявокПоТипамToolStripMenuItem";
            this.количествоЗаявокПоТипамToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.количествоЗаявокПоТипамToolStripMenuItem.Text = "Количество заявок по типам";
            this.количествоЗаявокПоТипамToolStripMenuItem.Click += new System.EventHandler(this.количествоЗаявокПоТипамToolStripMenuItem_Click);
            // 
            // техникСМаксимальнымОбъемомЗаявокToolStripMenuItem
            // 
            this.техникСМаксимальнымОбъемомЗаявокToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("техникСМаксимальнымОбъемомЗаявокToolStripMenuItem.Image")));
            this.техникСМаксимальнымОбъемомЗаявокToolStripMenuItem.Name = "техникСМаксимальнымОбъемомЗаявокToolStripMenuItem";
            this.техникСМаксимальнымОбъемомЗаявокToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.техникСМаксимальнымОбъемомЗаявокToolStripMenuItem.Text = "Техник с максимальным объемом заявок";
            this.техникСМаксимальнымОбъемомЗаявокToolStripMenuItem.Click += new System.EventHandler(this.техникСМаксимальнымОбъемомЗаявокToolStripMenuItem_Click);
            // 
            // admGridView
            // 
            this.admGridView.AllowUserToAddRows = false;
            this.admGridView.AllowUserToDeleteRows = false;
            this.admGridView.AllowUserToResizeColumns = false;
            this.admGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.admGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.admGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.admGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.admGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.admGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.admGridView.Location = new System.Drawing.Point(0, 24);
            this.admGridView.Name = "admGridView";
            this.admGridView.ReadOnly = true;
            this.admGridView.Size = new System.Drawing.Size(1222, 426);
            this.admGridView.TabIndex = 1;
            this.admGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.admGridView_CellMouseDoubleClick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // ПользователиToolStripMenuItem
            // 
            this.ПользователиToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ПользователиToolStripMenuItem.Image")));
            this.ПользователиToolStripMenuItem.Name = "ПользователиToolStripMenuItem";
            this.ПользователиToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.ПользователиToolStripMenuItem.Text = "Пользователи системы";
            this.ПользователиToolStripMenuItem.Click += new System.EventHandler(this.ПользователиToolStripMenuItem_Click);
            // 
            // выгрузкаВExcelToolStripMenuItem
            // 
            this.выгрузкаВExcelToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("выгрузкаВExcelToolStripMenuItem.Image")));
            this.выгрузкаВExcelToolStripMenuItem.Name = "выгрузкаВExcelToolStripMenuItem";
            this.выгрузкаВExcelToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.выгрузкаВExcelToolStripMenuItem.Text = "&Выгрузка в Excel";
            this.выгрузкаВExcelToolStripMenuItem.Click += new System.EventHandler(this.выгрузкаВExcelToolStripMenuItem_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 450);
            this.Controls.Add(this.admGridView);
            this.Controls.Add(this.AdmFormMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.AdmFormMenuStrip;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Администратор";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminForm_Load);
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
        private System.Windows.Forms.ToolStripMenuItem ТипыУстройствToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статусыЗаявокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem складУстройствToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заявкиВРазрезеТехниковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выгрузкаВExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всеЗаявкиToolStripMenuItem;
        private System.Windows.Forms.DataGridView admGridView;
        private System.Windows.Forms.ToolStripMenuItem новыеЗаявкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выполненныеЗаявкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменаПароляToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходИзСистемыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отклоненныеИлиОтмененныеЗаявкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлБазыДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проверкаСоединенияСБДToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem запросыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem количествоЗаявокПоТехникамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem количествоЗаявокПоТипамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem техникСМаксимальнымОбъемомЗаявокToolStripMenuItem;
    }
}