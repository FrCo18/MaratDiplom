using System.Data.SqlClient;

namespace MaratDiplom
{
    class DB
    {
        public SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-5U8VVG6;Initial Catalog=TvbDB;Integrated Security=True");


        public DB()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return sqlConnection;
        }
    }
}
