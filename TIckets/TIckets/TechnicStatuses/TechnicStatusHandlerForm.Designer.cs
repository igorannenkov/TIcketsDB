namespace TIckets.Admin.TechnicStatuses
{
    partial class TechnicStatusHandlerForm
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
            this.TechnicStatusHandlerFormEditBtn = new System.Windows.Forms.Button();
            this.TechnicStatusHandlerFormAddBtn = new System.Windows.Forms.Button();
            this.TechnicStatusHandlerFormCnlBtn = new System.Windows.Forms.Button();
            this.TechnicStatusHandlerFormStatusNameLbl = new System.Windows.Forms.Label();
            this.TechnicStatusHandlerFormStatusNameTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TechnicStatusHandlerFormEditBtn
            // 
            this.TechnicStatusHandlerFormEditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TechnicStatusHandlerFormEditBtn.Location = new System.Drawing.Point(16, 64);
            this.TechnicStatusHandlerFormEditBtn.Name = "TechnicStatusHandlerFormEditBtn";
            this.TechnicStatusHandlerFormEditBtn.Size = new System.Drawing.Size(139, 45);
            this.TechnicStatusHandlerFormEditBtn.TabIndex = 0;
            this.TechnicStatusHandlerFormEditBtn.Text = "Редактировать";
            this.TechnicStatusHandlerFormEditBtn.UseVisualStyleBackColor = true;
            this.TechnicStatusHandlerFormEditBtn.Click += new System.EventHandler(this.TechnicStatusHandlerFormEditBtn_Click);
            // 
            // TechnicStatusHandlerFormAddBtn
            // 
            this.TechnicStatusHandlerFormAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TechnicStatusHandlerFormAddBtn.Location = new System.Drawing.Point(161, 64);
            this.TechnicStatusHandlerFormAddBtn.Name = "TechnicStatusHandlerFormAddBtn";
            this.TechnicStatusHandlerFormAddBtn.Size = new System.Drawing.Size(139, 45);
            this.TechnicStatusHandlerFormAddBtn.TabIndex = 1;
            this.TechnicStatusHandlerFormAddBtn.Text = "Добавить";
            this.TechnicStatusHandlerFormAddBtn.UseVisualStyleBackColor = true;
            this.TechnicStatusHandlerFormAddBtn.Click += new System.EventHandler(this.TechnicStatusHandlerFormAddBtn_Click);
            // 
            // TechnicStatusHandlerFormCnlBtn
            // 
            this.TechnicStatusHandlerFormCnlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TechnicStatusHandlerFormCnlBtn.Location = new System.Drawing.Point(306, 65);
            this.TechnicStatusHandlerFormCnlBtn.Name = "TechnicStatusHandlerFormCnlBtn";
            this.TechnicStatusHandlerFormCnlBtn.Size = new System.Drawing.Size(139, 44);
            this.TechnicStatusHandlerFormCnlBtn.TabIndex = 2;
            this.TechnicStatusHandlerFormCnlBtn.Text = "Отмена";
            this.TechnicStatusHandlerFormCnlBtn.UseVisualStyleBackColor = true;
            this.TechnicStatusHandlerFormCnlBtn.Click += new System.EventHandler(this.TechnicStatusHandlerFormCnlBtn_Click);
            // 
            // TechnicStatusHandlerFormStatusNameLbl
            // 
            this.TechnicStatusHandlerFormStatusNameLbl.AutoSize = true;
            this.TechnicStatusHandlerFormStatusNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TechnicStatusHandlerFormStatusNameLbl.Location = new System.Drawing.Point(12, 9);
            this.TechnicStatusHandlerFormStatusNameLbl.Name = "TechnicStatusHandlerFormStatusNameLbl";
            this.TechnicStatusHandlerFormStatusNameLbl.Size = new System.Drawing.Size(185, 20);
            this.TechnicStatusHandlerFormStatusNameLbl.TabIndex = 3;
            this.TechnicStatusHandlerFormStatusNameLbl.Text = "Наименование статуса";
            // 
            // TechnicStatusHandlerFormStatusNameTb
            // 
            this.TechnicStatusHandlerFormStatusNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TechnicStatusHandlerFormStatusNameTb.Location = new System.Drawing.Point(16, 32);
            this.TechnicStatusHandlerFormStatusNameTb.Name = "TechnicStatusHandlerFormStatusNameTb";
            this.TechnicStatusHandlerFormStatusNameTb.Size = new System.Drawing.Size(429, 26);
            this.TechnicStatusHandlerFormStatusNameTb.TabIndex = 4;
            // 
            // TechnicStatusHandlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 120);
            this.Controls.Add(this.TechnicStatusHandlerFormStatusNameTb);
            this.Controls.Add(this.TechnicStatusHandlerFormStatusNameLbl);
            this.Controls.Add(this.TechnicStatusHandlerFormCnlBtn);
            this.Controls.Add(this.TechnicStatusHandlerFormAddBtn);
            this.Controls.Add(this.TechnicStatusHandlerFormEditBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TechnicStatusHandlerForm";
            this.Text = "Добавление статуса техника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TechnicStatusHandlerFormEditBtn;
        private System.Windows.Forms.Button TechnicStatusHandlerFormAddBtn;
        private System.Windows.Forms.Button TechnicStatusHandlerFormCnlBtn;
        private System.Windows.Forms.Label TechnicStatusHandlerFormStatusNameLbl;
        private System.Windows.Forms.TextBox TechnicStatusHandlerFormStatusNameTb;
    }
}