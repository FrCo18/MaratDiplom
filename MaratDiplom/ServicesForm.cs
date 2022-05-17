using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MaratDiplom
{
    public partial class ServicesForm : Form
    {
        public ServicesForm()
        {
            InitializeComponent();
            loadData();
            loadStatus();
        }

        private void loadStatus()
        {
            try
            {
                statusCbx.SelectedItem = "В продаже";

            }
            catch { }
        }

        private void loadData()
        {
            try
            {
                DB db = new DB();
                servicesListView.Items.Clear();

                string sql = $@"select * from Services order by id desc";
                SqlCommand cmd = new SqlCommand(sql, db.sqlConnection);

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                adapter.SelectCommand = cmd;

                adapter.Fill(table);

                var result = table.Select();



                for (int i = 0; i < result.Length; i++)
                {
                    string status = Convert.ToBoolean(result[i].Table.Rows[i]["is_sale"]) ? "В продаже" : "Не в продаже";


                    ListViewItem listViewItem = new ListViewItem(new string[] {
                    result[i].Table.Rows[i]["id"].ToString(),
                    result[i].Table.Rows[i]["name"].ToString(),
                    result[i].Table.Rows[i]["list_price"].ToString(),
                    result[i].Table.Rows[i]["cost_to_us"].ToString(),
                    status,
                });
                    servicesListView.Items.Add(listViewItem);
                    servicesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
                db.sqlConnection.Close();
            }
            catch { }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (servicesListView.SelectedItems.Count == 1)
                {
                    DB db = new DB();
                    string name = nameTxb.Text;
                    string list_price = listNumeric.Value.ToString();
                    string cost_to_us = costNumeric.Value.ToString();
                    int status = statusCbx.Text == "В продаже" ? 1 : 0;
                    string sql = $@"update Services
                                    set name = '{name}',
                                    list_price = {list_price},
                                    cost_to_us = {cost_to_us},
                                    is_sale = {status}
                                where id = {servicesListView.SelectedItems[0].SubItems[0].Text}";
                    SqlCommand cmd = new SqlCommand(sql, db.sqlConnection);
                    cmd.ExecuteNonQuery();
                    loadData();
                }
            }
            catch { }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DB db = new DB();
                string name = nameTxb.Text;
                string list_price = listNumeric.Value.ToString();
                string cost_to_us = costNumeric.Value.ToString();
                int status = statusCbx.Text == "В продаже" ? 1 : 0;
                string sql = $@"insert into Services (name, list_price, cost_to_us, is_sale)
                          values ({name}, {list_price}, {cost_to_us}, {status})";
                SqlCommand cmd = new SqlCommand(sql, db.sqlConnection);
                cmd.ExecuteNonQuery();
                loadData();
            }
            catch { }
        }
    }
}
