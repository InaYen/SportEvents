using System.Data.SqlClient;

namespace SportEvents.Repositories
{
    internal class OrganizarionsRepository
    {
        public void Delete(int id)
        {
            SqlCommand command = new($"DELETE * FROM Organizations WHERE Id = {id};", DataConnection.Open());
            command.ExecuteNonQuery();

            DataConnection.Close(); 
        }

        //var reader = command.ExecuteReader();
        //var data = reader.Read();

    }
}
