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
	public partial class PriceForm : Form
	{
		MySqlConnection con = new MySqlConnection("server=localhost;persistsecurityinfo=False;user id=root;database=swathi_mobiles;allowuservariables=True");
		public PriceForm()
		{
			InitializeComponent();
		}

		private void addproduct_Click(object sender, EventArgs e)
		{
			try
			{
				//this.Close();
				int price_product = Convert.ToInt32(textBox1.Text);
				string product_id = PriceDetails.product_id;
				con.Open();
				string qry = "update product_price set product_price=" + price_product + " where product_id='" + product_id + "'";
				MySqlCommand cmd = new MySqlCommand(qry, con);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Updated");
				//MessageBox.Show(product_id);
			}
			catch (Exception tr)
			{
				MessageBox.Show(tr.ToString());
			}
			finally
			{
				con.Close();
			}
		}

		private void PriceForm_Load(object sender, EventArgs e)
		{

		}
	}
}
