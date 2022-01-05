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

        internal static int GetOrganizationIdByName(string name)
        {
            int organizationId = 0;
            SqlCommand command = new($"SELECT Id FROM Organizations WHERE [Name] = '{name}';", DataConnection.Open());

            var reader = command.ExecuteReader();   
            reader.Read();

            organizationId = reader.GetInt32(0);
            DataConnection.Close();

            return organizationId;
        }

        //var reader = command.ExecuteReader();
        //var data = reader.Read();

    }
}
