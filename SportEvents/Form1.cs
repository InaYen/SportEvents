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
            events.Clear();
            listViewEvents.Items.Clear();

            events.AddRange(EventsRepository.GetEvents());
            FillImageListFromEvents();
            ListViewItem[] items = TransfromEventsToListViewItems(events);

            listViewEvents.Items.AddRange(items);
        }

        private void FillImageListFromEvents()
        {
            imageList.Images.Clear();

            foreach (var eventModel in events)
            {
                imageList.Images.Add(eventModel.Id.ToString(), eventModel.Image);
            }
        }

        private ListViewItem[] TransfromEventsToListViewItems(List<EventModel> events)
        {
            ListViewItem[] items = new ListViewItem[events.Count];

            for (int i = 0; i < events.Count; i++)
            {
                items[i] = new ListViewItem(events[i].Name, events[i].Id.ToString());
            }

            return items;
        }
               
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            EventModel eventModel = new(
                textBoxName.Text, 
                dateTimePickerStart.Value, 
                dateTimePickerEnd.Value,
                pictureBox.Image,
                OrganizarionsRepository.GetOrganizationIdByName(comboBoxOrganization.Text));

            EventsRepository.Insert(eventModel);
            LoadEvents();
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(openFileDialog.FileName);
            } 
        }
    }
}