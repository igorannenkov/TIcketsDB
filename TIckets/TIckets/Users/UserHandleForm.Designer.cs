namespace TIckets
{
    partial class UserHandleForm
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
            this.UserHandlerFormEditBtn = new System.Windows.Forms.Button();
            this.UserHandlerFormAddBtn = new System.Windows.Forms.Button();
            this.UserHandlerFormCnlBtn = new System.Windows.Forms.Button();
            this.UserHandlerFormRoleNameLbl = new System.Windows.Forms.Label();
            this.UserHandlerFormUserNameTb = new System.Windows.Forms.TextBox();
            this.UserHandlerFormUserRoleLbl = new System.Windows.Forms.Label();
            this.UserHandlerFormUserRoleCb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // UserHandlerFormEditBtn
            // 
            this.UserHandlerFormEditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserHandlerFormEditBtn.Location = new System.Drawing.Point(12, 117);
            this.UserHandlerFormEditBtn.Name = "UserHandlerFormEditBtn";
            this.UserHandlerFormEditBtn.Size = new System.Drawing.Size(139, 44);
            this.UserHandlerFormEditBtn.TabIndex = 0;
            this.UserHandlerFormEditBtn.Text = "Редактировать";
            this.UserHandlerFormEditBtn.UseVisualStyleBackColor = true;
            this.UserHandlerFormEditBtn.Click += new System.EventHandler(this.UserHandlerFormEditBtn_Click);
            // 
            // UserHandlerFormAddBtn
            // 
            this.UserHandlerFormAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserHandlerFormAddBtn.Location = new System.Drawing.Point(157, 117);
            this.UserHandlerFormAddBtn.Name = "UserHandlerFormAddBtn";
            this.UserHandlerFormAddBtn.Size = new System.Drawing.Size(139, 44);
            this.UserHandlerFormAddBtn.TabIndex = 1;
            this.UserHandlerFormAddBtn.Text = "Добавить";
            this.UserHandlerFormAddBtn.UseVisualStyleBackColor = true;
            this.UserHandlerFormAddBtn.Click += new System.EventHandler(this.UserHandlerFormAddBtn_Click);
            // 
            // UserHandlerFormCnlBtn
            // 
            this.UserHandlerFormCnlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserHandlerFormCnlBtn.Location = new System.Drawing.Point(302, 117);
            this.UserHandlerFormCnlBtn.Name = "UserHandlerFormCnlBtn";
            this.UserHandlerFormCnlBtn.Size = new System.Drawing.Size(139, 44);
            this.UserHandlerFormCnlBtn.TabIndex = 2;
            this.UserHandlerFormCnlBtn.Text = "Отмена";
            this.UserHandlerFormCnlBtn.UseVisualStyleBackColor = true;
            this.UserHandlerFormCnlBtn.Click += new System.EventHandler(this.UserHandlerFormCnlBtn_Click);
            // 
            // UserHandlerFormRoleNameLbl
            // 
            this.UserHandlerFormRoleNameLbl.AutoSize = true;
            this.UserHandlerFormRoleNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserHandlerFormRoleNameLbl.Location = new System.Drawing.Point(12, 9);
            this.UserHandlerFormRoleNameLbl.Name = "UserHandlerFormRoleNameLbl";
            this.UserHandlerFormRoleNameLbl.Size = new System.Drawing.Size(160, 20);
            this.UserHandlerFormRoleNameLbl.TabIndex = 3;
            this.UserHandlerFormRoleNameLbl.Text = "ФИО пользователя";
            // 
            // UserHandlerFormUserNameTb
            // 
            this.UserHandlerFormUserNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserHandlerFormUserNameTb.Location = new System.Drawing.Point(16, 32);
            this.UserHandlerFormUserNameTb.Name = "UserHandlerFormUserNameTb";
            this.UserHandlerFormUserNameTb.Size = new System.Drawing.Size(425, 26);
            this.UserHandlerFormUserNameTb.TabIndex = 4;
            // 
            // UserHandlerFormUserRoleLbl
            // 
            this.UserHandlerFormUserRoleLbl.AutoSize = true;
            this.UserHandlerFormUserRoleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserHandlerFormUserRoleLbl.Location = new System.Drawing.Point(12, 61);
            this.UserHandlerFormUserRoleLbl.Name = "UserHandlerFormUserRoleLbl";
            this.UserHandlerFormUserRoleLbl.Size = new System.Drawing.Size(160, 20);
            this.UserHandlerFormUserRoleLbl.TabIndex = 5;
            this.UserHandlerFormUserRoleLbl.Text = "Роль пользователя";
            // 
            // UserHandlerFormUserRoleCb
            // 
            this.UserHandlerFormUserRoleCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserHandlerFormUserRoleCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserHandlerFormUserRoleCb.FormattingEnabled = true;
            this.UserHandlerFormUserRoleCb.Location = new System.Drawing.Point(16, 83);
            this.UserHandlerFormUserRoleCb.Name = "UserHandlerFormUserRoleCb";
            this.UserHandlerFormUserRoleCb.Size = new System.Drawing.Size(425, 28);
            this.UserHandlerFormUserRoleCb.TabIndex = 6;
            // 
            // UserHandleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 176);
            this.Controls.Add(this.UserHandlerFormUserRoleCb);
            this.Controls.Add(this.UserHandlerFormUserRoleLbl);
            this.Controls.Add(this.UserHandlerFormUserNameTb);
            this.Controls.Add(this.UserHandlerFormRoleNameLbl);
            this.Controls.Add(this.UserHandlerFormCnlBtn);
            this.Controls.Add(this.UserHandlerFormAddBtn);
            this.Controls.Add(this.UserHandlerFormEditBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UserHandleForm";
            this.Text = "Пользователь";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UserHandlerFormEditBtn;
        private System.Windows.Forms.Button UserHandlerFormAddBtn;
        private System.Windows.Forms.Button UserHandlerFormCnlBtn;
        private System.Windows.Forms.Label UserHandlerFormRoleNameLbl;
        private System.Windows.Forms.TextBox UserHandlerFormUserNameTb;
        private System.Windows.Forms.Label UserHandlerFormUserRoleLbl;
        private System.Windows.Forms.ComboBox UserHandlerFormUserRoleCb;
    }
}