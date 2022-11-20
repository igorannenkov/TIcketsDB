namespace TIckets
{
    partial class AuthorizationForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ShowAdmBtn = new System.Windows.Forms.Button();
            this.ShowTechnicBtn = new System.Windows.Forms.Button();
            this.ShowUserBtn = new System.Windows.Forms.Button();
            this.authUserNameLbl = new System.Windows.Forms.Label();
            this.authUserPwdLbl = new System.Windows.Forms.Label();
            this.authUserNameTb = new System.Windows.Forms.TextBox();
            this.authUserPwdTb = new System.Windows.Forms.TextBox();
            this.authEnterBtn = new System.Windows.Forms.Button();
            this.authLinkedLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // ShowAdmBtn
            // 
            this.ShowAdmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowAdmBtn.Location = new System.Drawing.Point(16, 31);
            this.ShowAdmBtn.Name = "ShowAdmBtn";
            this.ShowAdmBtn.Size = new System.Drawing.Size(43, 40);
            this.ShowAdmBtn.TabIndex = 0;
            this.ShowAdmBtn.Text = "А";
            this.ShowAdmBtn.UseVisualStyleBackColor = true;
            this.ShowAdmBtn.Click += new System.EventHandler(this.ShowAdmBtn_Click);
            // 
            // ShowTechnicBtn
            // 
            this.ShowTechnicBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowTechnicBtn.Location = new System.Drawing.Point(16, 123);
            this.ShowTechnicBtn.Name = "ShowTechnicBtn";
            this.ShowTechnicBtn.Size = new System.Drawing.Size(43, 40);
            this.ShowTechnicBtn.TabIndex = 1;
            this.ShowTechnicBtn.Text = "Т";
            this.ShowTechnicBtn.UseVisualStyleBackColor = true;
            this.ShowTechnicBtn.Click += new System.EventHandler(this.ShowTechnicBtn_Click);
            // 
            // ShowUserBtn
            // 
            this.ShowUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowUserBtn.Location = new System.Drawing.Point(16, 77);
            this.ShowUserBtn.Name = "ShowUserBtn";
            this.ShowUserBtn.Size = new System.Drawing.Size(43, 40);
            this.ShowUserBtn.TabIndex = 2;
            this.ShowUserBtn.Text = "П";
            this.ShowUserBtn.UseVisualStyleBackColor = true;
            this.ShowUserBtn.Click += new System.EventHandler(this.ShowUserBtn_Click);
            // 
            // authUserNameLbl
            // 
            this.authUserNameLbl.AutoSize = true;
            this.authUserNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authUserNameLbl.Location = new System.Drawing.Point(76, 9);
            this.authUserNameLbl.Name = "authUserNameLbl";
            this.authUserNameLbl.Size = new System.Drawing.Size(55, 20);
            this.authUserNameLbl.TabIndex = 4;
            this.authUserNameLbl.Text = "Логин";
            // 
            // authUserPwdLbl
            // 
            this.authUserPwdLbl.AutoSize = true;
            this.authUserPwdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authUserPwdLbl.Location = new System.Drawing.Point(76, 62);
            this.authUserPwdLbl.Name = "authUserPwdLbl";
            this.authUserPwdLbl.Size = new System.Drawing.Size(67, 20);
            this.authUserPwdLbl.TabIndex = 5;
            this.authUserPwdLbl.Text = "Пароль";
            // 
            // authUserNameTb
            // 
            this.authUserNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authUserNameTb.Location = new System.Drawing.Point(80, 32);
            this.authUserNameTb.Name = "authUserNameTb";
            this.authUserNameTb.Size = new System.Drawing.Size(149, 26);
            this.authUserNameTb.TabIndex = 6;
            this.authUserNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // authUserPwdTb
            // 
            this.authUserPwdTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authUserPwdTb.Location = new System.Drawing.Point(80, 85);
            this.authUserPwdTb.Name = "authUserPwdTb";
            this.authUserPwdTb.PasswordChar = '*';
            this.authUserPwdTb.Size = new System.Drawing.Size(149, 26);
            this.authUserPwdTb.TabIndex = 7;
            this.authUserPwdTb.Text = "1234567890";
            this.authUserPwdTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // authEnterBtn
            // 
            this.authEnterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authEnterBtn.Location = new System.Drawing.Point(80, 127);
            this.authEnterBtn.Name = "authEnterBtn";
            this.authEnterBtn.Size = new System.Drawing.Size(149, 36);
            this.authEnterBtn.TabIndex = 8;
            this.authEnterBtn.Text = "Войти";
            this.authEnterBtn.UseVisualStyleBackColor = true;
            this.authEnterBtn.Click += new System.EventHandler(this.authEnterBtn_Click);
            // 
            // authLinkedLabel
            // 
            this.authLinkedLabel.AutoSize = true;
            this.authLinkedLabel.LinkColor = System.Drawing.Color.Gray;
            this.authLinkedLabel.Location = new System.Drawing.Point(93, 175);
            this.authLinkedLabel.Name = "authLinkedLabel";
            this.authLinkedLabel.Size = new System.Drawing.Size(127, 26);
            this.authLinkedLabel.TabIndex = 9;
            this.authLinkedLabel.TabStop = true;
            this.authLinkedLabel.Text = "Требуется регистрация\r\nили сброс пароля ";
            this.authLinkedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.authLinkedLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.authLinkedLabel_LinkClicked);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 221);
            this.Controls.Add(this.authLinkedLabel);
            this.Controls.Add(this.authEnterBtn);
            this.Controls.Add(this.authUserPwdTb);
            this.Controls.Add(this.authUserNameTb);
            this.Controls.Add(this.authUserPwdLbl);
            this.Controls.Add(this.authUserNameLbl);
            this.Controls.Add(this.ShowUserBtn);
            this.Controls.Add(this.ShowTechnicBtn);
            this.Controls.Add(this.ShowAdmBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ShowAdmBtn;
        private System.Windows.Forms.Button ShowTechnicBtn;
        private System.Windows.Forms.Button ShowUserBtn;
        private System.Windows.Forms.Label authUserNameLbl;
        private System.Windows.Forms.Label authUserPwdLbl;
        private System.Windows.Forms.TextBox authUserNameTb;
        private System.Windows.Forms.TextBox authUserPwdTb;
        private System.Windows.Forms.Button authEnterBtn;
        private System.Windows.Forms.LinkLabel authLinkedLabel;
    }
}

