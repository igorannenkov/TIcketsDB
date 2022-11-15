namespace TIckets
{
    partial class RoleHandleForm
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
            this.RoleHandleFormRoleNameLbl = new System.Windows.Forms.Label();
            this.RoleHandleFormRoleNameTb = new System.Windows.Forms.TextBox();
            this.RoleHandleFormAddBtn = new System.Windows.Forms.Button();
            this.RoleHandleFormEditBtn = new System.Windows.Forms.Button();
            this.RoleHandleFormCnlBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RoleHandleFormRoleNameLbl
            // 
            this.RoleHandleFormRoleNameLbl.AutoSize = true;
            this.RoleHandleFormRoleNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoleHandleFormRoleNameLbl.Location = new System.Drawing.Point(12, 9);
            this.RoleHandleFormRoleNameLbl.Name = "RoleHandleFormRoleNameLbl";
            this.RoleHandleFormRoleNameLbl.Size = new System.Drawing.Size(163, 20);
            this.RoleHandleFormRoleNameLbl.TabIndex = 1;
            this.RoleHandleFormRoleNameLbl.Text = "Наименование роли";
            // 
            // RoleHandleFormRoleNameTb
            // 
            this.RoleHandleFormRoleNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoleHandleFormRoleNameTb.Location = new System.Drawing.Point(13, 32);
            this.RoleHandleFormRoleNameTb.Name = "RoleHandleFormRoleNameTb";
            this.RoleHandleFormRoleNameTb.Size = new System.Drawing.Size(432, 26);
            this.RoleHandleFormRoleNameTb.TabIndex = 3;
            // 
            // RoleHandleFormAddBtn
            // 
            this.RoleHandleFormAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoleHandleFormAddBtn.Location = new System.Drawing.Point(159, 64);
            this.RoleHandleFormAddBtn.Name = "RoleHandleFormAddBtn";
            this.RoleHandleFormAddBtn.Size = new System.Drawing.Size(140, 40);
            this.RoleHandleFormAddBtn.TabIndex = 4;
            this.RoleHandleFormAddBtn.Text = "Добавить";
            this.RoleHandleFormAddBtn.UseVisualStyleBackColor = true;
            this.RoleHandleFormAddBtn.Click += new System.EventHandler(this.RoleHandleFormAddBtn_Click);
            // 
            // RoleHandleFormEditBtn
            // 
            this.RoleHandleFormEditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoleHandleFormEditBtn.Location = new System.Drawing.Point(13, 64);
            this.RoleHandleFormEditBtn.Name = "RoleHandleFormEditBtn";
            this.RoleHandleFormEditBtn.Size = new System.Drawing.Size(140, 40);
            this.RoleHandleFormEditBtn.TabIndex = 5;
            this.RoleHandleFormEditBtn.Text = "Редактировать";
            this.RoleHandleFormEditBtn.UseVisualStyleBackColor = true;
            this.RoleHandleFormEditBtn.Click += new System.EventHandler(this.RoleHandleFormEditBtn_Click);
            // 
            // RoleHandleFormCnlBtn
            // 
            this.RoleHandleFormCnlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoleHandleFormCnlBtn.Location = new System.Drawing.Point(305, 64);
            this.RoleHandleFormCnlBtn.Name = "RoleHandleFormCnlBtn";
            this.RoleHandleFormCnlBtn.Size = new System.Drawing.Size(140, 40);
            this.RoleHandleFormCnlBtn.TabIndex = 6;
            this.RoleHandleFormCnlBtn.Text = "Отмена";
            this.RoleHandleFormCnlBtn.UseVisualStyleBackColor = true;
            this.RoleHandleFormCnlBtn.Click += new System.EventHandler(this.RoleHandleFormCnlBtn_Click);
            // 
            // RoleHandleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 116);
            this.Controls.Add(this.RoleHandleFormCnlBtn);
            this.Controls.Add(this.RoleHandleFormEditBtn);
            this.Controls.Add(this.RoleHandleFormAddBtn);
            this.Controls.Add(this.RoleHandleFormRoleNameTb);
            this.Controls.Add(this.RoleHandleFormRoleNameLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RoleHandleForm";
            this.Text = "Роль";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label RoleHandleFormRoleNameLbl;
        private System.Windows.Forms.TextBox RoleHandleFormRoleNameTb;
        private System.Windows.Forms.Button RoleHandleFormAddBtn;
        private System.Windows.Forms.Button RoleHandleFormEditBtn;
        private System.Windows.Forms.Button RoleHandleFormCnlBtn;
    }
}