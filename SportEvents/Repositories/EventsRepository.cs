using SportEvents.Helpers;
using SportEvents.Models;
using System.Data.SqlClient;

namespace SportEvents.Repositories
{
    internal class EventsRepository
    {
        public static List<EventModel> GetEvents()
        {
            List<EventModel> events = new();

            SqlCommand command = new($"SELECT * FROM Events;", DataConnection.Open());
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                EventModel model = new()
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    StartDate = reader.GetDateTime(2),
                    EndDate = reader.GetDateTime(3),
                    Image = ImageHelper.GetImage(reader.GetStream(4)),
                    OrganizationId = reader.GetInt32(5),
                };

                events.Add(model);
            }

            DataConnection.Close();
            return events;
        }

        public static void DeleteEvent(int id)
        {
            SqlCommand command = new($"DELETE FROM Events WHERE Id = {id};", DataConnection.Open());
            command.ExecuteNonQuery();

            DataConnection.Close();
        }

        public static void Update(EventModel model)
        {
            SqlCommand updateCommand = new(
               "UPDATE Events SET " +
               "[Name] = @name, " +
               "StartDate = @startDate, " +
               "EndDate = @endDate, " +
               "[Image] = @image, " +
               "OrganizationID = @organizationId " +
               "WHERE Id = @id;",
               DataConnection.Open());

            updateCommand.Parameters.AddWithValue("@id", model.Id);
            updateCommand.Parameters.AddWithValue("@name", model.Name);
            updateCommand.Parameters.AddWithValue("@startDate", model.StartDate);
            updateCommand.Parameters.AddWithValue("@endDate", model.EndDate);
            updateCommand.Parameters.AddWithValue("@image", ImageHelper.GetBinaryData(model.Image));
            updateCommand.Parameters.AddWithValue("@organizationId", model.OrganizationId);

            updateCommand.ExecuteNonQuery();
            DataConnection.Close();
        }

        internal static void Insert(EventModel eventModel)
        {
            SqlCommand insertCommand = new(
                "INSERT INTO Events ( [Name], StartDate, EndDate, [Image], OrganizationID ) " +
                "VALUES ( @name, @startDate, @endDate, @image, @organizationId );",
                DataConnection.Open());

            insertCommand.Parameters.AddWithValue("@name", eventModel.Name);
            insertCommand.Parameters.AddWithValue("@startDate", eventModel.StartDate);
            insertCommand.Parameters.AddWithValue("@endDate", eventModel.EndDate);
            insertCommand.Parameters.AddWithValue("@image", ImageHelper.GetBinaryData(eventModel.Image));
            insertCommand.Parameters.AddWithValue("@organizationId", eventModel.OrganizationId);

            insertCommand.ExecuteNonQuery();
            DataConnection.Close();
        }

        internal static EventModel GetEventById(int selectedEventId)
        {
            SqlCommand command = new($"SELECT * FROM Events WHERE Id = {selectedEventId};", DataConnection.Open());
            var reader = command.ExecuteReader();
            reader.Read();

            EventModel model = new()
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1),
                StartDate = reader.GetDateTime(2),
                EndDate = reader.GetDateTime(3),
                Image = ImageHelper.GetImage(reader.GetStream(4)),
                OrganizationId = reader.GetInt32(5),
            };

            DataConnection.Close();
            return model;
        }
    }
}