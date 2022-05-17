using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MaratDiplom
{
    public partial class OrdersWorkersForm : Form
    {
        private double endSalary = 0;

        public OrdersWorkersForm()
        {
            InitializeComponent();
            loadData();
            loadStatus();
        }

        private void loadStatus()
        {
            try
            {
                statusCbx.SelectedItem = "Выполнен";

            }
            catch { }
        }

        private void loadSalary()
        {
            salaryLbl.Text = Program.workerData.salary.ToString();
            endSalary = Program.workerData.salary;
            endSalaryLbl.Text = endSalary.ToString();
        }

        private void loadData()
        {
            try
            {
                loadSalary();
                DB db = new DB();
                clientOrdersListView.Items.Clear();

                DateTime now = DateTime.Now;

                string sql = $@"select 
                                o.id,
                                CONCAT(s.name, ' Р', CAST(s.list_price as varchar)) as service,
                                CONCAT(c.last_name, ' ', c.first_name, ' ', c.email) as client,
                                o.is_complete,
                                o.date,
                                s.list_price
                                from Orders as o
                                    inner join Clients as c 
                                on o.id_client = c.id
                                    inner join Workers as w
                                on w.id = o.id_worker
                                inner join Services as s
                                    on s.id = o.id_service
                                where o.id_worker = {Program.user.id}
                                and FORMAT(o.date, 'yyyy-M') = '{now.Year}-{now.Month}'
                                order by o.id desc
                                ";

                SqlCommand cmd = new SqlCommand(sql, db.sqlConnection);

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                adapter.SelectCommand = cmd;

                adapter.Fill(table);

                var result = table.Select();



                for (int i = 0; i < result.Length; i++)
                {
                    var resultDate = result[i].Table.Rows[i]["date"];
                    var date = Convert.ToDateTime(resultDate);
                    string status = Convert.ToBoolean(result[i].Table.Rows[i]["is_complete"]) ? "Выполнен" : "Не выполнен";

                    var data = result[i].Table.Rows[i];

                    ListViewItem listViewItem = new ListViewItem(new string[] {
                    data["id"].ToString(),
                    data["service"].ToString(),
                    data["client"].ToString(),
                    status,
                    $"{date.Year}-{date.Month}-{date.Day}"
                });

                    clientOrdersListView.Items.Add(listViewItem);
                    clientOrdersListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

                    if (status == "Выполнен")
                    {
                        endSalary += Convert.ToDouble(data["list_price"]) / 100 * Program.workerData.percentOrder;
                    }
                }
                endSalaryLbl.Text = endSalary.ToString();
                db.sqlConnection.Close();
            }
            catch { }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (clientOrdersListView.SelectedItems.Count == 1)
                {
                    DB db = new DB();
                    int status = statusCbx.Text == "Выполнен" ? 1 : 0;
                    string sql = $@"update Orders 
                            set is_complete = {status}
                            where id = {clientOrdersListView.SelectedItems[0].SubItems[0].Text}";
                    SqlCommand cmd = new SqlCommand(sql, db.sqlConnection);
                    cmd.ExecuteNonQuery();
                    loadData();
                }
            }
            catch { }
        }
    }
}
