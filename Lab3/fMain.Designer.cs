namespace Lab3
{
    partial class fMain
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
            this.tbHousesInfo = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddHouse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbHousesInfo
            // 
            this.tbHousesInfo.Location = new System.Drawing.Point(12, 12);
            this.tbHousesInfo.Multiline = true;
            this.tbHousesInfo.Name = "tbHousesInfo";
            this.tbHousesInfo.ReadOnly = true;
            this.tbHousesInfo.Size = new System.Drawing.Size(477, 374);
            this.tbHousesInfo.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(513, 233);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 61);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Закрити";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddHouse
            // 
            this.btnAddHouse.Location = new System.Drawing.Point(513, 102);
            this.btnAddHouse.Name = "btnAddHouse";
            this.btnAddHouse.Size = new System.Drawing.Size(102, 61);
            this.btnAddHouse.TabIndex = 2;
            this.btnAddHouse.Text = "Додати будинок";
            this.btnAddHouse.UseVisualStyleBackColor = true;
            this.btnAddHouse.Click += new System.EventHandler(this.btnAddHouse_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 403);
            this.Controls.Add(this.btnAddHouse);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbHousesInfo);
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторна робота №3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbHousesInfo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddHouse;
    }
}

