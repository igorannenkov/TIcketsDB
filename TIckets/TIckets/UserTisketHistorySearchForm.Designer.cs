namespace TIckets
{
    partial class UserTisketHistorySearchForm
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
            this.historySearchGridView = new System.Windows.Forms.DataGridView();
            this.ticketHistorySearchTb = new System.Windows.Forms.TextBox();
            this.ticketHistorySearchBtn = new System.Windows.Forms.Button();
            this.ticketHistoryCnlBtn = new System.Windows.Forms.Button();
            this.ticketHistoryExportBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.historySearchGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // historySearchGridView
            // 
            this.historySearchGridView.AllowUserToAddRows = false;
            this.historySearchGridView.AllowUserToDeleteRows = false;
            this.historySearchGridView.AllowUserToResizeColumns = false;
            this.historySearchGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.historySearchGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.historySearchGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.historySearchGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.historySearchGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.historySearchGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.historySearchGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.historySearchGridView.Location = new System.Drawing.Point(3, 42);
            this.historySearchGridView.Name = "historySearchGridView";
            this.historySearchGridView.ReadOnly = true;
            this.historySearchGridView.Size = new System.Drawing.Size(1183, 405);
            this.historySearchGridView.TabIndex = 0;
            // 
            // ticketHistorySearchTb
            // 
            this.ticketHistorySearchTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ticketHistorySearchTb.Location = new System.Drawing.Point(12, 9);
            this.ticketHistorySearchTb.Name = "ticketHistorySearchTb";
            this.ticketHistorySearchTb.Size = new System.Drawing.Size(225, 26);
            this.ticketHistorySearchTb.TabIndex = 1;
            // 
            // ticketHistorySearchBtn
            // 
            this.ticketHistorySearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ticketHistorySearchBtn.Location = new System.Drawing.Point(243, 7);
            this.ticketHistorySearchBtn.Name = "ticketHistorySearchBtn";
            this.ticketHistorySearchBtn.Size = new System.Drawing.Size(106, 30);
            this.ticketHistorySearchBtn.TabIndex = 2;
            this.ticketHistorySearchBtn.Text = "Поиск";
            this.ticketHistorySearchBtn.UseVisualStyleBackColor = true;
            this.ticketHistorySearchBtn.Click += new System.EventHandler(this.ticketHistorySearchBtn_Click);
            // 
            // ticketHistoryCnlBtn
            // 
            this.ticketHistoryCnlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ticketHistoryCnlBtn.Location = new System.Drawing.Point(506, 7);
            this.ticketHistoryCnlBtn.Name = "ticketHistoryCnlBtn";
            this.ticketHistoryCnlBtn.Size = new System.Drawing.Size(109, 30);
            this.ticketHistoryCnlBtn.TabIndex = 3;
            this.ticketHistoryCnlBtn.Text = "Отмена";
            this.ticketHistoryCnlBtn.UseVisualStyleBackColor = true;
            this.ticketHistoryCnlBtn.Click += new System.EventHandler(this.ticketHistoryCnlBtn_Click);
            // 
            // ticketHistoryExportBtn
            // 
            this.ticketHistoryExportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ticketHistoryExportBtn.Location = new System.Drawing.Point(355, 7);
            this.ticketHistoryExportBtn.Name = "ticketHistoryExportBtn";
            this.ticketHistoryExportBtn.Size = new System.Drawing.Size(145, 30);
            this.ticketHistoryExportBtn.TabIndex = 4;
            this.ticketHistoryExportBtn.Text = "Выгрузка в Excel";
            this.ticketHistoryExportBtn.UseVisualStyleBackColor = true;
            this.ticketHistoryExportBtn.Click += new System.EventHandler(this.ticketHistoryExportBtn_Click);
            // 
            // UserTisketHistorySearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 450);
            this.Controls.Add(this.ticketHistoryExportBtn);
            this.Controls.Add(this.ticketHistoryCnlBtn);
            this.Controls.Add(this.ticketHistorySearchBtn);
            this.Controls.Add(this.ticketHistorySearchTb);
            this.Controls.Add(this.historySearchGridView);
            this.Name = "UserTisketHistorySearchForm";
            this.Text = "История заявок пользователя";
            ((System.ComponentModel.ISupportInitialize)(this.historySearchGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView historySearchGridView;
        private System.Windows.Forms.TextBox ticketHistorySearchTb;
        private System.Windows.Forms.Button ticketHistorySearchBtn;
        private System.Windows.Forms.Button ticketHistoryCnlBtn;
        private System.Windows.Forms.Button ticketHistoryExportBtn;
    }
}