namespace MaratDiplom
{
    partial class ClientOrdersForm
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
            this.components = new System.ComponentModel.Container();
            this.tvbDBDataSet = new MaratDiplom.TvbDBDataSet();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new MaratDiplom.TvbDBDataSetTableAdapters.OrdersTableAdapter();
            this.tableAdapterManager = new MaratDiplom.TvbDBDataSetTableAdapters.TableAdapterManager();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new MaratDiplom.TvbDBDataSetTableAdapters.ClientsTableAdapter();
            this.workersTableAdapter = new MaratDiplom.TvbDBDataSetTableAdapters.WorkersTableAdapter();
            this.servicesTableAdapter = new MaratDiplom.TvbDBDataSetTableAdapters.ServicesTableAdapter();
            this.clientOrdersListView = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.service = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.worker = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.editBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.servicesCbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.workersCbx = new System.Windows.Forms.ComboBox();
            this.clientOrdersFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tvbDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientOrdersFormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tvbDBDataSet
            // 
            this.tvbDBDataSet.DataSetName = "TvbDBDataSet";
            this.tvbDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.tvbDBDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = this.ordersTableAdapter;
            this.tableAdapterManager.ServicesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MaratDiplom.TvbDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkersTableAdapter = null;
            this.tableAdapterManager.WorkerTypesTableAdapter = null;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.tvbDBDataSet;
            // 
            // workersBindingSource
            // 
            this.workersBindingSource.DataMember = "Workers";
            this.workersBindingSource.DataSource = this.tvbDBDataSet;
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataMember = "Services";
            this.servicesBindingSource.DataSource = this.tvbDBDataSet;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // workersTableAdapter
            // 
            this.workersTableAdapter.ClearBeforeFill = true;
            // 
            // servicesTableAdapter
            // 
            this.servicesTableAdapter.ClearBeforeFill = true;
            // 
            // clientOrdersListView
            // 
            this.clientOrdersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.service,
            this.worker,
            this.status,
            this.date});
            this.clientOrdersListView.GridLines = true;
            this.clientOrdersListView.HideSelection = false;
            this.clientOrdersListView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.clientOrdersListView.Location = new System.Drawing.Point(12, 21);
            this.clientOrdersListView.MultiSelect = false;
            this.clientOrdersListView.Name = "clientOrdersListView";
            this.clientOrdersListView.Size = new System.Drawing.Size(699, 317);
            this.clientOrdersListView.TabIndex = 0;
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
            // worker
            // 
            this.worker.Text = "Сотрудник";
            this.worker.Width = 194;
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
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(712, 419);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(189, 60);
            this.editBtn.TabIndex = 1;
            this.editBtn.Text = "Изменить";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(907, 419);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(181, 60);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Создать заявку";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // servicesCbx
            // 
            this.servicesCbx.FormattingEnabled = true;
            this.servicesCbx.Location = new System.Drawing.Point(734, 93);
            this.servicesCbx.Name = "servicesCbx";
            this.servicesCbx.Size = new System.Drawing.Size(305, 24);
            this.servicesCbx.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(748, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Услуги";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(748, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Сотрудники";
            // 
            // workersCbx
            // 
            this.workersCbx.FormattingEnabled = true;
            this.workersCbx.Location = new System.Drawing.Point(734, 211);
            this.workersCbx.Name = "workersCbx";
            this.workersCbx.Size = new System.Drawing.Size(305, 24);
            this.workersCbx.TabIndex = 5;
            // 
            // clientOrdersFormBindingSource
            // 
            this.clientOrdersFormBindingSource.DataSource = typeof(MaratDiplom.ClientOrdersForm);
            // 
            // ClientOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 491);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.workersCbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.servicesCbx);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.clientOrdersListView);
            this.Name = "ClientOrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ваши заказы";
            ((System.ComponentModel.ISupportInitialize)(this.tvbDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientOrdersFormBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource clientOrdersFormBindingSource;
        private TvbDBDataSet tvbDBDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private TvbDBDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private TvbDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private TvbDBDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private TvbDBDataSetTableAdapters.WorkersTableAdapter workersTableAdapter;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private TvbDBDataSetTableAdapters.ServicesTableAdapter servicesTableAdapter;
        private System.Windows.Forms.ListView clientOrdersListView;
        private System.Windows.Forms.ColumnHeader service;
        private System.Windows.Forms.ColumnHeader worker;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ComboBox servicesCbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox workersCbx;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader status;
    }
}