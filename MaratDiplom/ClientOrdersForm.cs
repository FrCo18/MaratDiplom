using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MaratDiplom
{
    public partial class ClientOrdersForm : Form
    {
        public ClientOrdersForm()
        {
            InitializeComponent();
            loadData();
            loadServices();
            loadWorkers();
        }

        private void loadServices()
        {
            try
            {
                DB db = new DB();
                servicesCbx.Items.Clear();
                string sql = $@"select 
                                id,
                                CONCAT(s.name, ' Р', CAST(s.list_price as varchar)) as service
                                from Services as s
                                where s.is_sale = 1
                                ";

                SqlCommand cmd = new SqlCommand(sql, db.sqlConnection);

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                adapter.SelectCommand = cmd;
                SqlDataReader reader = cmd.ExecuteReader();
                string firstItem = "";
                while (reader.Read())
                {
                    var item = reader;
                    var cmbItem = item["id"] + ". " + item["service"];
                    firstItem = firstItem == "" ? cmbItem : firstItem;

                    servicesCbx.Items.Add(cmbItem);
                }

                servicesCbx.SelectedItem = firstItem;
                db.sqlConnection.Close();

            }
            catch { }
        }

        private void loadWorkers()
        {
            try
            {
                DB db = new DB();
                workersCbx.Items.Clear();
                string sql = $@"select 
                                id,
                                CONCAT(w.last_name, ' ', w.first_name, ' ', w.email) as worker
                                from Workers as w
                                ";

                SqlCommand cmd = new SqlCommand(sql, db.sqlConnection);

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                adapter.SelectCommand = cmd;
                SqlDataReader reader = cmd.ExecuteReader();
                string firstItem = "";
                while (reader.Read())
                {
                    var item = reader;
                    var cmbItem = item["id"] + ". " + item["worker"];
                    firstItem = firstItem == "" ? cmbItem : firstItem;

                    workersCbx.Items.Add(cmbItem);
                }

                workersCbx.SelectedItem = firstItem;
                db.sqlConnection.Close();
            }
            catch { }
        }

        private void loadData()
        {
            try
            {
                DB db = new DB();
                clientOrdersListView.Items.Clear();

                string sql = $@"select 
                                o.id,
                                CONCAT(s.name, ' Р', CAST(s.list_price as varchar)) as service,
                                CONCAT(w.last_name, ' ', w.first_name, ' ', w.email) as worker,
                                o.is_complete,
                                o.date
                                from Orders as o
                                    inner join Clients as c 
                                on o.id_client = c.id
                                    inner join Workers as w
                                on w.id = o.id_worker
                                inner join Services as s
                                    on s.id = o.id_service
                                where o.id_client = {Program.user.id}
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


                    ListViewItem listViewItem = new ListViewItem(new string[] {
                    result[i].Table.Rows[i]["id"].ToString(),
                    result[i].Table.Rows[i]["service"].ToString(),
                    result[i].Table.Rows[i]["worker"].ToString(),
                    status,
                    $"{date.Year}-{date.Month}-{date.Day}"
                });
                    clientOrdersListView.Items.Add(listViewItem);
                    clientOrdersListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
                db.sqlConnection.Close();
            }
            catch { }
        }

        private void editBtn_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (clientOrdersListView.SelectedItems.Count == 1)
                {
                    DB db = new DB();
                    char id_worker = workersCbx.Text[0];
                    char id_service = servicesCbx.Text[0];
                    string sql = $@"update Orders 
                            set id_worker = {id_worker}, id_service = {id_service}
                            where id = {clientOrdersListView.SelectedItems[0].SubItems[0].Text}";
                    SqlCommand cmd = new SqlCommand(sql, db.sqlConnection);
                    cmd.ExecuteNonQuery();
                    loadData();
                }
            }
            catch { }
        }

        private void addBtn_Click(object sender, System.EventArgs e)
        {
            try
            {
                DB db = new DB();
                char id_worker = workersCbx.Text[0];
                char id_service = servicesCbx.Text[0];
                string sql = $@"insert into Orders (id_client, id_worker, id_service, is_complete)
                          values ({Program.user.id}, {id_worker}, {id_service}, 0)";
                SqlCommand cmd = new SqlCommand(sql, db.sqlConnection);
                cmd.ExecuteNonQuery();
                loadData();
            }
            catch { }
        }
    }
}
