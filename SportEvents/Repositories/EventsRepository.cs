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
            SqlCommand command = new($"DELETE * FROM Events WHERE Id = {id};", DataConnection.Open());
            command.ExecuteNonQuery();
        }

        public static void Update(EventModel model)
        {
            SqlCommand command = new(
                $"UPDATE Events SET [Name] = '{model.Name}', " +
                $"StartDate = {model.StartDate}, " +
                $"EndDate = {model.EndDate}, " +
                $"OrganizationID = {model.OrganizationId} " +
                $"WHERE Id = {model.Id};", DataConnection.Open());

            command.ExecuteNonQuery();
        }
    }
}