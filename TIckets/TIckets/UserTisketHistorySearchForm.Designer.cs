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
            this.historySearchGridView = new System.Windows.Forms.DataGridView();
            this.ticketHistorySearchTb = new System.Windows.Forms.TextBox();
            this.ticketHistorySearchBtn = new System.Windows.Forms.Button();
            this.ticketHistoryCnlBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.historySearchGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // historySearchGridView
            // 
            this.historySearchGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historySearchGridView.Location = new System.Drawing.Point(3, 42);
            this.historySearchGridView.Name = "historySearchGridView";
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
            this.ticketHistoryCnlBtn.Location = new System.Drawing.Point(355, 7);
            this.ticketHistoryCnlBtn.Name = "ticketHistoryCnlBtn";
            this.ticketHistoryCnlBtn.Size = new System.Drawing.Size(109, 30);
            this.ticketHistoryCnlBtn.TabIndex = 3;
            this.ticketHistoryCnlBtn.Text = "Отмена";
            this.ticketHistoryCnlBtn.UseVisualStyleBackColor = true;
            this.ticketHistoryCnlBtn.Click += new System.EventHandler(this.ticketHistoryCnlBtn_Click);
            // 
            // UserTisketHistorySearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 450);
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
    }
}