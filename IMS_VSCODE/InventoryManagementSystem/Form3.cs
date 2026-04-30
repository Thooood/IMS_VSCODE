using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
	public partial class Form3 : Form
	{
		string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=IMS;Integrated Security=True";
		public Form3()
		{
			InitializeComponent();
		}

		private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void transactionsToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			Main_Form transac = new Main_Form();
			transac.ShowDialog();
		}

		private void Form3_Load(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			DataGridViewRow row = dataGridView1.CurrentRow;

			string productId = row.Cells["ProductID"].Value.ToString();
			string stock = row.Cells["Column2"].Value.ToString();
			string productName = row.Cells["Column3"].Value.ToString();
			string date = row.Cells["Column4"].Value.ToString();
			decimal price = Convert.ToDecimal(row.Cells["Column5"].Value);
			string category = row.Cells["Column6"].Value.ToString();


			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				conn.Open();
				string query = "INSERT INTO PRODUCTS (ProductName, Category, Price, Stock) VALUES (@name, @cat, @price, @stock)";
				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					cmd.Parameters.AddWithValue("@name", productName);
					cmd.Parameters.AddWithValue("@cat", category);
					cmd.Parameters.AddWithValue("@price", price);
					cmd.Parameters.AddWithValue("@stock", stock);

					cmd.ExecuteNonQuery();
					MessageBox.Show("Product added successfully!");
				}
			}
		}
	}
}
