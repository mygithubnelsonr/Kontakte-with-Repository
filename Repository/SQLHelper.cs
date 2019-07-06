using System.Data.SqlClient;

namespace Repository
{
    public class SQLHelper
    {
        SqlConnection conn;

        public SQLHelper(string connectionString)
        {
            conn = new SqlConnection(connectionString);
        }

        public bool IsConnected
        {
            get
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                    conn.Close();
                }
                return true;
            }
        }
    }
}
