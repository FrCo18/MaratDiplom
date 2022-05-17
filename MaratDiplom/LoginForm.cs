using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MaratDiplom
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                string email = emailTxt.Text;
                string password = passTxt.Text;

                Regex regex = new Regex(@"[\w\d]+\@[\w\d]+\.\w+");

                if (regex.IsMatch(email) && password.Length > 0)
                {
                    string query = $"select * from Clients where email = '{email}' and password = '{password}'";
                    SqlCommand cmd = new SqlCommand(query, Program.db.sqlConnection);

                    adapter.SelectCommand = cmd;
                    adapter.Fill(table);
                    var result = table.Select();

                    if (result.Count() == 1)
                    {
                        var array = result[0].ItemArray;
                        Program.user = new User(
                            Convert.ToInt32(array[0]),
                            array[1].ToString(),
                            array[2].ToString(),
                            array[3].ToString(),
                            array[4].ToString(),
                            array[5].ToString(),
                            UserTypes.user
                            );

                        ClientOrdersForm form = new ClientOrdersForm();
                        form.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Не верны имя пользователя или пароль!");
                }
            }
            catch { }
        }

        private void loginWorkerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                string email = emailTxt.Text;
                string password = passTxt.Text;

                Regex regex = new Regex(@"[\w\d]+\@[\w\d]+\.\w+");

                if (regex.IsMatch(email) && password.Length > 0)
                {
                    string query = $@"select w.id,
                                w.email,
                                w.first_name,
                                w.last_name,
                                w.middle_name,
                                w.password,
                                w.phone,
                                t.name as type,
                                w.salary,
                                w.percent_order
                                from Workers as w
                                inner join WorkerTypes as t
                                    on t.id = w.id_type
                                where email = '{email}' and password = '{password}'";
                    SqlCommand cmd = new SqlCommand(query, Program.db.sqlConnection);

                    adapter.SelectCommand = cmd;
                    adapter.Fill(table);
                    var result = table.Select();

                    if (result.Count() == 1)
                    {
                        var worker = result[0].Table.Rows[0];
                        Program.user = new User(
                            Convert.ToInt32(worker["id"]),
                            worker["email"].ToString(),
                            worker["first_name"].ToString(),
                            worker["last_name"].ToString(),
                            worker["middle_name"].ToString(),
                            worker["phone"].ToString(),
                            worker["type"].ToString()
                            );
                        Program.workerData = new WorkerData(Convert.ToDouble(worker["salary"]), Convert.ToInt32(worker["percent_order"]));

                        if (Program.user.type == UserTypes.worker)
                        {
                            OrdersWorkersForm form = new OrdersWorkersForm();
                            form.Show();
                        }
                        else if (Program.user.type == UserTypes.admin)
                        {
                            AdminForm form = new AdminForm();
                            form.Show();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Не верны имя пользователя или пароль!");
                }
            }
            catch { }
        }
    }
}
