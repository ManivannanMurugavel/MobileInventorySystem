using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Mobiles
{
	public partial class CustomerDetails : Form
	{
		MySqlConnection conn = new MySqlConnection("server=localhost;persistsecurityinfo=False;user id=root;database=swathi_mobiles;allowuservariables=True");
		public CustomerDetails()
		{
			InitializeComponent();
		}

		private void CustomerDetails_Load(object sender, EventArgs e)
		{
			CustomerGridView.RowTemplate.Height = 100;
			try
			{
				conn.Open();
				string query = "select * from customer";
				MySqlCommand cmd = new MySqlCommand(query, conn);
				MySqlDataAdapter da = new MySqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);
				//CustomerGridView.AutoGenerateColumns = false;
				
				//CustomerGridView.ColumnCount = 9;
				//CustomerGridView.Columns[0].Name = "ID";
				CustomerGridView.DataSource = dt;
				CustomerGridView.Columns[0].HeaderText = "ID";
				CustomerGridView.Columns[0].Visible = false;
				CustomerGridView.Columns[1].HeaderText = "Customer ID";

				CustomerGridView.Columns[2].HeaderText = "First Name";

				CustomerGridView.Columns[3].HeaderText = "Last Name";

				CustomerGridView.Columns[4].HeaderText = "Village Name";

				CustomerGridView.Columns[5].HeaderText = "Area Name";


				CustomerGridView.Columns[6].HeaderText = "Mobile Number";

				CustomerGridView.Columns[7].HeaderText = "Pincode";

				CustomerGridView.Columns[8].HeaderText = "Customer Image";

				CustomerGridView.Columns[9].HeaderText = "Created At";
				CustomerGridView.Columns[9].Visible = false;

				da.Dispose();
				cmd.Dispose();
				conn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				if (conn.State == ConnectionState.Open)
				{
					conn.Close();
				}
			}
		}

		private void addCustomer_Click(object sender, EventArgs e)
		{
			AddCustomer addcus = new AddCustomer();
			addcus.Show();
			//this.Hide();
		}

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu mn = new Mobiles.Menu();
            mn.Show();
        }

        private void deleteCustomer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Valid");
        }

        private void updateCustomer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Valid");
        }
    }
}
