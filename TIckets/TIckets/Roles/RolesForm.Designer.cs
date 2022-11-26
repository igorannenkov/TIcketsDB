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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AddRoleMenuStrip = new System.Windows.Forms.MenuStrip();
            this.добавитьРольToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RolesFormGridView = new System.Windows.Forms.DataGridView();
            this.AddRoleMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RolesFormGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddRoleMenuStrip
            // 
            this.AddRoleMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьРольToolStripMenuItem});
            this.AddRoleMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.AddRoleMenuStrip.Name = "AddRoleMenuStrip";
            this.AddRoleMenuStrip.Size = new System.Drawing.Size(348, 24);
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
            // RolesFormGridView
            // 
            this.RolesFormGridView.AllowUserToAddRows = false;
            this.RolesFormGridView.AllowUserToDeleteRows = false;
            this.RolesFormGridView.AllowUserToResizeColumns = false;
            this.RolesFormGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RolesFormGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.RolesFormGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RolesFormGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.RolesFormGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RolesFormGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.RolesFormGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RolesFormGridView.Location = new System.Drawing.Point(0, 24);
            this.RolesFormGridView.Name = "RolesFormGridView";
            this.RolesFormGridView.ReadOnly = true;
            this.RolesFormGridView.Size = new System.Drawing.Size(348, 426);
            this.RolesFormGridView.TabIndex = 1;
            this.RolesFormGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.RolesFormGridView_CellMouseDoubleClick);
            this.RolesFormGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RolesFormGridView_KeyDown);
            // 
            // RolesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 450);
            this.Controls.Add(this.RolesFormGridView);
            this.Controls.Add(this.AddRoleMenuStrip);
            this.MainMenuStrip = this.AddRoleMenuStrip;
            this.MaximizeBox = false;
            this.Name = "RolesForm";
            this.Text = "Роли";
            this.AddRoleMenuStrip.ResumeLayout(false);
            this.AddRoleMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RolesFormGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip AddRoleMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem добавитьРольToolStripMenuItem;
        private System.Windows.Forms.DataGridView RolesFormGridView;
    }
}