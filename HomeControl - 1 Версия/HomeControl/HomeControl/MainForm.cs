using System.Data;
using System.Data.SQLite;

namespace HomeControl
{
    public partial class MainForm : Form
    {
        public static SQLiteConnection connection = new SQLiteConnection(Program.connection);
        public MainForm()
        {
            InitializeComponent();
            connection.Open();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LoadDataGrid("Apartments");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadDataGrid("Apartments");
        }
        public void LoadDataGrid(string TableName)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            string sqlResponse = $"SELECT * FROM {TableName}";
            SQLiteCommand sQLiteCommand = new SQLiteCommand(sqlResponse, connection);
            SQLiteDataAdapter sQLiteDataAdapter = new SQLiteDataAdapter(sQLiteCommand);
            DataTable dt = new DataTable();
            sQLiteDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadDataGrid("Payment");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadDataGrid("Paying");
        }
    }
}
