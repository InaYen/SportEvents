using SportEvents.Models;
using SportEvents.Repositories;

namespace SportEvents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LoadEvents();
            LoadOrganizations();
        }

        private void LoadComboBoxOrganizations()
        {
            comboBoxOrganization.Items.Clear();

            List<OrganizationModel> organizations = OrganizarionsRepository.GetOrganizations();

            foreach (var organization in organizations)
            {
                comboBoxOrganization.Items.Add(organization.Name);
            }

            comboBoxOrganization.SelectedIndex = 0;
        }

        private void LoadEvents()
        {
            listViewEvents.Items.Clear();

            FillImageListFromEvents();
            ListViewItem[] items = TransfromEventsToListViewItems(EventsRepository.GetEvents());

            listViewEvents.Items.AddRange(items);
        }

        private void FillImageListFromEvents()
        {
            imageList.Images.Clear();

            foreach (var eventModel in EventsRepository.GetEvents())
            {
                imageList.Images.Add(eventModel.Id.ToString(), eventModel.Image);
            }
        }

        private static ListViewItem[] TransfromEventsToListViewItems(List<EventModel> events)
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
            FillEventInformation(null);
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void ButtonAddOrganization_Click(object sender, EventArgs e)
        {
            OrganizationModel organizationModel = new(textBoxOrganization.Text);

            OrganizarionsRepository.Insert(organizationModel);
            LoadOrganizations();
        }

        private void LoadOrganizations()
        {
            listBoxOrganizations.Items.Clear();
            LoadComboBoxOrganizations();

            List<OrganizationModel> organizations = OrganizarionsRepository.GetOrganizations();

            foreach (var organization in organizations)
            {
                listBoxOrganizations.Items.Add(organization.Name);
            }
        }

        private void ButtonEditOrganization_Click(object sender, EventArgs e)
        {
            OrganizarionsRepository.Update(listBoxOrganizations.SelectedItem.ToString(), textBoxOrganization.Text);
            LoadOrganizations();
        }

        private void ButtonDeleteOrganization_Click(object sender, EventArgs e)
        {
            int organizationToDelete = OrganizarionsRepository.GetOrganizationIdByName(listBoxOrganizations.SelectedItem.ToString());
            OrganizarionsRepository.Delete(organizationToDelete);

            LoadOrganizations();
        }

        private void ListViewEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewEvents.SelectedItems.Count == 0)
            {
                return;
            }

            int selectedEventId = Convert.ToInt32(listViewEvents.SelectedItems[0].ImageKey);

            EventModel eventModel = EventsRepository.GetEventById(selectedEventId);

            FillEventInformation(eventModel);
        }

        private void FillEventInformation(EventModel? eventModel)
        {
            if (eventModel == null)
            {
                textBoxName.Text = "";
                dateTimePickerStart.Value = DateTime.Today;
                dateTimePickerEnd.Value = DateTime.Today;
                pictureBox.Image = Properties.Resources.select;
                comboBoxOrganization.SelectedIndex = 0;
            }
            else
            {
                textBoxName.Text = eventModel.Name;
                dateTimePickerStart.Value = eventModel.StartDate;
                dateTimePickerEnd.Value = eventModel.EndDate;
                pictureBox.Image = eventModel.Image;
                comboBoxOrganization.SelectedItem = OrganizarionsRepository.GetOrganizationById(eventModel.OrganizationId).Name;
            }
        }

        private void ButtonDedlete_Click(object sender, EventArgs e)
        {
            int selectedEventId = Convert.ToInt32(listViewEvents.SelectedItems[0].ImageKey);
            EventsRepository.DeleteEvent(selectedEventId);

            LoadEvents();
            FillEventInformation(null);
        }
    }
}