namespace TIckets.Admin.Tickets
{
    partial class TicketForm
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
            this.ticketMenuStrip = new System.Windows.Forms.MenuStrip();
            this.ticketsGridView = new System.Windows.Forms.DataGridView();
            this.новаяЗаявкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ticketMenuStrip
            // 
            this.ticketMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаяЗаявкаToolStripMenuItem});
            this.ticketMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ticketMenuStrip.Name = "ticketMenuStrip";
            this.ticketMenuStrip.Size = new System.Drawing.Size(885, 24);
            this.ticketMenuStrip.TabIndex = 0;
            this.ticketMenuStrip.Text = "menuStrip1";
            // 
            // ticketsGridView
            // 
            this.ticketsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketsGridView.Location = new System.Drawing.Point(12, 27);
            this.ticketsGridView.Name = "ticketsGridView";
            this.ticketsGridView.Size = new System.Drawing.Size(861, 429);
            this.ticketsGridView.TabIndex = 1;
            // 
            // новаяЗаявкаToolStripMenuItem
            // 
            this.новаяЗаявкаToolStripMenuItem.Name = "новаяЗаявкаToolStripMenuItem";
            this.новаяЗаявкаToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.новаяЗаявкаToolStripMenuItem.Text = "Новая заявка";
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 468);
            this.Controls.Add(this.ticketsGridView);
            this.Controls.Add(this.ticketMenuStrip);
            this.MainMenuStrip = this.ticketMenuStrip;
            this.Name = "TicketForm";
            this.Text = "Заявки";
            this.ticketMenuStrip.ResumeLayout(false);
            this.ticketMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ticketMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem новаяЗаявкаToolStripMenuItem;
        private System.Windows.Forms.DataGridView ticketsGridView;
    }
}