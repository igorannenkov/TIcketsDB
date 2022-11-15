namespace TIckets
{
    partial class RolesForm
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
            this.AddRoleMenuStrip = new System.Windows.Forms.MenuStrip();
            this.добавитьРольToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddRoleMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddRoleMenuStrip
            // 
            this.AddRoleMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьРольToolStripMenuItem});
            this.AddRoleMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.AddRoleMenuStrip.Name = "AddRoleMenuStrip";
            this.AddRoleMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.AddRoleMenuStrip.TabIndex = 0;
            this.AddRoleMenuStrip.Text = "menuStrip1";
            // 
            // добавитьРольToolStripMenuItem
            // 
            this.добавитьРольToolStripMenuItem.Name = "добавитьРольToolStripMenuItem";
            this.добавитьРольToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.добавитьРольToolStripMenuItem.Text = "Добавить роль";
            this.добавитьРольToolStripMenuItem.Click += new System.EventHandler(this.добавитьРольToolStripMenuItem_Click);
            // 
            // RolesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddRoleMenuStrip);
            this.MainMenuStrip = this.AddRoleMenuStrip;
            this.Name = "RolesForm";
            this.Text = "Список ролей";
            this.AddRoleMenuStrip.ResumeLayout(false);
            this.AddRoleMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip AddRoleMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem добавитьРольToolStripMenuItem;
    }
}