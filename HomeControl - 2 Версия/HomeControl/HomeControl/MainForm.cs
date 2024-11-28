using System.Data;
using System.Data.SqlClient;
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

        private void button4_Click(object sender, EventArgs e)
        {
            string querrry = "SELECT SUM(P.price_per_square * A.square + P.price_per_person * A.peoples_count) AS total_monthly_payment " +
                "FROM Apartments A " +
                "JOIN Paying Py ON A.apartament_id = Py.apartament_id " +
                "JOIN Payment P ON Py.payment_id = P.payment_id " +
                "WHERE A.house_number = 5;";
            ExecuteQueryAndFillDataGridView(querrry, dataGridView1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string querrry = "SELECT SUM(Py.summary_payment - Py.year_pay) AS dolg " +
                "FROM Paying Py " +
                "JOIN Apartments A ON Py.apartament_id = A.apartament_id " +
                "JOIN Payment P ON Py.payment_id = P.payment_id " +
                "WHERE A.house_number = 5 " +
                "AND A.apartament_number = 512 " +
                "AND P.type = 'теплоснабжение';";
            ExecuteQueryAndFillDataGridView(querrry, dataGridView1);
        }
        public void ExecuteQueryAndFillDataGridView(string query, DataGridView dataGridView)
        {
            try
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выполнении запроса: " + ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string querrry = "SELECT SUM(peoples_count) AS total_res FROM Apartments WHERE house_number = 5;";
            ExecuteQueryAndFillDataGridView(querrry, dataGridView1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string querrry = "SELECT A.apartament_number FROM Apartments A JOIN Paying Py ON A.apartament_id = Py.apartament_id WHERE Py.summary_payment = Py.year_pay;";
            ExecuteQueryAndFillDataGridView(querrry, dataGridView1);
        }
    }
}
