namespace TIckets
{
    partial class UsersForm
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
            this.AdmUsersGridView = new System.Windows.Forms.DataGridView();
            this.UsersMenuStrip = new System.Windows.Forms.MenuStrip();
            this.добавитьПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.AdmUsersGridView)).BeginInit();
            this.UsersMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdmUsersGridView
            // 
            this.AdmUsersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdmUsersGridView.Location = new System.Drawing.Point(12, 64);
            this.AdmUsersGridView.Name = "AdmUsersGridView";
            this.AdmUsersGridView.Size = new System.Drawing.Size(600, 234);
            this.AdmUsersGridView.TabIndex = 0;
            // 
            // UsersMenuStrip
            // 
            this.UsersMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьПользователяToolStripMenuItem});
            this.UsersMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.UsersMenuStrip.Name = "UsersMenuStrip";
            this.UsersMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.UsersMenuStrip.TabIndex = 1;
            this.UsersMenuStrip.Text = "menuStrip1";
            // 
            // добавитьПользователяToolStripMenuItem
            // 
            this.добавитьПользователяToolStripMenuItem.Name = "добавитьПользователяToolStripMenuItem";
            this.добавитьПользователяToolStripMenuItem.Size = new System.Drawing.Size(149, 20);
            this.добавитьПользователяToolStripMenuItem.Text = "Добавить пользователя";
            this.добавитьПользователяToolStripMenuItem.Click += new System.EventHandler(this.добавитьПользователяToolStripMenuItem_Click);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AdmUsersGridView);
            this.Controls.Add(this.UsersMenuStrip);
            this.MainMenuStrip = this.UsersMenuStrip;
            this.Name = "UsersForm";
            this.Text = "Пользователи";
            ((System.ComponentModel.ISupportInitialize)(this.AdmUsersGridView)).EndInit();
            this.UsersMenuStrip.ResumeLayout(false);
            this.UsersMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AdmUsersGridView;
        private System.Windows.Forms.MenuStrip UsersMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem добавитьПользователяToolStripMenuItem;
    }
}