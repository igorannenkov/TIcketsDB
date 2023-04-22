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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.authUserNameLbl = new System.Windows.Forms.Label();
            this.authUserPwdLbl = new System.Windows.Forms.Label();
            this.authUserNameTb = new System.Windows.Forms.TextBox();
            this.authUserPwdTb = new System.Windows.Forms.TextBox();
            this.authEnterBtn = new System.Windows.Forms.Button();
            this.authLinkedLabel = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // authUserNameLbl
            // 
            this.authUserNameLbl.AutoSize = true;
            this.authUserNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authUserNameLbl.Location = new System.Drawing.Point(110, 4);
            this.authUserNameLbl.Name = "authUserNameLbl";
            this.authUserNameLbl.Size = new System.Drawing.Size(55, 20);
            this.authUserNameLbl.TabIndex = 4;
            this.authUserNameLbl.Text = "Логин";
            // 
            // authUserPwdLbl
            // 
            this.authUserPwdLbl.AutoSize = true;
            this.authUserPwdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authUserPwdLbl.Location = new System.Drawing.Point(110, 62);
            this.authUserPwdLbl.Name = "authUserPwdLbl";
            this.authUserPwdLbl.Size = new System.Drawing.Size(67, 20);
            this.authUserPwdLbl.TabIndex = 5;
            this.authUserPwdLbl.Text = "Пароль";
            // 
            // authUserNameTb
            // 
            this.authUserNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authUserNameTb.Location = new System.Drawing.Point(39, 27);
            this.authUserNameTb.Name = "authUserNameTb";
            this.authUserNameTb.Size = new System.Drawing.Size(201, 26);
            this.authUserNameTb.TabIndex = 6;
            this.authUserNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // authUserPwdTb
            // 
            this.authUserPwdTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authUserPwdTb.Location = new System.Drawing.Point(39, 85);
            this.authUserPwdTb.Name = "authUserPwdTb";
            this.authUserPwdTb.PasswordChar = '*';
            this.authUserPwdTb.Size = new System.Drawing.Size(201, 26);
            this.authUserPwdTb.TabIndex = 7;
            this.authUserPwdTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.authUserPwdTb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.authUserPwdTb_KeyDown);
            // 
            // authEnterBtn
            // 
            this.authEnterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authEnterBtn.Location = new System.Drawing.Point(63, 128);
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
            this.authLinkedLabel.Location = new System.Drawing.Point(76, 176);
            this.authLinkedLabel.Name = "authLinkedLabel";
            this.authLinkedLabel.Size = new System.Drawing.Size(127, 26);
            this.authLinkedLabel.TabIndex = 9;
            this.authLinkedLabel.TabStop = true;
            this.authLinkedLabel.Text = "Требуется регистрация\r\nили сброс пароля ";
            this.authLinkedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.authLinkedLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.authLinkedLabel_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TIckets.Properties.Resources.User;
            this.pictureBox1.Location = new System.Drawing.Point(261, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 219);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.authLinkedLabel);
            this.Controls.Add(this.authEnterBtn);
            this.Controls.Add(this.authUserNameTb);
            this.Controls.Add(this.authUserPwdLbl);
            this.Controls.Add(this.authUserNameLbl);
            this.Controls.Add(this.authUserPwdTb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AuthorizationForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label authUserNameLbl;
        private System.Windows.Forms.Label authUserPwdLbl;
        private System.Windows.Forms.TextBox authUserNameTb;
        private System.Windows.Forms.TextBox authUserPwdTb;
        private System.Windows.Forms.Button authEnterBtn;
        private System.Windows.Forms.LinkLabel authLinkedLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

