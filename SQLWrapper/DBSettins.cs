namespace SQLWrapper
{
    public static class DBSettings
    {
        public static string DB_USERNAME = "";
        public static string DB_PASSWORD = "";
        public static string DB_NAME = "";
        public static string DB_HOST = "localhost";

        public static string GetConnectionString()
        {
            if (DB_USERNAME == string.Empty || DB_PASSWORD == string.Empty || DB_NAME == string.Empty) return "Required parameter is not set.";
            return $"SERVER={DB_HOST}; DATABASE={DB_NAME}; UID={DB_USERNAME}; PASSWORD={DB_PASSWORD};";
        }
    }
}