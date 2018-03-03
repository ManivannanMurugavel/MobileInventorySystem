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
using System.IO;

namespace Mobiles
{
	public partial class OrderPage : Form
	{
		SwathiClass sc = new SwathiClass();
		MySqlConnection conn = new MySqlConnection("server=localhost;persistsecurityinfo=False;user id=root;database=swathi_mobiles;allowuservariables=True");
		static DataTable dt = new DataTable();
        string[,] myGridData;

        public OrderPage()
		{
			InitializeComponent();
			prdType.Enabled = false;
		}
		private void OrderPage_Load(object sender, EventArgs e)
		{
            dt = new DataTable();
            dt.Columns.Add("Product Type");
			dt.Columns.Add("Brand Name");
			dt.Columns.Add("Model Name");
			dt.Columns.Add("Quantity");
			dt.Columns.Add("Product Price");
			dt.Columns.Add("Total Price");
			this.ControlBox = false;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
            cusId.Text = "Customer ID";
            //cusId.ForeColor = Color.Gray;
            frname.Text = "Fr Name";
            frname.ForeColor = Color.Gray;
            lsname.Text = "Ls Name";
            lsname.ForeColor = Color.Gray;
            mobnum.Text = "Ph Number";
            mobnum.ForeColor = Color.Gray;
            prdId.Text = "SMPRD";
            cusId.Text = "SMCUS";
            //cusId.Text = "Customer ID";

        }

		private void cusSearchBtn_Click(object sender, EventArgs e)
		{
			try
			{
				string customer_id = cusId.Text;
				if (customer_id.Length != 10)
				{
					MessageBox.Show("Please Enter 10 Digit Customer ID");
					return;
				}
				byte[] CusImage = null;
				conn.Open();
				string qry = "select * from customer where cust_id='" + customer_id + "'";
				MySqlCommand cmd = new MySqlCommand(qry, conn);
				MySqlDataReader dr = cmd.ExecuteReader();
				if (dr.HasRows == false)
				{
					MessageBox.Show("No Data Found");
					conn.Close();
					cmd.Dispose();
					dr.Dispose();
					return;
				}
				while (dr.Read())
				{
					frname.Text = dr["first_name"].ToString();
					lsname.Text = dr["last_name"].ToString();
					village.Text = dr["village"].ToString();
					area.Text = dr["area"].ToString();
					mobnum.Text = dr["mobile_num"].ToString();
					pincode.Text = dr["pincode"].ToString();
					CusImage = (byte[])dr["cust_img"];
					MemoryStream ms = new MemoryStream(CusImage);
					ms.Position = 0;
					Image img = Image.FromStream(ms);
					img = sc.convertImage(img, new Size(100, 100));
					cusimage.Image = img;
					//MessageBox.Show(dr["brand_name"].ToString());
				}
				conn.Close();
				cmd.Dispose();
				dr.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void mouseHoverPrdType(object sender, EventArgs e)
		{
			//toolTip1.Show("Show", prdType);
		}

		private void PageMouseMove(object sender, MouseEventArgs e)
		{
			
		}

		private void Qty_KeyPressed(object sender, KeyPressEventArgs e)
		{
			
		}

		private void QtyValChanged(object sender, EventArgs e)
		{
			int qty = Convert.ToInt32(numericUpDown1.Value);
			int echprd = int.Parse(eachprice.Text);
			ttlprice.Text = (qty * echprd).ToString();
			//MessageBox.Show(numericUpDown1.Value.ToString());
		}

		private void prdSearchBtn_Click(object sender, EventArgs e)
		{
			try
			{
                numericUpDown1.Value = 1;
                int echprice;
				string product_id = prdId.Text;
				if (product_id.Length != 10)
				{
					MessageBox.Show("Please Enter 10 Digit Product ID");
					return;
				}
				byte[] PrdImage = null;
				conn.Open();
				string qry = "select * from product where product_id='" + product_id + "' and is_enable='true'";
				MySqlCommand cmd = new MySqlCommand(qry, conn);
				MySqlDataReader dr = cmd.ExecuteReader();
				if (dr.HasRows == false)
				{
					MessageBox.Show("No Data Found");
                    prdType.Text = "";
                    brndName.Text = "";
                    mdlName.Text = "";
                    eachprice.Text = "";
                    ttlprice.Text = "";
                    numericUpDown1.Value = 1;
					conn.Close();
					cmd.Dispose();
					dr.Dispose();
					return;
				}
                while (dr.Read())
				{
					prdType.Text = dr["product_type"].ToString();
					mdlName.Text = dr["model_name"].ToString();
					brndName.Text = dr["brand_name"].ToString();
					//echprice = Convert.ToInt32(dr["each_price"].ToString());
					//ttlprice.Text = (1 * echprice).ToString();
					//eachprice.Text = echprice.ToString();
					PrdImage = (byte[])dr["prd_image"];
					MemoryStream ms = new MemoryStream(PrdImage);
					ms.Position = 0;
					Image img = Image.FromStream(ms);
					img = sc.convertImage(img, new Size(100, 100));
					prdimage.Image = img;
					//MessageBox.Show(dr["brand_name"].ToString());
				}
                dr.Close();
                qry = "select product_price from product_price where product_id='" + product_id + "'";
                cmd = new MySqlCommand(qry, conn);
                MySqlDataReader amtReader = cmd.ExecuteReader();
                echprice = 0;
                if (amtReader.HasRows == false)
                {
                    MessageBox.Show("Please Insert Product Price");
                    prdType.Text = "";
                    brndName.Text = "";
                    mdlName.Text = "";
                    eachprice.Text = "";
                    ttlprice.Text = "";
                    numericUpDown1.Value = 1;
                    conn.Close();
                    cmd.Dispose();
                    amtReader.Close();
                    return;
                }
                while (amtReader.Read())
                {
                    echprice = Convert.ToInt32(amtReader[0].ToString());
                    ttlprice.Text = (1 * echprice).ToString();
                    eachprice.Text = echprice.ToString();
                }
                conn.Close();
				cmd.Dispose();
                amtReader.Close();

            }
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{

			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				DataRow dr = dt.NewRow();
				dr["Product Type"] = prdType.Text;
				dr["Brand Name"] = brndName.Text;
				dr["Model Name"] = mdlName.Text;
				dr["Quantity"] = numericUpDown1.Value;
				dr["Product Price"] = eachprice.Text;
				dr["Total Price"] = ttlprice.Text;
				dt.Rows.Add(dr);
				orderslist.DataSource = dt;
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void Print_Document(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
            int totalX = 0 , totalY = 0;
            int gridRowCnt = orderslist.Rows.Count;
            myGridData = new string[orderslist.Rows.Count, 6];
            for (int irow = 0; irow < gridRowCnt - 1; irow++)
            {
                myGridData[irow, 0] = orderslist.Rows[irow].Cells[0].Value.ToString();
                myGridData[irow, 1] = orderslist.Rows[irow].Cells[1].Value.ToString();
                myGridData[irow, 2] = orderslist.Rows[irow].Cells[2].Value.ToString();
                myGridData[irow, 3] = orderslist.Rows[irow].Cells[3].Value.ToString();
                myGridData[irow, 4] = orderslist.Rows[irow].Cells[4].Value.ToString();
                myGridData[irow, 5] = orderslist.Rows[irow].Cells[5].Value.ToString();

            }
            DateTime dateTime = DateTime.UtcNow.Date;
            //e.Graphics.DrawString(richTextBox1.Text, richTextBox1.Font, Brushes.Black, 100, 20);
            e.Graphics.DrawString(dateTime.ToString("dd/MM/yyyy"), new Font("Times New Roman", 25), new SolidBrush(Color.Black), 600, 10);
            e.Graphics.DrawString("SWATHI MOBILES", new Font("Algerian", 30,FontStyle.Bold), new SolidBrush(Color.Black), new RectangleF(240, 80, printDocument1.DefaultPageSettings.PrintableArea.Width, printDocument1.DefaultPageSettings.PrintableArea.Height));
            e.Graphics.DrawString("Sozharajan", new Font("Modern No", 20), new SolidBrush(Color.Black), 40, 120);
            e.Graphics.DrawString("7639288278", new Font("Modern No", 20), new SolidBrush(Color.Black), 680, 120);
            e.Graphics.DrawString("T.Palur    Main Road,", new Font("Times New Roman", 18), new SolidBrush(Color.Black), 300, 150);
            e.Graphics.DrawString(" Udaiyarpalayam (Tk),", new Font("Times New Roman", 18), new SolidBrush(Color.Black), 290, 190);
            e.Graphics.DrawString(" Ariyalur (DT),", new Font("Times New Roman", 18), new SolidBrush(Color.Black), 320, 230);
            e.Graphics.DrawString(" PIN : 612904.", new Font("Times New Roman", 18), new SolidBrush(Color.Black), 320, 270);
            e.Graphics.DrawString("Customer Name", new Font("Times New Roman", 20), new SolidBrush(Color.Black), 150, 350);
            e.Graphics.DrawString(frname.Text+" "+lsname.Text, new Font("Times New Roman", 20), new SolidBrush(Color.Black), 140, 390);
            e.Graphics.DrawString("Phone Number", new Font("Times New Roman", 20), new SolidBrush(Color.Black), 500, 350);
            e.Graphics.DrawString(mobnum.Text, new Font("Times New Roman", 20), new SolidBrush(Color.Black), 500, 390);
            //e.Graphics.DrawString("Name: Manivannan", new Font("Times New Roman", 25), new SolidBrush(Color.Black), 280, 350);
            //e.Graphics.DrawString("9874563210", new Font("Times New Roman", 20), new SolidBrush(Color.Black), 320, 400);
            Pen blackPen = new Pen(Color.Black, 1);
            Rectangle rect = new Rectangle(80, 340, 700, 100);
            e.Graphics.DrawRectangle(blackPen, rect);
            e.Graphics.DrawLine(new Pen(Color.Black, 2),70,480,800,480);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 430, 340, 430, 440);
            e.Graphics.DrawString("No", new Font("Times New Roman", 20), new SolidBrush(Color.Black), 70, 485);
            e.Graphics.DrawString("Product Name", new Font("Times New Roman", 20), new SolidBrush(Color.Black), 180, 485);
            e.Graphics.DrawString("Qty", new Font("Times New Roman", 20), new SolidBrush(Color.Black), 430, 485);
            e.Graphics.DrawString("Price", new Font("Times New Roman", 20), new SolidBrush(Color.Black), 540, 485);
            e.Graphics.DrawString("Total Price", new Font("Times New Roman", 20), new SolidBrush(Color.Black), 660, 485);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 70, 520, 800, 520);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 70, 480, 70, 520);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 110, 480, 110, 520);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 410, 480, 410, 520);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 510, 480, 510, 520);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 650, 480, 650, 520);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 800, 480, 800, 520);
            double totalAmount = 0;
            for (int i=1;i< gridRowCnt; i++)
            {
                //MessageBox.Show(myGridData[i-1, 1]);
                e.Graphics.DrawLine(new Pen(Color.Black, 2), 70, (520 + (i * 60)), 800, (520 + (i * 60)));
                e.Graphics.DrawString(i.ToString(), new Font("Times New Roman", 20), new SolidBrush(Color.Black), 70, (475 + (i * 60)));
                e.Graphics.DrawLine(new Pen(Color.Black, 2), 70, (460 + (i * 60)), 70, (520 + (i * 60)));
                e.Graphics.DrawString(myGridData[i-1,1]+ myGridData[i-1,2], new Font("Times New Roman", 20), new SolidBrush(Color.Black), 110, (475 + (i * 60)));
                e.Graphics.DrawLine(new Pen(Color.Black, 2), 110, (460 + (i * 60)), 110, (520 + (i * 60)));
                e.Graphics.DrawString(myGridData[i - 1, 3], new Font("Times New Roman", 20), new SolidBrush(Color.Black), 430, (475 + (i * 60)));
                e.Graphics.DrawLine(new Pen(Color.Black, 2), 410, (460 + (i * 60)), 410, (520 + (i * 60)));
                e.Graphics.DrawString(myGridData[i - 1, 4], new Font("Times New Roman", 20), new SolidBrush(Color.Black), 540, (475 + (i * 60)));
                e.Graphics.DrawLine(new Pen(Color.Black, 2), 510, (460 + (i * 60)), 510, (520 + (i * 60)));
                e.Graphics.DrawString(myGridData[i - 1, 5], new Font("Times New Roman", 20), new SolidBrush(Color.Black), 660, (475 + (i * 60)));
                totalX = 660;
                totalY = (475 + (i * 60));
                totalAmount = totalAmount + Convert.ToDouble(myGridData[i - 1, 5]);
                e.Graphics.DrawLine(new Pen(Color.Black, 2), 650, (460 + (i * 60)), 650, (520 + (i * 60)));
                e.Graphics.DrawLine(new Pen(Color.Black, 2), 800, (460 + (i * 60)), 800, (520 + (i * 60)));
            }
            //MessageBox.Show(totalAmount.ToString());
            e.Graphics.DrawString("Total Amount", new Font("Times New Roman", 20), new SolidBrush(Color.Black), totalX-200, (totalY+60));
            e.Graphics.DrawString(totalAmount.ToString(), new Font("Times New Roman", 20), new SolidBrush(Color.Black), totalX, (totalY + 60));
            e.Graphics.DrawString("For", new Font("Times New Roman", 20), new SolidBrush(Color.Black), 650, 980);
            e.Graphics.DrawString("Swathi Mobiles", new Font("Times New Roman", 20), new SolidBrush(Color.Black), 580, 1020);
        }

        private void PrintOrder_Click(object sender, EventArgs e)
		{
			try
			{
                if ((frname.Text != "Fr Name") && (lsname.Text != "Ls Name") && (mobnum.Text != "Ph Number"))
                {
                    printPreviewDialog1.Document = printDocument1;
                    printPreviewDialog1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please Fill Customer Name and Phone Number");
                }
     
            }
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void MouseEnter(object sender, EventArgs e)
        {
            //cusId.Text = "";
        }

        private void cusId_MouseLeave(object sender, EventArgs e)
        {
            //cusId.Text = "Customer ID";
        }

        private void cusId_Enter(object sender, EventArgs e)
        {
            if (cusId.Text == "Customer ID")
            {
                cusId.Text = "";
                cusId.ForeColor = Color.Black;
            }
        }

        private void cusId_Leave(object sender, EventArgs e)
        {
            if (cusId.Text == "")
            {
                cusId.Text = "Customer ID";
                cusId.ForeColor = Color.Gray;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu mn = new Mobiles.Menu();
            mn.Show();
        }

        private void frname_Enter(object sender, EventArgs e)
        {
            if (frname.Text == "Fr Name")
            {
                frname.Text = "";
                frname.ForeColor = Color.Black;
            }
        }

        private void frname_Leave(object sender, EventArgs e)
        {
            if (frname.Text == "")
            {
                frname.Text = "Fr Name";
                frname.ForeColor = Color.Gray;
            }
        }

        private void lsname_Enter(object sender, EventArgs e)
        {
            if (lsname.Text == "Ls Name")
            {
                lsname.Text = "";
                lsname.ForeColor = Color.Black;
            }
        }

        private void lsname_Leave(object sender, EventArgs e)
        {
            if (lsname.Text == "")
            {
                lsname.Text = "Ls Name";
                lsname.ForeColor = Color.Gray;
            }
        }

        private void mobnum_Enter(object sender, EventArgs e)
        {
            if (mobnum.Text == "Ph Number")
            {
                mobnum.Text = "";
                mobnum.ForeColor = Color.Black;
            }
        }

        private void mobnum_Leave(object sender, EventArgs e)
        {
            if (mobnum.Text == "")
            {
                mobnum.Text = "Ph Number";
                mobnum.ForeColor = Color.Gray;
            }
        }
    }
}
