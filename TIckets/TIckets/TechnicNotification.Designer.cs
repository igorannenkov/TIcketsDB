namespace TIckets
{
    partial class TechnicNotificationForm
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
            this.TechnicNotificatonOkBtn = new System.Windows.Forms.Button();
            this.TechnicNotificationShowBtn = new System.Windows.Forms.Button();
            this.TechnicNotificationLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TechnicNotificatonOkBtn
            // 
            this.TechnicNotificatonOkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TechnicNotificatonOkBtn.Location = new System.Drawing.Point(222, 8);
            this.TechnicNotificatonOkBtn.Name = "TechnicNotificatonOkBtn";
            this.TechnicNotificatonOkBtn.Size = new System.Drawing.Size(90, 31);
            this.TechnicNotificatonOkBtn.TabIndex = 0;
            this.TechnicNotificatonOkBtn.Text = "ОК";
            this.TechnicNotificatonOkBtn.UseVisualStyleBackColor = true;
            this.TechnicNotificatonOkBtn.Click += new System.EventHandler(this.TechnicNotificatonOkBtn_Click);
            // 
            // TechnicNotificationShowBtn
            // 
            this.TechnicNotificationShowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TechnicNotificationShowBtn.Location = new System.Drawing.Point(222, 45);
            this.TechnicNotificationShowBtn.Name = "TechnicNotificationShowBtn";
            this.TechnicNotificationShowBtn.Size = new System.Drawing.Size(90, 31);
            this.TechnicNotificationShowBtn.TabIndex = 1;
            this.TechnicNotificationShowBtn.Text = "Показать";
            this.TechnicNotificationShowBtn.UseVisualStyleBackColor = true;
            this.TechnicNotificationShowBtn.Click += new System.EventHandler(this.TechnicNotificationShowBtn_Click);
            // 
            // TechnicNotificationLbl
            // 
            this.TechnicNotificationLbl.AutoSize = true;
            this.TechnicNotificationLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TechnicNotificationLbl.Location = new System.Drawing.Point(12, 19);
            this.TechnicNotificationLbl.Name = "TechnicNotificationLbl";
            this.TechnicNotificationLbl.Size = new System.Drawing.Size(193, 20);
            this.TechnicNotificationLbl.TabIndex = 2;
            this.TechnicNotificationLbl.Text = "Вам назначено 0 заявок";
            // 
            // TechnicNotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 82);
            this.Controls.Add(this.TechnicNotificationLbl);
            this.Controls.Add(this.TechnicNotificationShowBtn);
            this.Controls.Add(this.TechnicNotificatonOkBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TechnicNotificationForm";
            this.Text = "Уведомление о новых заявках";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TechnicNotificatonOkBtn;
        private System.Windows.Forms.Button TechnicNotificationShowBtn;
        private System.Windows.Forms.Label TechnicNotificationLbl;
    }
}