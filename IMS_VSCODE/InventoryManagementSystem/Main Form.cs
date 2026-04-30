using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class Main_Form : Form
    {
		string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=IMS;Integrated Security=True";
		public Main_Form()
        {
            InitializeComponent();
        }

        private void productIDToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

		private void Main_Form_Load(object sender, EventArgs e)
		{

		}
	}
}
