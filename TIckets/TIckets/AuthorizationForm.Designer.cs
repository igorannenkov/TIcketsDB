namespace TIckets
{
    partial class AuthorizationForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ShowAdmBtn = new System.Windows.Forms.Button();
            this.ShowTechnicBtn = new System.Windows.Forms.Button();
            this.ShowUserBtn = new System.Windows.Forms.Button();
            this.Выход = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShowAdmBtn
            // 
            this.ShowAdmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowAdmBtn.Location = new System.Drawing.Point(62, 9);
            this.ShowAdmBtn.Name = "ShowAdmBtn";
            this.ShowAdmBtn.Size = new System.Drawing.Size(180, 40);
            this.ShowAdmBtn.TabIndex = 0;
            this.ShowAdmBtn.Text = "Администратор";
            this.ShowAdmBtn.UseVisualStyleBackColor = true;
            this.ShowAdmBtn.Click += new System.EventHandler(this.ShowAdmBtn_Click);
            // 
            // ShowTechnicBtn
            // 
            this.ShowTechnicBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowTechnicBtn.Location = new System.Drawing.Point(62, 101);
            this.ShowTechnicBtn.Name = "ShowTechnicBtn";
            this.ShowTechnicBtn.Size = new System.Drawing.Size(180, 40);
            this.ShowTechnicBtn.TabIndex = 1;
            this.ShowTechnicBtn.Text = "Техник";
            this.ShowTechnicBtn.UseVisualStyleBackColor = true;
            this.ShowTechnicBtn.Click += new System.EventHandler(this.ShowTechnicBtn_Click);
            // 
            // ShowUserBtn
            // 
            this.ShowUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowUserBtn.Location = new System.Drawing.Point(62, 55);
            this.ShowUserBtn.Name = "ShowUserBtn";
            this.ShowUserBtn.Size = new System.Drawing.Size(180, 40);
            this.ShowUserBtn.TabIndex = 2;
            this.ShowUserBtn.Text = "Пользователь";
            this.ShowUserBtn.UseVisualStyleBackColor = true;
            this.ShowUserBtn.Click += new System.EventHandler(this.ShowUserBtn_Click);
            // 
            // Выход
            // 
            this.Выход.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Выход.Location = new System.Drawing.Point(62, 147);
            this.Выход.Name = "Выход";
            this.Выход.Size = new System.Drawing.Size(180, 40);
            this.Выход.TabIndex = 3;
            this.Выход.Text = "Выход";
            this.Выход.UseVisualStyleBackColor = true;
            this.Выход.Click += new System.EventHandler(this.Выход_Click);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 199);
            this.Controls.Add(this.Выход);
            this.Controls.Add(this.ShowUserBtn);
            this.Controls.Add(this.ShowTechnicBtn);
            this.Controls.Add(this.ShowAdmBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма авторизцаии";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShowAdmBtn;
        private System.Windows.Forms.Button ShowTechnicBtn;
        private System.Windows.Forms.Button ShowUserBtn;
        private System.Windows.Forms.Button Выход;
    }
}

