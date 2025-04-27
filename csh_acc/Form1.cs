using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace csh_acc
{
    public partial class Form1 : Form
    {
        public static string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = Workers.mdb";

        private OleDbConnection connection;
        public Form1()
        {
            InitializeComponent();

            connection = new OleDbConnection(connectionString);

            connection.Open();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT w_name FROM Worker WHERE w_id = 1";

            OleDbCommand cmd = new OleDbCommand(query, connection);

            textBox1.Text = cmd.ExecuteScalar().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "SELECT w_name, w_position, w_salary FROM Worker ORDER BY w_id";

            OleDbCommand cmd = new OleDbCommand(query, connection);

            OleDbDataReader reader = cmd.ExecuteReader();

            listBox1.Items.Clear();

            while (reader.Read())
            {
                listBox1.Items.Add(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString() + " ");
                
            }

            reader.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Worker (w_name, w_position, w_salary) VALUES ('Михаил', 'Водитель', 20000)";

            OleDbCommand cmd = new OleDbCommand(query, connection);  

            cmd.ExecuteNonQuery();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Worker SET w_salary = 35000 WHERE w_id = 4";

            OleDbCommand cmd = new OleDbCommand(query, connection);

            cmd.ExecuteNonQuery();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Worker WHERE w_id > 4";

            OleDbCommand cmd = new OleDbCommand(query, connection);

            cmd.ExecuteNonQuery();
        }
    }
}