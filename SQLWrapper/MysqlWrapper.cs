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
    }
}
