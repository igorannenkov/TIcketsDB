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
            this.UserMainFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выгрузкаВExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.моиЗаявкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новаяЗаявкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.историяЗаявокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserMainFormMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserMainFormMenuStrip
            // 
            this.UserMainFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.выгрузкаВExcelToolStripMenuItem});
            this.UserMainFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.UserMainFormMenuStrip.Name = "UserMainFormMenuStrip";
            this.UserMainFormMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.UserMainFormMenuStrip.TabIndex = 0;
            this.UserMainFormMenuStrip.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаяЗаявкаToolStripMenuItem,
            this.моиЗаявкиToolStripMenuItem,
            this.историяЗаявокToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // выгрузкаВExcelToolStripMenuItem
            // 
            this.выгрузкаВExcelToolStripMenuItem.Name = "выгрузкаВExcelToolStripMenuItem";
            this.выгрузкаВExcelToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.выгрузкаВExcelToolStripMenuItem.Text = "Выгрузка в Excel";
            // 
            // моиЗаявкиToolStripMenuItem
            // 
            this.моиЗаявкиToolStripMenuItem.Name = "моиЗаявкиToolStripMenuItem";
            this.моиЗаявкиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.моиЗаявкиToolStripMenuItem.Text = "Мои заявки";
            // 
            // новаяЗаявкаToolStripMenuItem
            // 
            this.новаяЗаявкаToolStripMenuItem.Name = "новаяЗаявкаToolStripMenuItem";
            this.новаяЗаявкаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.новаяЗаявкаToolStripMenuItem.Text = "Новая заявка";
            // 
            // историяЗаявокToolStripMenuItem
            // 
            this.историяЗаявокToolStripMenuItem.Name = "историяЗаявокToolStripMenuItem";
            this.историяЗаявокToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.историяЗаявокToolStripMenuItem.Text = "История заявок";
            // 
            // UserMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UserMainFormMenuStrip);
            this.MainMenuStrip = this.UserMainFormMenuStrip;
            this.Name = "UserMainForm";
            this.Text = "Пользователь";
            this.UserMainFormMenuStrip.ResumeLayout(false);
            this.UserMainFormMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip UserMainFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новаяЗаявкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem моиЗаявкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem историяЗаявокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выгрузкаВExcelToolStripMenuItem;
    }
}