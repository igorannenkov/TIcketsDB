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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.UsersFormGridView = new System.Windows.Forms.DataGridView();
            this.AddUserMenuStrip = new System.Windows.Forms.MenuStrip();
            this.добавитьПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.UsersFormGridView)).BeginInit();
            this.AddUserMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // UsersFormGridView
            // 
            this.UsersFormGridView.AllowUserToAddRows = false;
            this.UsersFormGridView.AllowUserToDeleteRows = false;
            this.UsersFormGridView.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsersFormGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.UsersFormGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsersFormGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersFormGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.UsersFormGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersFormGridView.Location = new System.Drawing.Point(12, 27);
            this.UsersFormGridView.Name = "UsersFormGridView";
            this.UsersFormGridView.ReadOnly = true;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsersFormGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.UsersFormGridView.Size = new System.Drawing.Size(509, 411);
            this.UsersFormGridView.TabIndex = 0;
            this.UsersFormGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.UsersFormGridView_CellMouseDoubleClick);
            this.UsersFormGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UsersFormGridView_KeyDown);
            // 
            // AddUserMenuStrip
            // 
            this.AddUserMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьПользователяToolStripMenuItem});
            this.AddUserMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.AddUserMenuStrip.Name = "AddUserMenuStrip";
            this.AddUserMenuStrip.Size = new System.Drawing.Size(533, 24);
            this.AddUserMenuStrip.TabIndex = 1;
            this.AddUserMenuStrip.Text = "menuStrip1";
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
            this.ClientSize = new System.Drawing.Size(533, 450);
            this.Controls.Add(this.UsersFormGridView);
            this.Controls.Add(this.AddUserMenuStrip);
            this.MainMenuStrip = this.AddUserMenuStrip;
            this.Name = "UsersForm";
            this.Text = "Пользователи";
            ((System.ComponentModel.ISupportInitialize)(this.UsersFormGridView)).EndInit();
            this.AddUserMenuStrip.ResumeLayout(false);
            this.AddUserMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UsersFormGridView;
        private System.Windows.Forms.MenuStrip AddUserMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem добавитьПользователяToolStripMenuItem;
    }
}