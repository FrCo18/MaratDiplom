namespace MaratDiplom
{
    partial class ReportForm
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
            this.endSalaryLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.salaryLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clientOrdersListView = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.service = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.client = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.expensesLbl = new System.Windows.Forms.Label();
            this.revenueLbl = new System.Windows.Forms.Label();
            this.profitLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // endSalaryLbl
            // 
            this.endSalaryLbl.AutoSize = true;
            this.endSalaryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endSalaryLbl.Location = new System.Drawing.Point(490, 380);
            this.endSalaryLbl.Name = "endSalaryLbl";
            this.endSalaryLbl.Size = new System.Drawing.Size(26, 29);
            this.endSalaryLbl.TabIndex = 23;
            this.endSalaryLbl.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(2, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(472, 29);
            this.label6.TabIndex = 22;
            this.label6.Text = "Зарплата + процент с проданных услуг:";
            // 
            // salaryLbl
            // 
            this.salaryLbl.AutoSize = true;
            this.salaryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.salaryLbl.Location = new System.Drawing.Point(142, 425);
            this.salaryLbl.Name = "salaryLbl";
            this.salaryLbl.Size = new System.Drawing.Size(26, 29);
            this.salaryLbl.TabIndex = 21;
            this.salaryLbl.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "Зарплата:";
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
            this.clientOrdersListView.Location = new System.Drawing.Point(12, 25);
            this.clientOrdersListView.MultiSelect = false;
            this.clientOrdersListView.Name = "clientOrdersListView";
            this.clientOrdersListView.Size = new System.Drawing.Size(710, 316);
            this.clientOrdersListView.TabIndex = 16;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(728, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "Затраты:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(728, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 29);
            this.label2.TabIndex = 25;
            this.label2.Text = "Прибыль:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(728, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 29);
            this.label4.TabIndex = 26;
            this.label4.Text = "Выручка:";
            // 
            // expensesLbl
            // 
            this.expensesLbl.AutoSize = true;
            this.expensesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expensesLbl.Location = new System.Drawing.Point(849, 164);
            this.expensesLbl.Name = "expensesLbl";
            this.expensesLbl.Size = new System.Drawing.Size(26, 29);
            this.expensesLbl.TabIndex = 27;
            this.expensesLbl.Text = "0";
            // 
            // revenueLbl
            // 
            this.revenueLbl.AutoSize = true;
            this.revenueLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.revenueLbl.Location = new System.Drawing.Point(850, 62);
            this.revenueLbl.Name = "revenueLbl";
            this.revenueLbl.Size = new System.Drawing.Size(26, 29);
            this.revenueLbl.TabIndex = 28;
            this.revenueLbl.Text = "0";
            // 
            // profitLbl
            // 
            this.profitLbl.AutoSize = true;
            this.profitLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profitLbl.Location = new System.Drawing.Point(850, 111);
            this.profitLbl.Name = "profitLbl";
            this.profitLbl.Size = new System.Drawing.Size(26, 29);
            this.profitLbl.TabIndex = 29;
            this.profitLbl.Text = "0";
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 578);
            this.Controls.Add(this.profitLbl);
            this.Controls.Add(this.revenueLbl);
            this.Controls.Add(this.expensesLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.endSalaryLbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.salaryLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clientOrdersListView);
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчётность";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label endSalaryLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label salaryLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView clientOrdersListView;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader service;
        private System.Windows.Forms.ColumnHeader client;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label expensesLbl;
        private System.Windows.Forms.Label revenueLbl;
        private System.Windows.Forms.Label profitLbl;
    }
}