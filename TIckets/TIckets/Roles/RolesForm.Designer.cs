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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RolesFormGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.RolesFormGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RolesFormGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RolesFormGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.RolesFormGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RolesFormGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.RolesFormGridView.Location = new System.Drawing.Point(12, 27);
            this.RolesFormGridView.Name = "RolesFormGridView";
            this.RolesFormGridView.ReadOnly = true;
            this.RolesFormGridView.Size = new System.Drawing.Size(324, 411);
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