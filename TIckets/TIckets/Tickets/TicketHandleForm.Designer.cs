namespace TIckets
{
    partial class TicketHandleForm
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
            this.ticketHandlerFormEditBtn = new System.Windows.Forms.Button();
            this.ticketHandlerFormCnlBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ticketHandlerFormTicketCommentTb = new System.Windows.Forms.Label();
            this.ticketHandlerFormUsedDeviceLbl = new System.Windows.Forms.Label();
            this.ticketUserNameCb = new System.Windows.Forms.ComboBox();
            this.ticketTechnicNameCb = new System.Windows.Forms.ComboBox();
            this.ticketTicketStatusCb = new System.Windows.Forms.ComboBox();
            this.ticketCommentCb = new System.Windows.Forms.TextBox();
            this.ticketDeviceCb = new System.Windows.Forms.ComboBox();
            this.ticketHandlerFormUserCommentLbl = new System.Windows.Forms.Label();
            this.ticketHandlerFormUserCommentTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ticketHandlerFormEditBtn
            // 
            this.ticketHandlerFormEditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ticketHandlerFormEditBtn.Location = new System.Drawing.Point(166, 419);
            this.ticketHandlerFormEditBtn.Name = "ticketHandlerFormEditBtn";
            this.ticketHandlerFormEditBtn.Size = new System.Drawing.Size(138, 40);
            this.ticketHandlerFormEditBtn.TabIndex = 0;
            this.ticketHandlerFormEditBtn.Text = "Редактировать";
            this.ticketHandlerFormEditBtn.UseVisualStyleBackColor = true;
            this.ticketHandlerFormEditBtn.Click += new System.EventHandler(this.ticketHandlerFormEditBtn_Click);
            // 
            // ticketHandlerFormCnlBtn
            // 
            this.ticketHandlerFormCnlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ticketHandlerFormCnlBtn.Location = new System.Drawing.Point(310, 419);
            this.ticketHandlerFormCnlBtn.Name = "ticketHandlerFormCnlBtn";
            this.ticketHandlerFormCnlBtn.Size = new System.Drawing.Size(138, 40);
            this.ticketHandlerFormCnlBtn.TabIndex = 2;
            this.ticketHandlerFormCnlBtn.Text = "Отмена";
            this.ticketHandlerFormCnlBtn.UseVisualStyleBackColor = true;
            this.ticketHandlerFormCnlBtn.Click += new System.EventHandler(this.ticketHandlerFormCnlBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Пользователь";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(224, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Назначенный техник";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Статус заявки";
            // 
            // ticketHandlerFormTicketCommentTb
            // 
            this.ticketHandlerFormTicketCommentTb.AutoSize = true;
            this.ticketHandlerFormTicketCommentTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ticketHandlerFormTicketCommentTb.Location = new System.Drawing.Point(12, 296);
            this.ticketHandlerFormTicketCommentTb.Name = "ticketHandlerFormTicketCommentTb";
            this.ticketHandlerFormTicketCommentTb.Size = new System.Drawing.Size(113, 20);
            this.ticketHandlerFormTicketCommentTb.TabIndex = 8;
            this.ticketHandlerFormTicketCommentTb.Text = "Комментарий";
            // 
            // ticketHandlerFormUsedDeviceLbl
            // 
            this.ticketHandlerFormUsedDeviceLbl.AutoSize = true;
            this.ticketHandlerFormUsedDeviceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ticketHandlerFormUsedDeviceLbl.Location = new System.Drawing.Point(224, 73);
            this.ticketHandlerFormUsedDeviceLbl.Name = "ticketHandlerFormUsedDeviceLbl";
            this.ticketHandlerFormUsedDeviceLbl.Size = new System.Drawing.Size(210, 20);
            this.ticketHandlerFormUsedDeviceLbl.TabIndex = 9;
            this.ticketHandlerFormUsedDeviceLbl.Text = "Используемые материалы";
            // 
            // ticketUserNameCb
            // 
            this.ticketUserNameCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ticketUserNameCb.FormattingEnabled = true;
            this.ticketUserNameCb.Location = new System.Drawing.Point(16, 32);
            this.ticketUserNameCb.Name = "ticketUserNameCb";
            this.ticketUserNameCb.Size = new System.Drawing.Size(206, 28);
            this.ticketUserNameCb.TabIndex = 10;
            // 
            // ticketTechnicNameCb
            // 
            this.ticketTechnicNameCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ticketTechnicNameCb.FormattingEnabled = true;
            this.ticketTechnicNameCb.Location = new System.Drawing.Point(228, 32);
            this.ticketTechnicNameCb.Name = "ticketTechnicNameCb";
            this.ticketTechnicNameCb.Size = new System.Drawing.Size(217, 28);
            this.ticketTechnicNameCb.TabIndex = 11;
            // 
            // ticketTicketStatusCb
            // 
            this.ticketTicketStatusCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ticketTicketStatusCb.FormattingEnabled = true;
            this.ticketTicketStatusCb.Location = new System.Drawing.Point(16, 96);
            this.ticketTicketStatusCb.Name = "ticketTicketStatusCb";
            this.ticketTicketStatusCb.Size = new System.Drawing.Size(203, 28);
            this.ticketTicketStatusCb.TabIndex = 12;
            // 
            // ticketCommentCb
            // 
            this.ticketCommentCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ticketCommentCb.Location = new System.Drawing.Point(16, 319);
            this.ticketCommentCb.Multiline = true;
            this.ticketCommentCb.Name = "ticketCommentCb";
            this.ticketCommentCb.Size = new System.Drawing.Size(429, 94);
            this.ticketCommentCb.TabIndex = 15;
            // 
            // ticketDeviceCb
            // 
            this.ticketDeviceCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ticketDeviceCb.FormattingEnabled = true;
            this.ticketDeviceCb.Location = new System.Drawing.Point(228, 96);
            this.ticketDeviceCb.Name = "ticketDeviceCb";
            this.ticketDeviceCb.Size = new System.Drawing.Size(217, 28);
            this.ticketDeviceCb.TabIndex = 16;
            // 
            // ticketHandlerFormUserCommentLbl
            // 
            this.ticketHandlerFormUserCommentLbl.AutoSize = true;
            this.ticketHandlerFormUserCommentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ticketHandlerFormUserCommentLbl.Location = new System.Drawing.Point(15, 139);
            this.ticketHandlerFormUserCommentLbl.Name = "ticketHandlerFormUserCommentLbl";
            this.ticketHandlerFormUserCommentLbl.Size = new System.Drawing.Size(141, 20);
            this.ticketHandlerFormUserCommentLbl.TabIndex = 17;
            this.ticketHandlerFormUserCommentLbl.Text = "Текст обращения";
            // 
            // ticketHandlerFormUserCommentTb
            // 
            this.ticketHandlerFormUserCommentTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ticketHandlerFormUserCommentTb.Location = new System.Drawing.Point(16, 162);
            this.ticketHandlerFormUserCommentTb.Multiline = true;
            this.ticketHandlerFormUserCommentTb.Name = "ticketHandlerFormUserCommentTb";
            this.ticketHandlerFormUserCommentTb.ReadOnly = true;
            this.ticketHandlerFormUserCommentTb.Size = new System.Drawing.Size(429, 121);
            this.ticketHandlerFormUserCommentTb.TabIndex = 18;
            // 
            // TicketHandleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 471);
            this.Controls.Add(this.ticketHandlerFormUserCommentTb);
            this.Controls.Add(this.ticketHandlerFormUserCommentLbl);
            this.Controls.Add(this.ticketDeviceCb);
            this.Controls.Add(this.ticketCommentCb);
            this.Controls.Add(this.ticketTicketStatusCb);
            this.Controls.Add(this.ticketTechnicNameCb);
            this.Controls.Add(this.ticketUserNameCb);
            this.Controls.Add(this.ticketHandlerFormUsedDeviceLbl);
            this.Controls.Add(this.ticketHandlerFormTicketCommentTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ticketHandlerFormCnlBtn);
            this.Controls.Add(this.ticketHandlerFormEditBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TicketHandleForm";
            this.Text = "Заявка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ticketHandlerFormEditBtn;
        private System.Windows.Forms.Button ticketHandlerFormCnlBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ticketHandlerFormTicketCommentTb;
        private System.Windows.Forms.Label ticketHandlerFormUsedDeviceLbl;
        private System.Windows.Forms.ComboBox ticketUserNameCb;
        private System.Windows.Forms.ComboBox ticketTechnicNameCb;
        private System.Windows.Forms.ComboBox ticketTicketStatusCb;
        private System.Windows.Forms.TextBox ticketCommentCb;
        private System.Windows.Forms.ComboBox ticketDeviceCb;
        private System.Windows.Forms.Label ticketHandlerFormUserCommentLbl;
        private System.Windows.Forms.TextBox ticketHandlerFormUserCommentTb;
    }
}