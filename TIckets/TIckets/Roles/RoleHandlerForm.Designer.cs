namespace TIckets
{
    partial class RoleHandlerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoleHandlerForm));
            this.RoleHandlerFormRoleNameLbl = new System.Windows.Forms.Label();
            this.RoleHandlerFormRoleNameTb = new System.Windows.Forms.TextBox();
            this.RoleHandlerFormAddBtn = new System.Windows.Forms.Button();
            this.RoleHandlerFormEditBtn = new System.Windows.Forms.Button();
            this.RoleHandlerFormCnlBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RoleHandlerFormRoleNameLbl
            // 
            this.RoleHandlerFormRoleNameLbl.AutoSize = true;
            this.RoleHandlerFormRoleNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoleHandlerFormRoleNameLbl.Location = new System.Drawing.Point(12, 9);
            this.RoleHandlerFormRoleNameLbl.Name = "RoleHandlerFormRoleNameLbl";
            this.RoleHandlerFormRoleNameLbl.Size = new System.Drawing.Size(163, 20);
            this.RoleHandlerFormRoleNameLbl.TabIndex = 1;
            this.RoleHandlerFormRoleNameLbl.Text = "Наименование роли";
            // 
            // RoleHandlerFormRoleNameTb
            // 
            this.RoleHandlerFormRoleNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoleHandlerFormRoleNameTb.Location = new System.Drawing.Point(13, 32);
            this.RoleHandlerFormRoleNameTb.Name = "RoleHandlerFormRoleNameTb";
            this.RoleHandlerFormRoleNameTb.Size = new System.Drawing.Size(432, 26);
            this.RoleHandlerFormRoleNameTb.TabIndex = 3;
            // 
            // RoleHandlerFormAddBtn
            // 
            this.RoleHandlerFormAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoleHandlerFormAddBtn.Location = new System.Drawing.Point(159, 64);
            this.RoleHandlerFormAddBtn.Name = "RoleHandlerFormAddBtn";
            this.RoleHandlerFormAddBtn.Size = new System.Drawing.Size(140, 40);
            this.RoleHandlerFormAddBtn.TabIndex = 4;
            this.RoleHandlerFormAddBtn.Text = "Добавить";
            this.RoleHandlerFormAddBtn.UseVisualStyleBackColor = true;
            this.RoleHandlerFormAddBtn.Click += new System.EventHandler(this.RoleHandleFormAddBtn_Click);
            // 
            // RoleHandlerFormEditBtn
            // 
            this.RoleHandlerFormEditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoleHandlerFormEditBtn.Location = new System.Drawing.Point(13, 64);
            this.RoleHandlerFormEditBtn.Name = "RoleHandlerFormEditBtn";
            this.RoleHandlerFormEditBtn.Size = new System.Drawing.Size(140, 40);
            this.RoleHandlerFormEditBtn.TabIndex = 5;
            this.RoleHandlerFormEditBtn.Text = "Редактировать";
            this.RoleHandlerFormEditBtn.UseVisualStyleBackColor = true;
            this.RoleHandlerFormEditBtn.Click += new System.EventHandler(this.RoleHandleFormEditBtn_Click);
            // 
            // RoleHandlerFormCnlBtn
            // 
            this.RoleHandlerFormCnlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoleHandlerFormCnlBtn.Location = new System.Drawing.Point(305, 64);
            this.RoleHandlerFormCnlBtn.Name = "RoleHandlerFormCnlBtn";
            this.RoleHandlerFormCnlBtn.Size = new System.Drawing.Size(140, 40);
            this.RoleHandlerFormCnlBtn.TabIndex = 6;
            this.RoleHandlerFormCnlBtn.Text = "Отмена";
            this.RoleHandlerFormCnlBtn.UseVisualStyleBackColor = true;
            this.RoleHandlerFormCnlBtn.Click += new System.EventHandler(this.RoleHandleFormCnlBtn_Click);
            // 
            // RoleHandlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 116);
            this.Controls.Add(this.RoleHandlerFormCnlBtn);
            this.Controls.Add(this.RoleHandlerFormEditBtn);
            this.Controls.Add(this.RoleHandlerFormAddBtn);
            this.Controls.Add(this.RoleHandlerFormRoleNameTb);
            this.Controls.Add(this.RoleHandlerFormRoleNameLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RoleHandlerForm";
            this.Text = "Роль";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label RoleHandlerFormRoleNameLbl;
        private System.Windows.Forms.TextBox RoleHandlerFormRoleNameTb;
        private System.Windows.Forms.Button RoleHandlerFormAddBtn;
        private System.Windows.Forms.Button RoleHandlerFormEditBtn;
        private System.Windows.Forms.Button RoleHandlerFormCnlBtn;
    }
}