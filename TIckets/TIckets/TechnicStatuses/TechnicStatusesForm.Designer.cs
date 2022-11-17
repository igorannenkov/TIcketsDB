namespace TIckets
{
    partial class TechnicStatusesForm
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
            this.AddTechnicStatusMenuStrip = new System.Windows.Forms.MenuStrip();
            this.добавитьСтатусToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TechnicStatusesFormGridView = new System.Windows.Forms.DataGridView();
            this.AddTechnicStatusMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TechnicStatusesFormGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddTechnicStatusMenuStrip
            // 
            this.AddTechnicStatusMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьСтатусToolStripMenuItem});
            this.AddTechnicStatusMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.AddTechnicStatusMenuStrip.Name = "AddTechnicStatusMenuStrip";
            this.AddTechnicStatusMenuStrip.Size = new System.Drawing.Size(319, 24);
            this.AddTechnicStatusMenuStrip.TabIndex = 0;
            this.AddTechnicStatusMenuStrip.Text = "menuStrip1";
            // 
            // добавитьСтатусToolStripMenuItem
            // 
            this.добавитьСтатусToolStripMenuItem.Name = "добавитьСтатусToolStripMenuItem";
            this.добавитьСтатусToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.добавитьСтатусToolStripMenuItem.Text = "Добавить статус";
            this.добавитьСтатусToolStripMenuItem.Click += new System.EventHandler(this.добавитьСтатусToolStripMenuItem_Click);
            // 
            // TechnicStatusesFormGridView
            // 
            this.TechnicStatusesFormGridView.AllowUserToAddRows = false;
            this.TechnicStatusesFormGridView.AllowUserToDeleteRows = false;
            this.TechnicStatusesFormGridView.AllowUserToOrderColumns = true;
            this.TechnicStatusesFormGridView.AllowUserToResizeColumns = false;
            this.TechnicStatusesFormGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TechnicStatusesFormGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TechnicStatusesFormGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TechnicStatusesFormGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TechnicStatusesFormGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TechnicStatusesFormGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TechnicStatusesFormGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.TechnicStatusesFormGridView.Location = new System.Drawing.Point(12, 27);
            this.TechnicStatusesFormGridView.Name = "TechnicStatusesFormGridView";
            this.TechnicStatusesFormGridView.ReadOnly = true;
            this.TechnicStatusesFormGridView.Size = new System.Drawing.Size(296, 384);
            this.TechnicStatusesFormGridView.TabIndex = 1;
            this.TechnicStatusesFormGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TechnicStatusesFormGridView_CellMouseDoubleClick);
            this.TechnicStatusesFormGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TechnicStatusesFormGridView_KeyDown);
            // 
            // TechnicStatuses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 423);
            this.Controls.Add(this.TechnicStatusesFormGridView);
            this.Controls.Add(this.AddTechnicStatusMenuStrip);
            this.MainMenuStrip = this.AddTechnicStatusMenuStrip;
            this.Name = "TechnicStatuses";
            this.Text = "Статусы техника";
            this.AddTechnicStatusMenuStrip.ResumeLayout(false);
            this.AddTechnicStatusMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TechnicStatusesFormGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip AddTechnicStatusMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem добавитьСтатусToolStripMenuItem;
        private System.Windows.Forms.DataGridView TechnicStatusesFormGridView;
    }
}