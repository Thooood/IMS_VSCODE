using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace InventoryManagementSystem
{
	public partial class Forgot_Password : Form
	{
		string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=IMS;Integrated Security=True";
		public Forgot_Password()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{


			string username = textBox5.Text.Trim();
			string newPassword = textBox4.Text.Trim();
			string confirmPassword = textBox1.Text.Trim();

			// 1. Validation
			if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
			{
				MessageBox.Show("All fields are required.");
				return;
			}

			if (newPassword != confirmPassword)
			{
				MessageBox.Show("Passwords do not match.");
				return;
			}

			// 2. Update database (no hashing)
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				conn.Open();
				string query = "UPDATE Users SET Password=@password WHERE Username=@username";

				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					cmd.Parameters.AddWithValue("@password", newPassword); // plain text password
					cmd.Parameters.AddWithValue("@username", username);

					int rowsAffected = cmd.ExecuteNonQuery();

					if (rowsAffected > 0)
						MessageBox.Show("Password updated successfully!");
					else
						MessageBox.Show("User not found.");
				}
			}

		}
	}		

	}


