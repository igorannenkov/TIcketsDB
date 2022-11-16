namespace TIckets
{
    partial class DeviceTypesHandlerForm
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
            this.DeviceTypesHandlerFormEditBtn = new System.Windows.Forms.Button();
            this.DeviceTypesHandlerFormAddBtn = new System.Windows.Forms.Button();
            this.DeviceTypesHandlerFormCnlBtn = new System.Windows.Forms.Button();
            this.DeviceTypesHandlerFormLbl = new System.Windows.Forms.Label();
            this.DeviceTypesHandlerFormTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DeviceTypesHandlerFormEditBtn
            // 
            this.DeviceTypesHandlerFormEditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeviceTypesHandlerFormEditBtn.Location = new System.Drawing.Point(16, 64);
            this.DeviceTypesHandlerFormEditBtn.Name = "DeviceTypesHandlerFormEditBtn";
            this.DeviceTypesHandlerFormEditBtn.Size = new System.Drawing.Size(138, 42);
            this.DeviceTypesHandlerFormEditBtn.TabIndex = 0;
            this.DeviceTypesHandlerFormEditBtn.Text = "Редактировать";
            this.DeviceTypesHandlerFormEditBtn.UseVisualStyleBackColor = true;
            this.DeviceTypesHandlerFormEditBtn.Click += new System.EventHandler(this.DeviceTypesHandlerFormEditBtn_Click);
            // 
            // DeviceTypesHandlerFormAddBtn
            // 
            this.DeviceTypesHandlerFormAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeviceTypesHandlerFormAddBtn.Location = new System.Drawing.Point(160, 64);
            this.DeviceTypesHandlerFormAddBtn.Name = "DeviceTypesHandlerFormAddBtn";
            this.DeviceTypesHandlerFormAddBtn.Size = new System.Drawing.Size(138, 42);
            this.DeviceTypesHandlerFormAddBtn.TabIndex = 1;
            this.DeviceTypesHandlerFormAddBtn.Text = "Добавить";
            this.DeviceTypesHandlerFormAddBtn.UseVisualStyleBackColor = true;
            this.DeviceTypesHandlerFormAddBtn.Click += new System.EventHandler(this.DeviceTypesHandlerFormAddBtn_Click);
            // 
            // DeviceTypesHandlerFormCnlBtn
            // 
            this.DeviceTypesHandlerFormCnlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeviceTypesHandlerFormCnlBtn.Location = new System.Drawing.Point(304, 64);
            this.DeviceTypesHandlerFormCnlBtn.Name = "DeviceTypesHandlerFormCnlBtn";
            this.DeviceTypesHandlerFormCnlBtn.Size = new System.Drawing.Size(138, 42);
            this.DeviceTypesHandlerFormCnlBtn.TabIndex = 2;
            this.DeviceTypesHandlerFormCnlBtn.Text = "Отмена";
            this.DeviceTypesHandlerFormCnlBtn.UseVisualStyleBackColor = true;
            this.DeviceTypesHandlerFormCnlBtn.Click += new System.EventHandler(this.DeviceTypesHandlerFormCnlBtn_Click);
            // 
            // DeviceTypesHandlerFormLbl
            // 
            this.DeviceTypesHandlerFormLbl.AutoSize = true;
            this.DeviceTypesHandlerFormLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeviceTypesHandlerFormLbl.Location = new System.Drawing.Point(12, 9);
            this.DeviceTypesHandlerFormLbl.Name = "DeviceTypesHandlerFormLbl";
            this.DeviceTypesHandlerFormLbl.Size = new System.Drawing.Size(329, 20);
            this.DeviceTypesHandlerFormLbl.TabIndex = 3;
            this.DeviceTypesHandlerFormLbl.Text = "Наименование категории комплектующих";
            // 
            // DeviceTypesHandlerFormTb
            // 
            this.DeviceTypesHandlerFormTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeviceTypesHandlerFormTb.Location = new System.Drawing.Point(16, 32);
            this.DeviceTypesHandlerFormTb.Name = "DeviceTypesHandlerFormTb";
            this.DeviceTypesHandlerFormTb.Size = new System.Drawing.Size(426, 26);
            this.DeviceTypesHandlerFormTb.TabIndex = 4;
            // 
            // DeviceTypesHandlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 118);
            this.Controls.Add(this.DeviceTypesHandlerFormTb);
            this.Controls.Add(this.DeviceTypesHandlerFormLbl);
            this.Controls.Add(this.DeviceTypesHandlerFormCnlBtn);
            this.Controls.Add(this.DeviceTypesHandlerFormAddBtn);
            this.Controls.Add(this.DeviceTypesHandlerFormEditBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DeviceTypesHandlerForm";
            this.Text = "Категория комплектующих";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeviceTypesHandlerFormEditBtn;
        private System.Windows.Forms.Button DeviceTypesHandlerFormAddBtn;
        private System.Windows.Forms.Button DeviceTypesHandlerFormCnlBtn;
        private System.Windows.Forms.Label DeviceTypesHandlerFormLbl;
        private System.Windows.Forms.TextBox DeviceTypesHandlerFormTb;
    }
}