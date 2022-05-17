namespace MaratDiplom
{
    partial class OrdersWorkersForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.statusCbx = new System.Windows.Forms.ComboBox();
            this.editBtn = new System.Windows.Forms.Button();
            this.clientOrdersListView = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.service = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.client = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.endSalaryLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.salaryLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(756, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Статус";
            // 
            // statusCbx
            // 
            this.statusCbx.FormattingEnabled = true;
            this.statusCbx.Items.AddRange(new object[] {
            "Выполнен",
            "Не выполнен"});
            this.statusCbx.Location = new System.Drawing.Point(742, 95);
            this.statusCbx.Name = "statusCbx";
            this.statusCbx.Size = new System.Drawing.Size(305, 24);
            this.statusCbx.TabIndex = 10;
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(858, 506);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(189, 60);
            this.editBtn.TabIndex = 8;
            this.editBtn.Text = "Изменить";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // clientOrdersListView
            // 
            this.clientOrdersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.service,
            this.client,
            this.status,
            this.date});
            this.clientOrdersListView.GridLines = true;
            this.clientOrdersListView.HideSelection = false;
            this.clientOrdersListView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.clientOrdersListView.Location = new System.Drawing.Point(12, 33);
            this.clientOrdersListView.MultiSelect = false;
            this.clientOrdersListView.Name = "clientOrdersListView";
            this.clientOrdersListView.Size = new System.Drawing.Size(710, 316);
            this.clientOrdersListView.TabIndex = 7;
            this.clientOrdersListView.UseCompatibleStateImageBehavior = false;
            this.clientOrdersListView.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "id";
            // 
            // service
            // 
            this.service.Text = "Услуга";
            this.service.Width = 227;
            // 
            // client
            // 
            this.client.Text = "Клиент";
            this.client.Width = 194;
            // 
            // status
            // 
            this.status.Text = "Статус";
            this.status.Width = 89;
            // 
            // date
            // 
            this.date.Text = "Дата создания";
            this.date.Width = 132;
            // 
            // endSalaryLbl
            // 
            this.endSalaryLbl.AutoSize = true;
            this.endSalaryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endSalaryLbl.Location = new System.Drawing.Point(500, 390);
            this.endSalaryLbl.Name = "endSalaryLbl";
            this.endSalaryLbl.Size = new System.Drawing.Size(26, 29);
            this.endSalaryLbl.TabIndex = 15;
            this.endSalaryLbl.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(472, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "Зарплата + процент с проданных услуг:";
            // 
            // salaryLbl
            // 
            this.salaryLbl.AutoSize = true;
            this.salaryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.salaryLbl.Location = new System.Drawing.Point(152, 435);
            this.salaryLbl.Name = "salaryLbl";
            this.salaryLbl.Size = new System.Drawing.Size(26, 29);
            this.salaryLbl.TabIndex = 13;
            this.salaryLbl.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(17, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Зарплата:";
            // 
            // OrdersWorkersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 604);
            this.Controls.Add(this.endSalaryLbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.salaryLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusCbx);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.clientOrdersListView);
            this.Name = "OrdersWorkersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказы на вас";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox statusCbx;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.ListView clientOrdersListView;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader service;
        private System.Windows.Forms.ColumnHeader client;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.Label endSalaryLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label salaryLbl;
        private System.Windows.Forms.Label label3;
    }
}