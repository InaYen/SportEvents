namespace SportEvents.Models
{
    internal class OrganizationModel
    {
        public OrganizationModel()
        {
        }

        public OrganizationModel(string name)
        {
            Name = name;
        }

        public int Id { get; set; }

        public string Name { get; set; }
    }
}