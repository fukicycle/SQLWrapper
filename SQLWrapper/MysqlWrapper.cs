using MySql.Data.MySqlClient;

namespace SQLWrapper
{
    public class MysqlWrapper
    {
        private MysqlWrapper()
        {
            // private constractor
        }

        private static MysqlWrapper _mysqlWrapper = new MysqlWrapper();
        public static bool Connect()
        {
            MySqlConnection conn = new MySqlConnection(DBSettings.GetConnectionString());
            conn.Open();
            if (conn.State == System.Data.ConnectionState.Open) return true;
            return false;
        }

        public static MysqlWrapper GetInstance()
        {
            return _mysqlWrapper;
        }

        public object Select(string selectStatement)
        {
            using (MySqlConnection conn = new MySqlConnection(DBSettings.GetConnectionString()))
            {
                using (MySqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = selectStatement;
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        int index = 1;
                        while (reader.Read())
                        {
                            Type type = reader.GetFieldType(index);
                        }
                    }
                }
            }
        }
    }
}
