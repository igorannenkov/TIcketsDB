namespace TIckets
{
    partial class DeviceForm
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
            this.deviceFormGridView = new System.Windows.Forms.DataGridView();
            this.deviceFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.добавитьУстройствоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.deviceFormGridView)).BeginInit();
            this.deviceFormMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // deviceFormGridView
            // 
            this.deviceFormGridView.AllowUserToAddRows = false;
            this.deviceFormGridView.AllowUserToDeleteRows = false;
            this.deviceFormGridView.AllowUserToResizeColumns = false;
            this.deviceFormGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deviceFormGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.deviceFormGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.deviceFormGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.deviceFormGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.deviceFormGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.deviceFormGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deviceFormGridView.Location = new System.Drawing.Point(0, 24);
            this.deviceFormGridView.Name = "deviceFormGridView";
            this.deviceFormGridView.ReadOnly = true;
            this.deviceFormGridView.Size = new System.Drawing.Size(484, 575);
            this.deviceFormGridView.TabIndex = 0;
            this.deviceFormGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.deviceFormGridView_CellMouseDoubleClick);
            // 
            // deviceFormMenuStrip
            // 
            this.deviceFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьУстройствоToolStripMenuItem});
            this.deviceFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.deviceFormMenuStrip.Name = "deviceFormMenuStrip";
            this.deviceFormMenuStrip.Size = new System.Drawing.Size(484, 24);
            this.deviceFormMenuStrip.TabIndex = 1;
            this.deviceFormMenuStrip.Text = "menuStrip1";
            // 
            // добавитьУстройствоToolStripMenuItem
            // 
            this.добавитьУстройствоToolStripMenuItem.Name = "добавитьУстройствоToolStripMenuItem";
            this.добавитьУстройствоToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.добавитьУстройствоToolStripMenuItem.Text = "Добавить устройство";
            this.добавитьУстройствоToolStripMenuItem.Click += new System.EventHandler(this.добавитьУстройствоToolStripMenuItem_Click);
            // 
            // DeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 599);
            this.Controls.Add(this.deviceFormGridView);
            this.Controls.Add(this.deviceFormMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.deviceFormMenuStrip;
            this.MaximizeBox = false;
            this.Name = "DeviceForm";
            this.Text = "Склад";
            ((System.ComponentModel.ISupportInitialize)(this.deviceFormGridView)).EndInit();
            this.deviceFormMenuStrip.ResumeLayout(false);
            this.deviceFormMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView deviceFormGridView;
        private System.Windows.Forms.MenuStrip deviceFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem добавитьУстройствоToolStripMenuItem;
    }
}