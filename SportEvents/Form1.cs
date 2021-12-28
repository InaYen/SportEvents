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
            SqlConnection connection = new(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\minhy\source\repos\SportEvents\SportEvents\SportEventsDB.mdf;Integrated Security=True");
            connection.Open();
            connection.Close();
        }
    }
}