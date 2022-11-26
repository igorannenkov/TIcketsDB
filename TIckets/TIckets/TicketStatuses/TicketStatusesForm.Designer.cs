namespace TIckets
{
    partial class TicketStatusesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TicketStatusesFormGridView = new System.Windows.Forms.DataGridView();
            this.AddTicketStatusMenuStrip = new System.Windows.Forms.MenuStrip();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.TicketStatusesFormGridView)).BeginInit();
            this.AddTicketStatusMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TicketStatusesFormGridView
            // 
            this.TicketStatusesFormGridView.AllowUserToAddRows = false;
            this.TicketStatusesFormGridView.AllowUserToDeleteRows = false;
            this.TicketStatusesFormGridView.AllowUserToResizeColumns = false;
            this.TicketStatusesFormGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TicketStatusesFormGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TicketStatusesFormGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TicketStatusesFormGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TicketStatusesFormGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TicketStatusesFormGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TicketStatusesFormGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.TicketStatusesFormGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TicketStatusesFormGridView.Location = new System.Drawing.Point(0, 24);
            this.TicketStatusesFormGridView.Name = "TicketStatusesFormGridView";
            this.TicketStatusesFormGridView.ReadOnly = true;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TicketStatusesFormGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.TicketStatusesFormGridView.Size = new System.Drawing.Size(305, 426);
            this.TicketStatusesFormGridView.TabIndex = 0;
            this.TicketStatusesFormGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TicketStatusesFormGridView_CellMouseDoubleClick);
            this.TicketStatusesFormGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TicketStatusesFormGridView_KeyDown);
            // 
            // AddTicketStatusMenuStrip
            // 
            this.AddTicketStatusMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem});
            this.AddTicketStatusMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.AddTicketStatusMenuStrip.Name = "AddTicketStatusMenuStrip";
            this.AddTicketStatusMenuStrip.Size = new System.Drawing.Size(305, 24);
            this.AddTicketStatusMenuStrip.TabIndex = 1;
            this.AddTicketStatusMenuStrip.Text = "menuStrip1";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.добавитьToolStripMenuItem.Text = "Добавить статус";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // TicketStatusesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 450);
            this.Controls.Add(this.TicketStatusesFormGridView);
            this.Controls.Add(this.AddTicketStatusMenuStrip);
            this.MainMenuStrip = this.AddTicketStatusMenuStrip;
            this.Name = "TicketStatusesForm";
            this.Text = "Статусы заявок";
            ((System.ComponentModel.ISupportInitialize)(this.TicketStatusesFormGridView)).EndInit();
            this.AddTicketStatusMenuStrip.ResumeLayout(false);
            this.AddTicketStatusMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TicketStatusesFormGridView;
        private System.Windows.Forms.MenuStrip AddTicketStatusMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
    }
}