using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MaratDiplom
{
    public partial class ReportForm : Form
    {
        private double endSalary = 0;
        //выручка
        private double revenue = 0;
        //прибыль
        private double profit = 0;
        //затраты
        private double expenses = 0;

        public ReportForm()
        {
            InitializeComponent();
            loadData();
        }

        private void loadSalary()
        {
            salaryLbl.Text = Program.workerData.salary.ToString();
            endSalary = Program.workerData.salary;
            endSalaryLbl.Text = endSalary.ToString();
            profit = 0;
            expenses = 0;
            revenue = 0;
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
                                s.list_price,
                                s.cost_to_us,
                                o.id_worker
                                from Orders as o
                                    inner join Clients as c 
                                on o.id_client = c.id
                                    inner join Workers as w
                                on w.id = o.id_worker
                                inner join Services as s
                                    on s.id = o.id_service
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
                        expenses += Convert.ToDouble(data["cost_to_us"]);
                        revenue += Convert.ToDouble(data["list_price"]);
                        if (Program.user.id.ToString() == data["id_worker"].ToString())
                        {
                            endSalary += Convert.ToDouble(data["list_price"]) / 100 * Program.workerData.percentOrder;
                        }
                    }

                }
                endSalaryLbl.Text = endSalary.ToString();

                profit = revenue - expenses;
                revenueLbl.Text = revenue.ToString();
                profitLbl.Text = profit.ToString();
                expensesLbl.Text = expenses.ToString();
                db.sqlConnection.Close();
            }
            catch { }
        }
    }
}
