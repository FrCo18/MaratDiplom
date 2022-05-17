namespace MaratDiplom
{
    partial class ServicesForm
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
            this.listNumeric = new System.Windows.Forms.NumericUpDown();
            this.nameTxb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusCbx = new System.Windows.Forms.ComboBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.servicesListView = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cost_to_us = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.is_sale = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.costNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.listNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // listNumeric
            // 
            this.listNumeric.Location = new System.Drawing.Point(819, 285);
            this.listNumeric.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.listNumeric.Name = "listNumeric";
            this.listNumeric.Size = new System.Drawing.Size(294, 22);
            this.listNumeric.TabIndex = 23;
            // 
            // nameTxb
            // 
            this.nameTxb.Location = new System.Drawing.Point(819, 193);
            this.nameTxb.Name = "nameTxb";
            this.nameTxb.Size = new System.Drawing.Size(305, 22);
            this.nameTxb.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(833, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Название";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(833, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Статус";
            // 
            // statusCbx
            // 
            this.statusCbx.FormattingEnabled = true;
            this.statusCbx.Items.AddRange(new object[] {
            "В продаже",
            "Не в продаже"});
            this.statusCbx.Location = new System.Drawing.Point(819, 105);
            this.statusCbx.Name = "statusCbx";
            this.statusCbx.Size = new System.Drawing.Size(305, 24);
            this.statusCbx.TabIndex = 19;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(716, 534);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(181, 60);
            this.addBtn.TabIndex = 18;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(924, 534);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(189, 60);
            this.editBtn.TabIndex = 17;
            this.editBtn.Text = "Изменить";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // servicesListView
            // 
            this.servicesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.name,
            this.list_price,
            this.cost_to_us,
            this.is_sale});
            this.servicesListView.GridLines = true;
            this.servicesListView.HideSelection = false;
            this.servicesListView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.servicesListView.Location = new System.Drawing.Point(12, 24);
            this.servicesListView.MultiSelect = false;
            this.servicesListView.Name = "servicesListView";
            this.servicesListView.Size = new System.Drawing.Size(740, 321);
            this.servicesListView.TabIndex = 16;
            this.servicesListView.UseCompatibleStateImageBehavior = false;
            this.servicesListView.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "id";
            // 
            // name
            // 
            this.name.Text = "Услуга";
            this.name.Width = 227;
            // 
            // list_price
            // 
            this.list_price.Text = "Торговая цена";
            this.list_price.Width = 172;
            // 
            // cost_to_us
            // 
            this.cost_to_us.Text = "Закупочные расходы";
            this.cost_to_us.Width = 162;
            // 
            // is_sale
            // 
            this.is_sale.Text = "Статус";
            this.is_sale.Width = 89;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(833, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Торговая цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(833, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Закупочные расходы";
            // 
            // costNumeric
            // 
            this.costNumeric.Location = new System.Drawing.Point(819, 376);
            this.costNumeric.Name = "costNumeric";
            this.costNumeric.Size = new System.Drawing.Size(294, 22);
            this.costNumeric.TabIndex = 25;
            // 
            // ServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 620);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.costNumeric);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listNumeric);
            this.Controls.Add(this.nameTxb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusCbx);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.servicesListView);
            this.Name = "ServicesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Услуги";
            ((System.ComponentModel.ISupportInitialize)(this.listNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown listNumeric;
        private System.Windows.Forms.TextBox nameTxb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox statusCbx;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.ListView servicesListView;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader list_price;
        private System.Windows.Forms.ColumnHeader cost_to_us;
        private System.Windows.Forms.ColumnHeader is_sale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown costNumeric;
    }
}