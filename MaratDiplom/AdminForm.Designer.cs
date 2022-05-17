namespace MaratDiplom
{
    partial class AdminForm
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
            this.servicesBtn = new System.Windows.Forms.Button();
            this.reportBtn = new System.Windows.Forms.Button();
            this.ordersForMeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // servicesBtn
            // 
            this.servicesBtn.Location = new System.Drawing.Point(291, 57);
            this.servicesBtn.Name = "servicesBtn";
            this.servicesBtn.Size = new System.Drawing.Size(229, 83);
            this.servicesBtn.TabIndex = 0;
            this.servicesBtn.Text = "Услуги";
            this.servicesBtn.UseVisualStyleBackColor = true;
            this.servicesBtn.Click += new System.EventHandler(this.servicesBtn_Click);
            // 
            // reportBtn
            // 
            this.reportBtn.Location = new System.Drawing.Point(291, 180);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(229, 83);
            this.reportBtn.TabIndex = 1;
            this.reportBtn.Text = "Отчётность";
            this.reportBtn.UseVisualStyleBackColor = true;
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // ordersForMeBtn
            // 
            this.ordersForMeBtn.Location = new System.Drawing.Point(291, 302);
            this.ordersForMeBtn.Name = "ordersForMeBtn";
            this.ordersForMeBtn.Size = new System.Drawing.Size(229, 83);
            this.ordersForMeBtn.TabIndex = 3;
            this.ordersForMeBtn.Text = "Заказы на меня";
            this.ordersForMeBtn.UseVisualStyleBackColor = true;
            this.ordersForMeBtn.Click += new System.EventHandler(this.ordersForMeBtn_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ordersForMeBtn);
            this.Controls.Add(this.reportBtn);
            this.Controls.Add(this.servicesBtn);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню администратора";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button servicesBtn;
        private System.Windows.Forms.Button reportBtn;
        private System.Windows.Forms.Button ordersForMeBtn;
    }
}