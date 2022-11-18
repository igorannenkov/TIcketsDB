namespace TIckets
{
    partial class TechnicsForm
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
            this.AddTechnicMenuStrip = new System.Windows.Forms.MenuStrip();
            this.добавитьТехникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TechnicHandlerFormGridView = new System.Windows.Forms.DataGridView();
            this.AddTechnicMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TechnicHandlerFormGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddTechnicMenuStrip
            // 
            this.AddTechnicMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьТехникаToolStripMenuItem});
            this.AddTechnicMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.AddTechnicMenuStrip.Name = "AddTechnicMenuStrip";
            this.AddTechnicMenuStrip.Size = new System.Drawing.Size(560, 24);
            this.AddTechnicMenuStrip.TabIndex = 0;
            this.AddTechnicMenuStrip.Text = "menuStrip1";
            // 
            // добавитьТехникаToolStripMenuItem
            // 
            this.добавитьТехникаToolStripMenuItem.Name = "добавитьТехникаToolStripMenuItem";
            this.добавитьТехникаToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.добавитьТехникаToolStripMenuItem.Text = "Добавить техника";
            this.добавитьТехникаToolStripMenuItem.Click += new System.EventHandler(this.добавитьТехникаToolStripMenuItem_Click);
            // 
            // TechnicHandlerFormGridView
            // 
            this.TechnicHandlerFormGridView.AllowUserToAddRows = false;
            this.TechnicHandlerFormGridView.AllowUserToDeleteRows = false;
            this.TechnicHandlerFormGridView.AllowUserToResizeColumns = false;
            this.TechnicHandlerFormGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TechnicHandlerFormGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TechnicHandlerFormGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TechnicHandlerFormGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TechnicHandlerFormGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TechnicHandlerFormGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TechnicHandlerFormGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.TechnicHandlerFormGridView.Location = new System.Drawing.Point(12, 27);
            this.TechnicHandlerFormGridView.Name = "TechnicHandlerFormGridView";
            this.TechnicHandlerFormGridView.ReadOnly = true;
            this.TechnicHandlerFormGridView.Size = new System.Drawing.Size(534, 411);
            this.TechnicHandlerFormGridView.TabIndex = 1;
            this.TechnicHandlerFormGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TechnicHandlerFormGridView_CellMouseDoubleClick);
            this.TechnicHandlerFormGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TechnicHandlerFormGridView_KeyDown);
            // 
            // TechnicsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 450);
            this.Controls.Add(this.TechnicHandlerFormGridView);
            this.Controls.Add(this.AddTechnicMenuStrip);
            this.MainMenuStrip = this.AddTechnicMenuStrip;
            this.Name = "TechnicsForm";
            this.Text = "Техники";
            this.AddTechnicMenuStrip.ResumeLayout(false);
            this.AddTechnicMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TechnicHandlerFormGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip AddTechnicMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem добавитьТехникаToolStripMenuItem;
        private System.Windows.Forms.DataGridView TechnicHandlerFormGridView;
    }
}