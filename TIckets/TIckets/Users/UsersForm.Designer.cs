namespace TIckets
{
    partial class UsersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersForm));
            this.UsersFormGridView = new System.Windows.Forms.DataGridView();
            this.UsersFormAddUserBtn = new System.Windows.Forms.Button();
            this.UsersFormExportBtn = new System.Windows.Forms.Button();
            this.UsersFormFilterBtn = new System.Windows.Forms.Button();
            this.UsersFormSearchTb = new System.Windows.Forms.TextBox();
            this.UsersFormSearchLbl = new System.Windows.Forms.Label();
            this.UsersFormSearchСb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.UsersFormGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UsersFormGridView
            // 
            this.UsersFormGridView.AllowUserToAddRows = false;
            this.UsersFormGridView.AllowUserToDeleteRows = false;
            this.UsersFormGridView.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsersFormGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.UsersFormGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsersFormGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersFormGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.UsersFormGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersFormGridView.Location = new System.Drawing.Point(0, 39);
            this.UsersFormGridView.Name = "UsersFormGridView";
            this.UsersFormGridView.ReadOnly = true;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsersFormGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.UsersFormGridView.Size = new System.Drawing.Size(867, 411);
            this.UsersFormGridView.TabIndex = 6;
            this.UsersFormGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.UsersFormGridView_CellMouseDoubleClick);
            this.UsersFormGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UsersFormGridView_KeyDown);
            // 
            // UsersFormAddUserBtn
            // 
            this.UsersFormAddUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsersFormAddUserBtn.Location = new System.Drawing.Point(7, 7);
            this.UsersFormAddUserBtn.Name = "UsersFormAddUserBtn";
            this.UsersFormAddUserBtn.Size = new System.Drawing.Size(97, 26);
            this.UsersFormAddUserBtn.TabIndex = 0;
            this.UsersFormAddUserBtn.Text = "Добавить";
            this.UsersFormAddUserBtn.UseVisualStyleBackColor = true;
            this.UsersFormAddUserBtn.Click += new System.EventHandler(this.UsersFormAddUserBtn_Click);
            // 
            // UsersFormExportBtn
            // 
            this.UsersFormExportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsersFormExportBtn.Location = new System.Drawing.Point(720, 7);
            this.UsersFormExportBtn.Name = "UsersFormExportBtn";
            this.UsersFormExportBtn.Size = new System.Drawing.Size(136, 26);
            this.UsersFormExportBtn.TabIndex = 5;
            this.UsersFormExportBtn.Text = "Выгрузка в Excel";
            this.UsersFormExportBtn.UseVisualStyleBackColor = true;
            this.UsersFormExportBtn.Click += new System.EventHandler(this.UsersFormExportBtn_Click);
            // 
            // UsersFormFilterBtn
            // 
            this.UsersFormFilterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsersFormFilterBtn.Location = new System.Drawing.Point(331, 7);
            this.UsersFormFilterBtn.Name = "UsersFormFilterBtn";
            this.UsersFormFilterBtn.Size = new System.Drawing.Size(63, 26);
            this.UsersFormFilterBtn.TabIndex = 2;
            this.UsersFormFilterBtn.Text = "Поиск";
            this.UsersFormFilterBtn.UseVisualStyleBackColor = true;
            this.UsersFormFilterBtn.Click += new System.EventHandler(this.UsersFormFilterBtn_Click);
            // 
            // UsersFormSearchTb
            // 
            this.UsersFormSearchTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsersFormSearchTb.Location = new System.Drawing.Point(110, 7);
            this.UsersFormSearchTb.Name = "UsersFormSearchTb";
            this.UsersFormSearchTb.Size = new System.Drawing.Size(215, 26);
            this.UsersFormSearchTb.TabIndex = 1;
            this.UsersFormSearchTb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UsersFormSearchTb_KeyDown);
            // 
            // UsersFormSearchLbl
            // 
            this.UsersFormSearchLbl.AutoSize = true;
            this.UsersFormSearchLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsersFormSearchLbl.Location = new System.Drawing.Point(400, 11);
            this.UsersFormSearchLbl.Name = "UsersFormSearchLbl";
            this.UsersFormSearchLbl.Size = new System.Drawing.Size(131, 18);
            this.UsersFormSearchLbl.TabIndex = 3;
            this.UsersFormSearchLbl.Text = "Фильтр по ролям";
            // 
            // UsersFormSearchСb
            // 
            this.UsersFormSearchСb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UsersFormSearchСb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsersFormSearchСb.FormattingEnabled = true;
            this.UsersFormSearchСb.Location = new System.Drawing.Point(532, 7);
            this.UsersFormSearchСb.Name = "UsersFormSearchСb";
            this.UsersFormSearchСb.Size = new System.Drawing.Size(182, 26);
            this.UsersFormSearchСb.TabIndex = 4;
            this.UsersFormSearchСb.SelectedIndexChanged += new System.EventHandler(this.UsersFormSearchСb_SelectedIndexChanged);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 450);
            this.Controls.Add(this.UsersFormSearchСb);
            this.Controls.Add(this.UsersFormSearchLbl);
            this.Controls.Add(this.UsersFormSearchTb);
            this.Controls.Add(this.UsersFormFilterBtn);
            this.Controls.Add(this.UsersFormExportBtn);
            this.Controls.Add(this.UsersFormAddUserBtn);
            this.Controls.Add(this.UsersFormGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UsersForm";
            this.Text = "Пользователи";
            ((System.ComponentModel.ISupportInitialize)(this.UsersFormGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UsersFormGridView;
        private System.Windows.Forms.Button UsersFormAddUserBtn;
        private System.Windows.Forms.Button UsersFormExportBtn;
        private System.Windows.Forms.Button UsersFormFilterBtn;
        private System.Windows.Forms.TextBox UsersFormSearchTb;
        private System.Windows.Forms.Label UsersFormSearchLbl;
        private System.Windows.Forms.ComboBox UsersFormSearchСb;
    }
}