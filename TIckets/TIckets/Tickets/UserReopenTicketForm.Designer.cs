namespace TIckets.Tickets
{
    partial class TicketReopenForm
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
            this.TicketReopenFormBtn = new System.Windows.Forms.Button();
            this.TicketReopenFormCnlBtn = new System.Windows.Forms.Button();
            this.userReopenTicketTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TicketReopenFormBtn
            // 
            this.TicketReopenFormBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TicketReopenFormBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TicketReopenFormBtn.Location = new System.Drawing.Point(411, 253);
            this.TicketReopenFormBtn.Name = "TicketReopenFormBtn";
            this.TicketReopenFormBtn.Size = new System.Drawing.Size(120, 37);
            this.TicketReopenFormBtn.TabIndex = 0;
            this.TicketReopenFormBtn.Text = "Переоткрыть";
            this.TicketReopenFormBtn.UseVisualStyleBackColor = true;
            this.TicketReopenFormBtn.Click += new System.EventHandler(this.TicketReopenFormBtn_Click);
            // 
            // TicketReopenFormCnlBtn
            // 
            this.TicketReopenFormCnlBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TicketReopenFormCnlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TicketReopenFormCnlBtn.Location = new System.Drawing.Point(537, 254);
            this.TicketReopenFormCnlBtn.Name = "TicketReopenFormCnlBtn";
            this.TicketReopenFormCnlBtn.Size = new System.Drawing.Size(108, 36);
            this.TicketReopenFormCnlBtn.TabIndex = 1;
            this.TicketReopenFormCnlBtn.Text = "Отмена";
            this.TicketReopenFormCnlBtn.UseVisualStyleBackColor = true;
            this.TicketReopenFormCnlBtn.Click += new System.EventHandler(this.TicketReopenFormCnlBtn_Click);
            // 
            // userReopenTicketTb
            // 
            this.userReopenTicketTb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userReopenTicketTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userReopenTicketTb.Location = new System.Drawing.Point(12, 13);
            this.userReopenTicketTb.Multiline = true;
            this.userReopenTicketTb.Name = "userReopenTicketTb";
            this.userReopenTicketTb.Size = new System.Drawing.Size(633, 235);
            this.userReopenTicketTb.TabIndex = 2;
            // 
            // TicketReopenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 298);
            this.Controls.Add(this.userReopenTicketTb);
            this.Controls.Add(this.TicketReopenFormCnlBtn);
            this.Controls.Add(this.TicketReopenFormBtn);
            this.Name = "TicketReopenForm";
            this.Text = "Переоткрытие заявки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TicketReopenFormBtn;
        private System.Windows.Forms.Button TicketReopenFormCnlBtn;
        private System.Windows.Forms.TextBox userReopenTicketTb;
    }
}