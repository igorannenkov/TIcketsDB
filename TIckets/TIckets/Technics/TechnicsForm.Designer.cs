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
            this.добавитьТехникаToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.добавитьТехникаToolStripMenuItem.Text = "Добавить техника";
            this.добавитьТехникаToolStripMenuItem.Click += new System.EventHandler(this.добавитьТехникаToolStripMenuItem_Click);
            // 
            // TechnicHandlerFormGridView
            // 
            this.TechnicHandlerFormGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TechnicHandlerFormGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TechnicHandlerFormGridView.Location = new System.Drawing.Point(12, 27);
            this.TechnicHandlerFormGridView.Name = "TechnicHandlerFormGridView";
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