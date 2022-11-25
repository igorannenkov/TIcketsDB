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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AddTypeMenuStrip = new System.Windows.Forms.MenuStrip();
            this.добавитьКатегориюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeviceTypesGridView = new System.Windows.Forms.DataGridView();
            this.AddTypeMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeviceTypesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddTypeMenuStrip
            // 
            this.AddTypeMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьКатегориюToolStripMenuItem});
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeviceTypesGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DeviceTypesGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeviceTypesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DeviceTypesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DeviceTypesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DeviceTypesGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.DeviceTypesGridView.Location = new System.Drawing.Point(12, 27);
            this.DeviceTypesGridView.Name = "DeviceTypesGridView";
            this.DeviceTypesGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DeviceTypesGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeviceTypesGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DeviceTypesGridView.Size = new System.Drawing.Size(336, 429);
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