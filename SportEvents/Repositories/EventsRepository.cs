using System.Data;
using System.Data.SqlClient;

namespace SportEvents.Repositories
{
    internal class EventsRepository
    {
        public DataTable GetEvents()
        {
            SqlCommand command = new($"SELECT * FROM Events;", DataConnection.Open());
            var reader = command.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);

            DataConnection.Close();
            return table;
        }
    }
}