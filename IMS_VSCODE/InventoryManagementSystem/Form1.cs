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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InventoryManagementSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
		string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=IMS;Integrated Security=True";


		private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

		private void button1_Click(object sender, EventArgs e)
		{
			string username = textBox1.Text.Trim();
			string password = textBox2.Text.Trim();

			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				conn.Open();

				string query = "SELECT * FROM Users WHERE Username=@username AND Password=@password";

				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					cmd.Parameters.AddWithValue("@username", username);
					cmd.Parameters.AddWithValue("@password", password); // no hashing

					SqlDataReader reader = cmd.ExecuteReader();

					if (reader.HasRows)
					{
						MessageBox.Show("Login successful!");
						
					}
					else
					{
						MessageBox.Show("Incorrect username or password.");
					}
				}
			}


		}
		

		private void button2_Click(object sender, EventArgs e)
		{
            Form2 signup = new Form2();
            signup.ShowDialog();
		}

		private void logInToolStripMenuItem_Click(object sender, EventArgs e)
		{
            Form2 log_in = new Form2();
            log_in.ShowDialog();
		}

		private void signUpToolStripMenuItem_Click(object sender, EventArgs e)
		{
            Form2 sign = new Form2();
            sign.ShowDialog();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
            Forgot_Password forgot = new Forgot_Password();
            forgot.ShowDialog();
		}
	}
}
