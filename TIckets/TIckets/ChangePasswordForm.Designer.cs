namespace TIckets
{
    partial class ChangePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.oldPwdTb = new System.Windows.Forms.TextBox();
            this.newPwdTb = new System.Windows.Forms.TextBox();
            this.confirmPwdTb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.PasswordStrengthLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ShowConfirmPwdBtn = new System.Windows.Forms.Button();
            this.ShowNewPwdBtn = new System.Windows.Forms.Button();
            this.ShowCurrentPwdBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(59, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Текущий пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(71, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Новый пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Подтверждение пароля";
            // 
            // oldPwdTb
            // 
            this.oldPwdTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oldPwdTb.Location = new System.Drawing.Point(188, 19);
            this.oldPwdTb.Name = "oldPwdTb";
            this.oldPwdTb.PasswordChar = '*';
            this.oldPwdTb.Size = new System.Drawing.Size(175, 26);
            this.oldPwdTb.TabIndex = 0;
            // 
            // newPwdTb
            // 
            this.newPwdTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newPwdTb.Location = new System.Drawing.Point(188, 51);
            this.newPwdTb.Name = "newPwdTb";
            this.newPwdTb.PasswordChar = '*';
            this.newPwdTb.Size = new System.Drawing.Size(175, 26);
            this.newPwdTb.TabIndex = 1;
            this.newPwdTb.TextChanged += new System.EventHandler(this.newPwdTb_TextChanged);
            // 
            // confirmPwdTb
            // 
            this.confirmPwdTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmPwdTb.Location = new System.Drawing.Point(188, 83);
            this.confirmPwdTb.Name = "confirmPwdTb";
            this.confirmPwdTb.PasswordChar = '*';
            this.confirmPwdTb.Size = new System.Drawing.Size(175, 26);
            this.confirmPwdTb.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(37, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(190, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 39);
            this.button2.TabIndex = 4;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PasswordStrengthLbl
            // 
            this.PasswordStrengthLbl.AutoSize = true;
            this.PasswordStrengthLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordStrengthLbl.ForeColor = System.Drawing.Color.Red;
            this.PasswordStrengthLbl.Location = new System.Drawing.Point(186, 115);
            this.PasswordStrengthLbl.Name = "PasswordStrengthLbl";
            this.PasswordStrengthLbl.Size = new System.Drawing.Size(79, 24);
            this.PasswordStrengthLbl.TabIndex = 5;
            this.PasswordStrengthLbl.Text = "Низкая";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(37, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Сложность пароля:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(26, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(351, 71);
            this.label5.TabIndex = 7;
            this.label5.Text = "Придумайте надежный пароль, который тяжело подобрать: от 8 симловов, содержащий ц" +
    "ифры, большие и маленькие английские буквы и спецсимволы.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ShowConfirmPwdBtn
            // 
            this.ShowConfirmPwdBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShowConfirmPwdBtn.BackgroundImage")));
            this.ShowConfirmPwdBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ShowConfirmPwdBtn.Location = new System.Drawing.Point(369, 83);
            this.ShowConfirmPwdBtn.Name = "ShowConfirmPwdBtn";
            this.ShowConfirmPwdBtn.Size = new System.Drawing.Size(25, 26);
            this.ShowConfirmPwdBtn.TabIndex = 8;
            this.ShowConfirmPwdBtn.UseVisualStyleBackColor = true;
            this.ShowConfirmPwdBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShowConfirmPwdBtn_MouseDown);
            this.ShowConfirmPwdBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShowConfirmPwdBtn_MouseUp);
            // 
            // ShowNewPwdBtn
            // 
            this.ShowNewPwdBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShowNewPwdBtn.BackgroundImage")));
            this.ShowNewPwdBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ShowNewPwdBtn.Location = new System.Drawing.Point(369, 51);
            this.ShowNewPwdBtn.Name = "ShowNewPwdBtn";
            this.ShowNewPwdBtn.Size = new System.Drawing.Size(25, 26);
            this.ShowNewPwdBtn.TabIndex = 8;
            this.ShowNewPwdBtn.UseVisualStyleBackColor = true;
            this.ShowNewPwdBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShowNewPwdBtn_MouseDown);
            this.ShowNewPwdBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShowNewPwdBtn_MouseUp);
            // 
            // ShowCurrentPwdBtn
            // 
            this.ShowCurrentPwdBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShowCurrentPwdBtn.BackgroundImage")));
            this.ShowCurrentPwdBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ShowCurrentPwdBtn.Location = new System.Drawing.Point(369, 20);
            this.ShowCurrentPwdBtn.Name = "ShowCurrentPwdBtn";
            this.ShowCurrentPwdBtn.Size = new System.Drawing.Size(25, 26);
            this.ShowCurrentPwdBtn.TabIndex = 8;
            this.ShowCurrentPwdBtn.UseVisualStyleBackColor = true;
            this.ShowCurrentPwdBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShowCurrentPwdBtn_MouseDown);
            this.ShowCurrentPwdBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShowCurrentPwdBtn_MouseUp);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 279);
            this.Controls.Add(this.ShowCurrentPwdBtn);
            this.Controls.Add(this.ShowNewPwdBtn);
            this.Controls.Add(this.ShowConfirmPwdBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PasswordStrengthLbl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.confirmPwdTb);
            this.Controls.Add(this.newPwdTb);
            this.Controls.Add(this.oldPwdTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChangePasswordForm";
            this.Text = "Смена пароля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox oldPwdTb;
        private System.Windows.Forms.TextBox newPwdTb;
        private System.Windows.Forms.TextBox confirmPwdTb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label PasswordStrengthLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ShowConfirmPwdBtn;
        private System.Windows.Forms.Button ShowNewPwdBtn;
        private System.Windows.Forms.Button ShowCurrentPwdBtn;
    }
}