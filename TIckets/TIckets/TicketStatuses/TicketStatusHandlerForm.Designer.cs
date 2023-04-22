namespace TIckets
{ 
    partial class TicketStatusHandlerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketStatusHandlerForm));
            this.TicketStatusHandlerFormEditBtn = new System.Windows.Forms.Button();
            this.TicketStatusHandlerFormAddBtn = new System.Windows.Forms.Button();
            this.TicketStatusHandlerFormCnlBtn = new System.Windows.Forms.Button();
            this.TicketStatusHandlerFormStatusNameLbl = new System.Windows.Forms.Label();
            this.TicketStatusHandlerFormStatusNameTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TicketStatusHandlerFormEditBtn
            // 
            this.TicketStatusHandlerFormEditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TicketStatusHandlerFormEditBtn.Location = new System.Drawing.Point(16, 64);
            this.TicketStatusHandlerFormEditBtn.Name = "TicketStatusHandlerFormEditBtn";
            this.TicketStatusHandlerFormEditBtn.Size = new System.Drawing.Size(143, 41);
            this.TicketStatusHandlerFormEditBtn.TabIndex = 0;
            this.TicketStatusHandlerFormEditBtn.Text = "Редактировать";
            this.TicketStatusHandlerFormEditBtn.UseVisualStyleBackColor = true;
            this.TicketStatusHandlerFormEditBtn.Click += new System.EventHandler(this.TicketStatusHandlerFormEditBtn_Click);
            // 
            // TicketStatusHandlerFormAddBtn
            // 
            this.TicketStatusHandlerFormAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TicketStatusHandlerFormAddBtn.Location = new System.Drawing.Point(165, 64);
            this.TicketStatusHandlerFormAddBtn.Name = "TicketStatusHandlerFormAddBtn";
            this.TicketStatusHandlerFormAddBtn.Size = new System.Drawing.Size(143, 41);
            this.TicketStatusHandlerFormAddBtn.TabIndex = 1;
            this.TicketStatusHandlerFormAddBtn.Text = "Добавить";
            this.TicketStatusHandlerFormAddBtn.UseVisualStyleBackColor = true;
            this.TicketStatusHandlerFormAddBtn.Click += new System.EventHandler(this.TicketStatusHandlerFormAddBtn_Click);
            // 
            // TicketStatusHandlerFormCnlBtn
            // 
            this.TicketStatusHandlerFormCnlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TicketStatusHandlerFormCnlBtn.Location = new System.Drawing.Point(314, 64);
            this.TicketStatusHandlerFormCnlBtn.Name = "TicketStatusHandlerFormCnlBtn";
            this.TicketStatusHandlerFormCnlBtn.Size = new System.Drawing.Size(143, 41);
            this.TicketStatusHandlerFormCnlBtn.TabIndex = 2;
            this.TicketStatusHandlerFormCnlBtn.Text = "Отмена";
            this.TicketStatusHandlerFormCnlBtn.UseVisualStyleBackColor = true;
            this.TicketStatusHandlerFormCnlBtn.Click += new System.EventHandler(this.TicketStatusHandlerFormCnlBtn_Click);
            // 
            // TicketStatusHandlerFormStatusNameLbl
            // 
            this.TicketStatusHandlerFormStatusNameLbl.AutoSize = true;
            this.TicketStatusHandlerFormStatusNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TicketStatusHandlerFormStatusNameLbl.Location = new System.Drawing.Point(12, 9);
            this.TicketStatusHandlerFormStatusNameLbl.Name = "TicketStatusHandlerFormStatusNameLbl";
            this.TicketStatusHandlerFormStatusNameLbl.Size = new System.Drawing.Size(152, 20);
            this.TicketStatusHandlerFormStatusNameLbl.TabIndex = 3;
            this.TicketStatusHandlerFormStatusNameLbl.Text = "Категория статуса";
            // 
            // TicketStatusHandlerFormStatusNameTb
            // 
            this.TicketStatusHandlerFormStatusNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TicketStatusHandlerFormStatusNameTb.Location = new System.Drawing.Point(16, 32);
            this.TicketStatusHandlerFormStatusNameTb.Name = "TicketStatusHandlerFormStatusNameTb";
            this.TicketStatusHandlerFormStatusNameTb.Size = new System.Drawing.Size(441, 26);
            this.TicketStatusHandlerFormStatusNameTb.TabIndex = 4;
            // 
            // TicketStatusHandlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 119);
            this.Controls.Add(this.TicketStatusHandlerFormStatusNameTb);
            this.Controls.Add(this.TicketStatusHandlerFormStatusNameLbl);
            this.Controls.Add(this.TicketStatusHandlerFormCnlBtn);
            this.Controls.Add(this.TicketStatusHandlerFormAddBtn);
            this.Controls.Add(this.TicketStatusHandlerFormEditBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TicketStatusHandlerForm";
            this.Text = "Категория статуса";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TicketStatusHandlerFormEditBtn;
        private System.Windows.Forms.Button TicketStatusHandlerFormAddBtn;
        private System.Windows.Forms.Button TicketStatusHandlerFormCnlBtn;
        private System.Windows.Forms.Label TicketStatusHandlerFormStatusNameLbl;
        private System.Windows.Forms.TextBox TicketStatusHandlerFormStatusNameTb;
    }
}