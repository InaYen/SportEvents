using SportEvents.Models;
using SportEvents.Repositories;

namespace SportEvents
{
    public partial class Form1 : Form
    {
        private readonly List<EventModel> events = new();

        public Form1()
        {
            InitializeComponent();

            LoadEvents();
        }

        private void LoadEvents()
        {
            listViewEvents.Items.Clear();

            events.AddRange(EventsRepository.GetEvents());
            ListViewItem[] items = TransfromEventsToListViewItems(events);

            listViewEvents.Items.AddRange(items);
        }

        private ListViewItem[] TransfromEventsToListViewItems(List<EventModel> events)
        {
            ListViewItem[] items = new ListViewItem[events.Count];

            for (int i = 0; i < events.Count; i++)
            {
                items[i] = new ListViewItem(events[i].Name, 0);
            }

            return items;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dataGridViewEvents.DataSource = EventsRepository.GetEvents();
        }
    }
}