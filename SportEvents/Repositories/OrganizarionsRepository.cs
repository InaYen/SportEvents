using SportEvents.Models;
using System.Data.SqlClient;

namespace SportEvents.Repositories
{
    internal class OrganizarionsRepository
    {
        internal static void Delete(int id)
        {
            SqlCommand command = new($"DELETE FROM Organizations WHERE Id = {id};", DataConnection.Open());
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

        internal static void Insert(OrganizationModel organizationModel)
        {
            SqlCommand insertCommand = new(
                "INSERT INTO Organizations ( [Name], SportType ) " +
                "VALUES ( @name, '' );",
                DataConnection.Open());

            insertCommand.Parameters.AddWithValue("@name", organizationModel.Name);

            insertCommand.ExecuteNonQuery();
            DataConnection.Close();
        }

        internal static List<OrganizationModel> GetOrganizations()
        {
            List<OrganizationModel> organizationModels = new();

            SqlCommand command = new($"SELECT * FROM Organizations;", DataConnection.Open());
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                OrganizationModel model = new()
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                };

                organizationModels.Add(model);
            }

            DataConnection.Close();
            return organizationModels;
        }

        internal static void Update(string oldName, string newName)
        {
            SqlCommand command = new(
            $"UPDATE Organizations SET [Name] = '{newName}' " +
            $"WHERE Id = {GetOrganizationIdByName(oldName)};",
            DataConnection.Open());

            command.ExecuteNonQuery();
            DataConnection.Close();
        }

        internal static OrganizationModel GetOrganizationById(int organizationId)
        {
            SqlCommand command = new($"SELECT * FROM Organizations WHERE Id = {organizationId};", DataConnection.Open());
            var reader = command.ExecuteReader();

            reader.Read();
            OrganizationModel model = new()
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1),
            };

            DataConnection.Close();
         
            return model;
        }
    }
}