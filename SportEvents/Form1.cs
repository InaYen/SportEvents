using SportEvents.Repositories;
using System.Data.SqlClient;

namespace SportEvents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            EventsRepository repository = new EventsRepository();
            dataGridViewEvents.DataSource = repository.GetEvents();
        }
    }
}