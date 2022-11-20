namespace TIckets
{
    partial class UserAddTicketForm
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
            this.userAddTicketBtn = new System.Windows.Forms.Button();
            this.userAddTicketTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // userAddTicketBtn
            // 
            this.userAddTicketBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userAddTicketBtn.Location = new System.Drawing.Point(339, 140);
            this.userAddTicketBtn.Name = "userAddTicketBtn";
            this.userAddTicketBtn.Size = new System.Drawing.Size(111, 36);
            this.userAddTicketBtn.TabIndex = 0;
            this.userAddTicketBtn.Text = "Отправить";
            this.userAddTicketBtn.UseVisualStyleBackColor = true;
            this.userAddTicketBtn.Click += new System.EventHandler(this.userAddTicketBtn_Click);
            // 
            // userAddTicketTb
            // 
            this.userAddTicketTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userAddTicketTb.Location = new System.Drawing.Point(12, 12);
            this.userAddTicketTb.Multiline = true;
            this.userAddTicketTb.Name = "userAddTicketTb";
            this.userAddTicketTb.Size = new System.Drawing.Size(438, 122);
            this.userAddTicketTb.TabIndex = 1;
            // 
            // UserAddTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 186);
            this.Controls.Add(this.userAddTicketTb);
            this.Controls.Add(this.userAddTicketBtn);
            this.Name = "UserAddTicketForm";
            this.Text = "Новый запрос";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button userAddTicketBtn;
        private System.Windows.Forms.TextBox userAddTicketTb;
    }
}