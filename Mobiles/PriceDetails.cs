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
	public partial class PriceDetails : Form
	{
		MySqlConnection conn = new MySqlConnection("server=localhost;persistsecurityinfo=False;user id=root;database=swathi_mobiles;allowuservariables=True");
		static DataTable dt = new DataTable();
		PriceForm pf = new PriceForm();
		public static string product_id = "welcome";
		public PriceDetails()
		{
			InitializeComponent();
		}

		private void PriceDetails_Load(object sender, EventArgs e)
		{
			try
			{
				dt.Columns.Add("Id");
				dt.Columns.Add("Product Id");
				dt.Columns.Add("Product Price");
				conn.Open();
				string qry = "select * from product_price";
				MySqlCommand cmd = new MySqlCommand(qry, conn);
				MySqlDataAdapter da = new MySqlDataAdapter(cmd);
				DataTable dte = new DataTable();
				da.Fill(dte);
				ProductDetails.DataSource = dte;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		private string getGridIndexValue()
		{
			try
			{
				int id = ProductDetails.CurrentCell.RowIndex;
				return ProductDetails[1, id].Value.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Please show the products");
			}
			return "";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			product_id = getGridIndexValue();
			//MessageBox.Show(value);
			pf.Show();
		}
	}
}
