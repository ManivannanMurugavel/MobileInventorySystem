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
	public partial class ProductDetails : Form
	{
		public static string status = "";
		public static string frmPrdId = "";
		//public static string SetValueForText2 = "";
		//public static string SetValueForText3 = "";

		MySqlConnection conn = new MySqlConnection("server=localhost;persistsecurityinfo=False;user id=root;database=swathi_mobiles;allowuservariables=True");
		public ProductDetails()
		{
			InitializeComponent();
		}

		private void addProduct_Click(object sender, EventArgs e)
		{
			status = "insert";
			addProduct ap = new Mobiles.addProduct();
			ap.Show();
		}

		private void ProductDetails_Load(object sender, EventArgs e)
		{
			updateProduct.Enabled = false;	
		}
		private void showProdutsToGrid()
		{
			productLists.RowTemplate.Height = 100;
			try
			{
				conn.Open();
				string query = "select * from product where is_enable='true'";
				MySqlCommand cmd = new MySqlCommand(query, conn);
				MySqlDataAdapter da = new MySqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);
				/*productLists.AutoGenerateColumns = false;

				productLists.ColumnCount = 9;
				productLists.Columns[0].HeaderText = "ID";
				productLists.Columns[0].DataPropertyName = "id";
				productLists.Columns[1].Width = 100;
				productLists.Columns[1].HeaderText = "Product ID";
				productLists.Columns[1].DataPropertyName = "product_id";
				productLists.Columns[2].HeaderText = "Product Type";
				productLists.Columns[2].DataPropertyName = "product_type";
				productLists.Columns[3].HeaderText = "Brand Name";
				productLists.Columns[3].DataPropertyName = "brand_name";
				productLists.Columns[4].HeaderText = "Model Name";
				productLists.Columns[4].DataPropertyName = "model_name";
				productLists.Columns[5].HeaderText = "Quantity";
				productLists.Columns[5].DataPropertyName = "no_qty";
				productLists.Columns[6].Width = 150;
				productLists.Columns[6].HeaderText = "Product Price";
				productLists.Columns[6].DataPropertyName = "each_price";
				productLists.Columns[7].HeaderText = "Total Price";
				productLists.Columns[7].DataPropertyName = "total_price";
				productLists.Columns[8].HeaderText = "Product Image";
				productLists.Columns[8].DataPropertyName = "prd_image";*/
				productLists.DataSource = dt;
				productLists.Columns[0].HeaderText = "ID";
				productLists.Columns[1].HeaderText = "Product ID";
				productLists.Columns[2].HeaderText = "Product Type";
				productLists.Columns[3].HeaderText = "Brand Name";
				productLists.Columns[4].HeaderText = "Model Name";
				productLists.Columns[5].HeaderText = "Cre Date";
				productLists.Columns[5].Visible = false;
				productLists.Columns[6].HeaderText = "Up Date";
				productLists.Columns[6].Visible = false;
				//productLists.Columns[5].HeaderText = "Model Name";
				productLists.Columns[7].HeaderText = "Quantity";
				productLists.Columns[8].HeaderText = "Product Price";
				productLists.Columns[9].HeaderText = "Total Price";
				productLists.Columns[10].HeaderText = "Product Image";
				productLists.Columns[11].Visible = false;


				da.Dispose();
				cmd.Dispose();
				conn.Clone();
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
		private void showProduct_Click(object sender, EventArgs e)
		{
			showProdutsToGrid();
			updateProduct.Enabled = true;
		}

		private string getGridIndexValue()
		{
			try
			{
				int id = productLists.CurrentCell.RowIndex;
				return productLists[0, id].Value.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Please show the products");
			}
			return "";
		}
		private void deleteProductFromDB(string id)
		{
			try
			{
				conn.Open();
				string qry = "update product set is_enable='false' where id='" + id + "'";
				MySqlCommand cmd = new MySqlCommand(qry, conn);
				int result = cmd.ExecuteNonQuery();
				if (result != 0)
					MessageBox.Show("Product Removed");
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
					conn.Close();
			}
		}
		private void deleteProduct_Click(object sender, EventArgs e)
		{
			string id = getGridIndexValue();
			deleteProductFromDB(id);
			showProdutsToGrid();
			//MessageBox.Show(id);
		}

		private void updateProduct_Click(object sender, EventArgs e)
		{
			frmPrdId = getGridIndexValue();
			status = "update";
			addProduct ap = new Mobiles.addProduct();
			ap.Show();
			//Size sz = new Size(100, 100);
			//SwathiClass sc = new SwathiClass();
			//Image img = sc.convertImage(Image img, new Size(100, 100));
			//MessageBox.Show(sz.Height.ToString());
		}

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu mn = new Mobiles.Menu();
            mn.Show();
        }
    }
}
