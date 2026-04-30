using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
		string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=IMS;Integrated Security=True";

		private void button1_Click(object sender, EventArgs e)
        {
			string username = textBox1.Text.Trim();
			string password = textBox2.Text.Trim();
			string confirmPassword = textBox3.Text.Trim(); // assuming this is Confirm Password
			string email = textBox4.Text.Trim(); // optional if you added email

			// 1. Validation
			if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
			{
				MessageBox.Show("All fields are required.");
				return;
			}

			if (password != confirmPassword)
			{
				MessageBox.Show("Passwords do not match.");
				return;
			}

			// 2. Insert into database
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				conn.Open();
				string query = "INSERT INTO Users (Username, Password, Email) VALUES (@username, @password, @email)";
				SqlCommand cmd = new SqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@username", username);
				cmd.Parameters.AddWithValue("@password", password); 
				cmd.Parameters.AddWithValue("@email", email);

				try
				{
					cmd.ExecuteNonQuery();
					MessageBox.Show("User registered successfully!");
					this.Close(); 
				}
				catch (SqlException ex)
				{
					MessageBox.Show("Error: " + ex.Message);
				}
			}
		}

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void logInToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form log_in = new Form();
			log_in.ShowDialog();
		}

		private void signUpToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form2 Sign = new Form2();
			Sign.ShowDialog();
		}
	}
}
