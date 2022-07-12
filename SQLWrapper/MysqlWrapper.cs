using MySql.Data.MySqlClient;
using System.Data;

namespace SQLWrapper
{
    public class MysqlWrapper
    {
        private MysqlWrapper()
        {
            // private constractor
        }

        private static MysqlWrapper _mysqlWrapper = new MysqlWrapper();

        public static MysqlWrapper GetInstance()
        {
            return _mysqlWrapper;
        }

        public DataTable Select(string selectStatement)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(DBSettings.GetConnectionString()))
            {
                using (MySqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = selectStatement;
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
                conn.Close();
            }
            return dt;
        }
    }
}
