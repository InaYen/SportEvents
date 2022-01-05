namespace SportEvents.Models
{
    internal class EventModel
    {
        public EventModel()
        {
        }

        public EventModel(string name, DateTime startDate, DateTime endDate, Image image, int organizarionId)
        {
            Name = name;
            StartDate = startDate;  
            EndDate = endDate;
            Image = image;  
            OrganizationId = organizarionId;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public Image Image { get; set; }

        public int OrganizationId { get; set; }
    }
}