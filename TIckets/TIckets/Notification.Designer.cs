namespace TIckets
{
    partial class NotificationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationForm));
            this.NotificatonOkBtn = new System.Windows.Forms.Button();
            this.NotificationShowBtn = new System.Windows.Forms.Button();
            this.NotificationLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NotificatonOkBtn
            // 
            this.NotificatonOkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotificatonOkBtn.Location = new System.Drawing.Point(217, 13);
            this.NotificatonOkBtn.Name = "NotificatonOkBtn";
            this.NotificatonOkBtn.Size = new System.Drawing.Size(101, 32);
            this.NotificatonOkBtn.TabIndex = 0;
            this.NotificatonOkBtn.Text = "ОК";
            this.NotificatonOkBtn.UseVisualStyleBackColor = true;
            this.NotificatonOkBtn.Click += new System.EventHandler(this.TechnicNotificatonOkBtn_Click);
            // 
            // NotificationShowBtn
            // 
            this.NotificationShowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotificationShowBtn.Location = new System.Drawing.Point(217, 51);
            this.NotificationShowBtn.Name = "NotificationShowBtn";
            this.NotificationShowBtn.Size = new System.Drawing.Size(101, 32);
            this.NotificationShowBtn.TabIndex = 1;
            this.NotificationShowBtn.Text = "Показать";
            this.NotificationShowBtn.UseVisualStyleBackColor = true;
            this.NotificationShowBtn.Click += new System.EventHandler(this.TechnicNotificationShowBtn_Click);
            // 
            // NotificationLbl
            // 
            this.NotificationLbl.AutoSize = true;
            this.NotificationLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotificationLbl.Location = new System.Drawing.Point(12, 68);
            this.NotificationLbl.Name = "NotificationLbl";
            this.NotificationLbl.Size = new System.Drawing.Size(193, 20);
            this.NotificationLbl.TabIndex = 2;
            this.NotificationLbl.Text = "Вам назначено 0 заявок";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(76, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // NotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 100);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NotificationLbl);
            this.Controls.Add(this.NotificationShowBtn);
            this.Controls.Add(this.NotificatonOkBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NotificationForm";
            this.Text = "Уведомление о новых заявках";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NotificatonOkBtn;
        private System.Windows.Forms.Button NotificationShowBtn;
        private System.Windows.Forms.Label NotificationLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}