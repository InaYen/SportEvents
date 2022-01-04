namespace SportEvents.Models
{
    internal class EventModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public Image Image { get; set; }

        public int OrganizationId { get; set; }
    }
}