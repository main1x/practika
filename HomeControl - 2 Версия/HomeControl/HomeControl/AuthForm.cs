using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeControl
{
    public partial class AuthForm : Form
    {
        public static SQLiteConnection connection = new SQLiteConnection(Program.connection);

        public AuthForm()
        {
            InitializeComponent();
            connection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM Users", connection);
            SQLiteDataReader reader = command.ExecuteReader();
            if (reader != null)
            {
                while (reader.Read())
                {
                    string name = reader["name"].ToString();
                    string pass = reader["password"].ToString();
                    if (name == textBox1.Text && pass == textBox2.Text)
                    {
                        Thread thread = new Thread(OpenMain);
                        thread.Start();
                        Close();
                    }
                }
            }
        }

        private void OpenMain(object? obj)
        {
            Application.Run(new MainForm());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SQLiteCommand sQLiteCommand = new SQLiteCommand("INSERT INTO Users (name, password) VALUES (@name, @password)", connection);
            sQLiteCommand.Parameters.AddWithValue("@name", textBox1.Text);
            sQLiteCommand.Parameters.AddWithValue("@password", textBox2.Text);
            sQLiteCommand.ExecuteNonQuery();
            Thread thread = new Thread(OpenMain);
            thread.Start();
            Close();
        }
    }
}
