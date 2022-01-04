using System.Data.SqlClient;

namespace SportEvents.Repositories
{
    internal static class DataConnection
    {
        public const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Projects\ToDelete\SportEvents\SportEvents\SportEventsDB.mdf;Integrated Security=True";
        private static SqlConnection connection;

        public static SqlConnection Open()
        {
            connection = new SqlConnection(ConnectionString);
            connection.Open();
            return connection;
        }

        public static void Close()
        {
            connection.Close();
        }
    }
}