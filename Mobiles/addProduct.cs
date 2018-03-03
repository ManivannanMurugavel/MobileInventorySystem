using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Mobiles
{
	public partial class addProduct : Form
	{
		SwathiClass sc = new SwathiClass();
		string productStatus = "";
		string pubprdid;
		MySqlConnection conn = new MySqlConnection("server=localhost;persistsecurityinfo=False;user id=root;database=swathi_mobiles;allowuservariables=True");
		public addProduct()
		{
			InitializeComponent();
		}

		private void addProduct_Load(object sender, EventArgs e)
		{
			this.ControlBox = false;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			update.Visible = false;
			button1.Visible = false;
			prdID.Enabled = false;
			productID.Enabled = false;
			productStatus = "new";
			prdType.Text = "--Select--";
			brndName.Text = "--Select--";
			string text;
			bool test = File.Exists(@"C:\SwathiMobiles\ProductType.txt");
			if (test)
			{
				StreamReader file = new StreamReader(@"C:\SwathiMobiles\ProductType.txt");
				while ((text = file.ReadLine()) != null)
				{
					prdType.Items.Add(text);
				}
				file.Close();
				
			}
			if (ProductDetails.status == "update")
			{
				setUpdateProduct(ProductDetails.frmPrdId);
				update.Visible = true;
			}
			else
			{
				pubprdid = getProductId();
				productID.Text = pubprdid;
				button1.Visible = true;
			}
		}
		public void setUpdateProduct(string id)
		{
			//prdType.Text = "";
			//brndName.Text = "";
			groupBox1.Visible = false;
			byte[] PrdImage = null;
			conn.Open();
			string qry = "select * from product where id=" + Convert.ToInt32(id);
			MySqlCommand cmd = new MySqlCommand(qry, conn);
			MySqlDataReader dr = cmd.ExecuteReader();
			while (dr.Read())
			{
				productID.Text = dr["product_id"].ToString();
				mdlName.Text = dr["model_name"].ToString();
				prdType.SelectedItem = dr["product_type"];
				brndName.SelectedItem = dr["brand_name"];
				qty.Value = Convert.ToDecimal(dr["no_qty"]);
				prdprice.Text = dr["each_price"].ToString();
				ttlprice.Text = dr["total_price"].ToString();
				PrdImage = (byte[])dr["prd_image"];
				MemoryStream ms = new MemoryStream(PrdImage);
				ms.Position = 0;
				Image img = Image.FromStream(ms);
				img = sc.convertImage(img, new Size(200, 200));
				productPic.Image = img;
				//MessageBox.Show(dr["brand_name"].ToString());
			}
			conn.Close();
			cmd.Dispose();
			dr.Dispose();
		}
		public string getProductId()
		{
			string prdid = "";
			try
			{
				
				conn.Open();
				string query = "select prdid from product_number";
				MySqlCommand cmd = new MySqlCommand(query, conn);
				MySqlDataReader mdr = cmd.ExecuteReader();
				while (mdr.Read())
					prdid = "SMPRD"+mdr["prdid"].ToString();
				cmd.Dispose();
				mdr.Dispose();
				/*query = "update product_number set prdid = prdid+1";
				cmd = new MySqlCommand(query, conn);
				cmd.ExecuteNonQuery();*/
				conn.Close();
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
			}
			return prdid;
		}
		public string checkProductID(string id)
		{
			conn.Open();
			string qry = "select count(product_id) from product where product_id='" + id + "'";
			MySqlCommand cmd = new MySqlCommand(qry, conn);
			int result = int.Parse(cmd.ExecuteScalar().ToString());
			conn.Close();
			cmd.Dispose();
			if (result != 0)
				return "yes";
			return "no";
		}
		private void button1_Click(object sender, EventArgs e)
		{
			string prdid = productID.Text;
			try
			{
				string status = "no";
				if (productStatus == "exist")
				{
					status = checkProductID(prdid);
				}
				if (status == "no" && productStatus == "exist")
				{
					MessageBox.Show("Please Enter Correct Product ID");
					return;
				}
				string prdtype = prdType.SelectedItem.ToString();
				string brdname = brndName.SelectedItem.ToString();
				string mdlname = mdlName.Text;
				int qtyvalue = Convert.ToInt32(qty.Value);
				int echprice = Convert.ToInt32(prdprice.Text);
				int totalprice = Convert.ToInt32(ttlprice.Text);
				conn.Open();
				Image img = productPic.Image;
				img = sc.convertImage(img, new Size(100, 100));
				byte[] prdimage;
				ImageConverter converter = new ImageConverter();
				prdimage = (byte[])converter.ConvertTo(img, typeof(byte[]));
				string qry = "insert into product(product_id,brand_name,model_name,product_type,no_qty,each_price,total_price,created_at,prd_image,is_enable) values('" + prdid + "','" + brdname + "','" + mdlname + "','" + prdtype + "','" + qtyvalue + "','" + echprice + "','" + totalprice + "',@createdate,@productImage,'true')";
				DateTimePicker dtp = new DateTimePicker();
				MySqlCommand cmd = new MySqlCommand(qry, conn);
				cmd.Parameters.Add("@createdate", MySqlDbType.Date).Value = dtp.Value.Date;
				cmd.Parameters.Add("@productImage", MySqlDbType.LongBlob).Value = prdimage;
				int result = cmd.ExecuteNonQuery();
				if (result != 0)
				{
					MessageBox.Show("Product Added");
                    if (productStatus == "new")
                    {
                        qry = "insert into product_price(product_id,product_price) values('" + prdid + "'," + echprice + ")";
                        cmd.Dispose();
                        cmd = new MySqlCommand(qry, conn);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        qry = "update product_number set prdid = prdid+1";
                        cmd = new MySqlCommand(qry, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Price Added");
                    }
				}
				cmd.Dispose();
				conn.Close();
				//MessageBox.Show(result.ToString());
			}
			catch (NullReferenceException nre)
			{
				MessageBox.Show("Please Fill Product Type and Brand Name ");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				if (conn.State == ConnectionState.Open)
					conn.Close();
				brndName.Items.Clear();
				mdlName.Text = "";
				qty.Value = 0;
				prdprice.Text = "";
				ttlprice.Text = "";
				prdType.Text = "--Select--";
				brndName.Text = "--Select--";
				productPic.Location = new Point(350, 90);
				productPic.Width = 200;
				productPic.Height = 200;
				productPic.Image = Image.FromFile(@"C:\SwathiMobiles\noimage.png");
				extProduct.Checked = true;
				productID.Text = prdid;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
			//ProductDetails pd = new ProductDetails();
			//pd.Show();
			//MessageBox.Show(checkProductID(productID.Text));
			//MessageBox.Show(ProductDetails.frmPrdId);
			//MessageBox.Show(ProductDetails.status);
			//this.Enabled = false;
			//this.Hide();
			/*string line;
			bool test = File.Exists(@"C:\SwathiMobiles\test.txt");
			MessageBox.Show(test.ToString());
			StreamReader file = new StreamReader(@"C:\SwathiMobiles\Product.txt");
			while ((line = file.ReadLine()) != null)
			{
				MessageBox.Show(line);
			}
			file.Close();*/
		}

		private void button3_Click(object sender, EventArgs e)
		{
			try
			{
				productImageBrowse.Filter = "Jpg (*.jpeg)|*.jpeg|jpg (*.jpg)|*.jpg|Png (*.png)|*.png";
				productImageBrowse.InitialDirectory = @"C:\";
				productImageBrowse.Title = "Please Select your Product";
				if (DialogResult.OK == productImageBrowse.ShowDialog())
				{
					string filename;
					//productImageBrowse.ShowDialog();
					//productImageBrowse.Filter = "JPEG files|*.jpg|PNG files|*.png|GIF Files|*.gif|TIFF Files|*.tif|BMP Files|*.bmp";
					filename = productImageBrowse.FileName;
					Image img = Image.FromFile(filename);
					//productPic.Image = img;
					//img = ScaleByPercent(img, (int)30);
					img = sc.convertImage(img, new Size(200, 200));
					/*productPic.Location = new Point(400, 150);
					productPic.Width = 100;
					productPic.Height = 100;*/
					productPic.Image = img;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Please Select Correct Image", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		static Image ScaleByPercent(Image imgPhoto, int Percent)
		{
			float nPercent = ((float)Percent / 100);

			int sourceWidth = imgPhoto.Width;      //store original width of source image.
			int sourceHeight = imgPhoto.Height;    //store original height of source image.
			int sourceX = 0;        //x-axis of source image.
			int sourceY = 0;         //y-axis of source image.

			int destX = 0;          //x-axis of destination image.
			int destY = 0;          //y-axis of destination image.
									//Calcuate height and width of resized image.
			int destWidth = (int)(100);
			int destHeight = (int)(100);

			//Create a new bitmap object.
			Bitmap bmPhoto = new Bitmap(destWidth, destHeight,
									 PixelFormat.Format24bppRgb);
			//Set resolution of bitmap.
			bmPhoto.SetResolution(imgPhoto.HorizontalResolution,
									imgPhoto.VerticalResolution);
			//Create a graphics object and set quality of graphics.
			Graphics grPhoto = Graphics.FromImage(bmPhoto);
			grPhoto.InterpolationMode = InterpolationMode.HighQualityBicubic;

			//Draw image by using DrawImage() method of graphics class.
			grPhoto.DrawImage(imgPhoto,
				new Rectangle(destX, destY, destWidth, destHeight),
				new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight),
				GraphicsUnit.Pixel);

			grPhoto.Dispose();   //Dispose graphics object.
			return bmPhoto;
		}

		private void ProductTypeChanged(object sender, EventArgs e)
		{
			string path = @"C:\SwathiMobiles\";
			string txtFile = path+prdType.SelectedItem.ToString() + ".txt";
			string text;
			brndName.Items.Clear();
			bool test = File.Exists(txtFile);
			if (test)
			{
				StreamReader file = new StreamReader(txtFile);
				while ((text = file.ReadLine()) != null)
				{
					brndName.Items.Add(text);
				}
				file.Close();

			}
			//MessageBox.Show(brndName.ItemHeight.ToString());
		}

		private void productPriceKeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
			{
				e.Handled = true;
			}

			// only allow one decimal point
			if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
			{
				e.Handled = true;
			}
		}

		private void prdprice_TextChanged(object sender, EventArgs e)
		{
			decimal prdqty = qty.Value;
			if (prdprice.Text != "")
			{
				int price = int.Parse(prdprice.Text);
				ttlprice.Text = (prdqty * price).ToString();
			}
			
		}

		private void qtyChanged(object sender, EventArgs e)
		{
			decimal prdqty = qty.Value;
			if (prdprice.Text != "")
			{
				int price = int.Parse(prdprice.Text);
				ttlprice.Text = (prdqty * price).ToString();
			}
		}

		private void qtyKeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}

		private void brandNameKeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}

		private void productTypeKeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void newProduct_CheckedChanged(object sender, EventArgs e)
		{
			prdID.Enabled = false;
			productID.Enabled = false;
			productStatus = "new";
			productID.Text = pubprdid;
		}

		private void extProduct_CheckedChanged(object sender, EventArgs e)
		{
			prdID.Enabled = true;
			productID.Enabled = true;
			productStatus = "exist";
			productID.Text = "";
		}

		private void update_Click(object sender, EventArgs e)
		{
			try
			{
				conn.Open();
				string prdid = productID.Text;
				string prdtype = prdType.SelectedItem.ToString();
				string brdname = brndName.SelectedItem.ToString();
				string mdlname = mdlName.Text;
				int qtyvalue = Convert.ToInt32(qty.Value);
				int echprice = Convert.ToInt32(prdprice.Text);
				int totalprice = Convert.ToInt32(ttlprice.Text);
				Image img = productPic.Image;
				img = sc.convertImage(img, new Size(100, 100));
				byte[] prdimage;
				ImageConverter converter = new ImageConverter();
				prdimage = (byte[])converter.ConvertTo(img, typeof(byte[]));
				string qry = "update product set product_id=@prdid,product_type=@pdttype,brand_name=@brndname,model_name=@mdlname,updated_at=@uat,no_qty=@nqty,each_price=@eprc,total_price=@ttlprc,prd_image=@pimage where id=" + Convert.ToInt32(ProductDetails.frmPrdId);
				DateTimePicker dtp = new DateTimePicker();
				MySqlCommand cmd = new MySqlCommand(qry, conn);
				cmd.Parameters.Add("@prdid", MySqlDbType.String).Value = prdid;
				cmd.Parameters.Add("@pdttype", MySqlDbType.String).Value = prdtype;
				cmd.Parameters.Add("@brndname", MySqlDbType.String).Value = brdname;
				cmd.Parameters.Add("@mdlname", MySqlDbType.String).Value = mdlname;
				cmd.Parameters.Add("@uat", MySqlDbType.Date).Value = dtp.Value.Date;
				cmd.Parameters.Add("@nqty", MySqlDbType.Int32).Value = qtyvalue;
				cmd.Parameters.Add("@eprc", MySqlDbType.Float).Value = echprice;
				cmd.Parameters.Add("@ttlprc", MySqlDbType.Float).Value = totalprice;
				cmd.Parameters.Add("@pimage", MySqlDbType.LongBlob).Value = prdimage;
				int result = cmd.ExecuteNonQuery();
				if (result != 0)
					MessageBox.Show("Product Updated");
				//MessageBox.Show(ProductDetails.frmPrdId);
				conn.Close();
			}
			catch (NullReferenceException nre)
			{
				MessageBox.Show("Please Fill Product Type and Brand Name");
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
	}
}
