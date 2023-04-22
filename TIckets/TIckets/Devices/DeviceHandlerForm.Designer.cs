namespace TIckets
{
    partial class DeviceHandlerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeviceHandlerForm));
            this.DeviceHandlerFormCnlBtn = new System.Windows.Forms.Button();
            this.DeviceHandlerFormEditBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DeviceHandlerFormNud = new System.Windows.Forms.NumericUpDown();
            this.DeviceHandlerFormCb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DeviceHandlerFormNud)).BeginInit();
            this.SuspendLayout();
            // 
            // DeviceHandlerFormCnlBtn
            // 
            this.DeviceHandlerFormCnlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeviceHandlerFormCnlBtn.Location = new System.Drawing.Point(280, 77);
            this.DeviceHandlerFormCnlBtn.Name = "DeviceHandlerFormCnlBtn";
            this.DeviceHandlerFormCnlBtn.Size = new System.Drawing.Size(125, 40);
            this.DeviceHandlerFormCnlBtn.TabIndex = 0;
            this.DeviceHandlerFormCnlBtn.Text = "Отмена";
            this.DeviceHandlerFormCnlBtn.UseVisualStyleBackColor = true;
            this.DeviceHandlerFormCnlBtn.Click += new System.EventHandler(this.DeviceHandlerFormCnlBtn_Click);
            // 
            // DeviceHandlerFormEditBtn
            // 
            this.DeviceHandlerFormEditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeviceHandlerFormEditBtn.Location = new System.Drawing.Point(136, 77);
            this.DeviceHandlerFormEditBtn.Name = "DeviceHandlerFormEditBtn";
            this.DeviceHandlerFormEditBtn.Size = new System.Drawing.Size(138, 40);
            this.DeviceHandlerFormEditBtn.TabIndex = 3;
            this.DeviceHandlerFormEditBtn.Text = "Закупить";
            this.DeviceHandlerFormEditBtn.UseVisualStyleBackColor = true;
            this.DeviceHandlerFormEditBtn.Click += new System.EventHandler(this.DeviceHandlerFormEditBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Наименование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(276, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "На складе (шт.)";
            // 
            // DeviceHandlerFormNud
            // 
            this.DeviceHandlerFormNud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeviceHandlerFormNud.Location = new System.Drawing.Point(280, 32);
            this.DeviceHandlerFormNud.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DeviceHandlerFormNud.Name = "DeviceHandlerFormNud";
            this.DeviceHandlerFormNud.Size = new System.Drawing.Size(125, 26);
            this.DeviceHandlerFormNud.TabIndex = 7;
            this.DeviceHandlerFormNud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DeviceHandlerFormCb
            // 
            this.DeviceHandlerFormCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeviceHandlerFormCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeviceHandlerFormCb.FormattingEnabled = true;
            this.DeviceHandlerFormCb.Location = new System.Drawing.Point(16, 31);
            this.DeviceHandlerFormCb.Name = "DeviceHandlerFormCb";
            this.DeviceHandlerFormCb.Size = new System.Drawing.Size(258, 28);
            this.DeviceHandlerFormCb.TabIndex = 8;
            // 
            // DeviceHandlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 127);
            this.Controls.Add(this.DeviceHandlerFormCb);
            this.Controls.Add(this.DeviceHandlerFormNud);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeviceHandlerFormEditBtn);
            this.Controls.Add(this.DeviceHandlerFormCnlBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DeviceHandlerForm";
            this.Text = "Закупка оборудования";
            ((System.ComponentModel.ISupportInitialize)(this.DeviceHandlerFormNud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeviceHandlerFormCnlBtn;
        private System.Windows.Forms.Button DeviceHandlerFormEditBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown DeviceHandlerFormNud;
        private System.Windows.Forms.ComboBox DeviceHandlerFormCb;
    }
}