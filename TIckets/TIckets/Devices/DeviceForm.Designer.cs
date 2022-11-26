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
            this.DeviceFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.выгрузкаВExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.deviceFormGridView)).BeginInit();
            this.DeviceFormMenuStrip.SuspendLayout();
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
            // DeviceFormMenuStrip
            // 
            this.DeviceFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выгрузкаВExcelToolStripMenuItem});
            this.DeviceFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.DeviceFormMenuStrip.Name = "DeviceFormMenuStrip";
            this.DeviceFormMenuStrip.Size = new System.Drawing.Size(484, 24);
            this.DeviceFormMenuStrip.TabIndex = 1;
            this.DeviceFormMenuStrip.Text = "menuStrip1";
            // 
            // выгрузкаВExcelToolStripMenuItem
            // 
            this.выгрузкаВExcelToolStripMenuItem.Name = "выгрузкаВExcelToolStripMenuItem";
            this.выгрузкаВExcelToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.выгрузкаВExcelToolStripMenuItem.Text = "Выгрузка в Excel";
            this.выгрузкаВExcelToolStripMenuItem.Click += new System.EventHandler(this.выгрузкаВExcelToolStripMenuItem_Click);
            // 
            // DeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 599);
            this.Controls.Add(this.deviceFormGridView);
            this.Controls.Add(this.DeviceFormMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.DeviceFormMenuStrip;
            this.MaximizeBox = false;
            this.Name = "DeviceForm";
            this.Text = "Оборудование на складе";
            ((System.ComponentModel.ISupportInitialize)(this.deviceFormGridView)).EndInit();
            this.DeviceFormMenuStrip.ResumeLayout(false);
            this.DeviceFormMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView deviceFormGridView;
        private System.Windows.Forms.MenuStrip DeviceFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem выгрузкаВExcelToolStripMenuItem;
    }
}