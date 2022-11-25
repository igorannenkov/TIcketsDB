namespace TIckets.Tickets
{
    partial class UserReopenTicketForm
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
            this.userReopenTicketFormBtn = new System.Windows.Forms.Button();
            this.userReopenTicketFormCnlBtn = new System.Windows.Forms.Button();
            this.userReopenTicketTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // userReopenTicketFormBtn
            // 
            this.userReopenTicketFormBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.userReopenTicketFormBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userReopenTicketFormBtn.Location = new System.Drawing.Point(411, 253);
            this.userReopenTicketFormBtn.Name = "userReopenTicketFormBtn";
            this.userReopenTicketFormBtn.Size = new System.Drawing.Size(120, 37);
            this.userReopenTicketFormBtn.TabIndex = 0;
            this.userReopenTicketFormBtn.Text = "Переоткрыть";
            this.userReopenTicketFormBtn.UseVisualStyleBackColor = true;
            this.userReopenTicketFormBtn.Click += new System.EventHandler(this.userReopenTicketFormBtn_Click);
            // 
            // userReopenTicketFormCnlBtn
            // 
            this.userReopenTicketFormCnlBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.userReopenTicketFormCnlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userReopenTicketFormCnlBtn.Location = new System.Drawing.Point(537, 254);
            this.userReopenTicketFormCnlBtn.Name = "userReopenTicketFormCnlBtn";
            this.userReopenTicketFormCnlBtn.Size = new System.Drawing.Size(108, 36);
            this.userReopenTicketFormCnlBtn.TabIndex = 1;
            this.userReopenTicketFormCnlBtn.Text = "Отмена";
            this.userReopenTicketFormCnlBtn.UseVisualStyleBackColor = true;
            this.userReopenTicketFormCnlBtn.Click += new System.EventHandler(this.userReopenTicketFormCnlBtn_Click);
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
            // UserReopenTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 298);
            this.Controls.Add(this.userReopenTicketTb);
            this.Controls.Add(this.userReopenTicketFormCnlBtn);
            this.Controls.Add(this.userReopenTicketFormBtn);
            this.Name = "UserReopenTicketForm";
            this.Text = "Переоткрытие заявки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button userReopenTicketFormBtn;
        private System.Windows.Forms.Button userReopenTicketFormCnlBtn;
        private System.Windows.Forms.TextBox userReopenTicketTb;
    }
}