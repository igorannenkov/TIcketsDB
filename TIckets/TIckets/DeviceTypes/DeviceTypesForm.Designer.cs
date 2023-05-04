namespace TIckets
{
    partial class DeviceTypesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeviceTypesForm));
            this.AddTypeMenuStrip = new System.Windows.Forms.MenuStrip();
            this.добавитьКатегориюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeviceTypesGridView = new System.Windows.Forms.DataGridView();
            this.AddTypeMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeviceTypesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddTypeMenuStrip
            // 
            this.AddTypeMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.AddTypeMenuStrip.Name = "AddTypeMenuStrip";
            this.AddTypeMenuStrip.Size = new System.Drawing.Size(360, 24);
            this.AddTypeMenuStrip.TabIndex = 0;
            this.AddTypeMenuStrip.Text = "menuStrip1";
            // 
            // добавитьКатегориюToolStripMenuItem
            // 
            this.добавитьКатегориюToolStripMenuItem.Name = "добавитьКатегориюToolStripMenuItem";
            this.добавитьКатегориюToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.добавитьКатегориюToolStripMenuItem.Text = "Новое устройство";
            this.добавитьКатегориюToolStripMenuItem.Click += new System.EventHandler(this.добавитьКатегориюToolStripMenuItem_Click);
            // 
            // DeviceTypesGridView
            // 
            this.DeviceTypesGridView.AllowUserToAddRows = false;
            this.DeviceTypesGridView.AllowUserToDeleteRows = false;
            this.DeviceTypesGridView.AllowUserToOrderColumns = true;
            this.DeviceTypesGridView.AllowUserToResizeColumns = false;
            this.DeviceTypesGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeviceTypesGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DeviceTypesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DeviceTypesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DeviceTypesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DeviceTypesGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.DeviceTypesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeviceTypesGridView.Location = new System.Drawing.Point(0, 24);
            this.DeviceTypesGridView.Name = "DeviceTypesGridView";
            this.DeviceTypesGridView.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DeviceTypesGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeviceTypesGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DeviceTypesGridView.Size = new System.Drawing.Size(360, 444);
            this.DeviceTypesGridView.TabIndex = 1;
            this.DeviceTypesGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DeviceTypesGridView_CellMouseDoubleClick);
            this.DeviceTypesGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DeviceTypesGridView_KeyDown);
            // 
            // DeviceTypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 468);
            this.Controls.Add(this.DeviceTypesGridView);
            this.Controls.Add(this.AddTypeMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.AddTypeMenuStrip;
            this.Name = "DeviceTypesForm";
            this.Text = "Техника и устройства";
            this.AddTypeMenuStrip.ResumeLayout(false);
            this.AddTypeMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeviceTypesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip AddTypeMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem добавитьКатегориюToolStripMenuItem;
        private System.Windows.Forms.DataGridView DeviceTypesGridView;
    }
}