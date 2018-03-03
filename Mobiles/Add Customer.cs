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
	public partial class AddCustomer : Form
	{
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private PictureBox pictureBox1;
		private Button button1;
		private TextBox fname;
		private TextBox lname;
		private TextBox pnumber;
		private TextBox pncode;
		private ComboBox village;
		private ComboBox area;
		private Label perror;
		private Button button2;
		private Button button3;
		private Label label1;
		MySqlConnection conn = new MySqlConnection("server=localhost;persistsecurityinfo=False;user id=root;database=swathi_mobiles;allowuservariables=True");
		SwathiClass sc = new SwathiClass();
		public AddCustomer()
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.fname = new System.Windows.Forms.TextBox();
			this.lname = new System.Windows.Forms.TextBox();
			this.pnumber = new System.Windows.Forms.TextBox();
			this.pncode = new System.Windows.Forms.TextBox();
			this.village = new System.Windows.Forms.ComboBox();
			this.area = new System.Windows.Forms.ComboBox();
			this.perror = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Font = new System.Drawing.Font("VAGRounded BT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.label1.Location = new System.Drawing.Point(166, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(268, 42);
			this.label1.TabIndex = 1;
			this.label1.Text = "ADD CUSTOMER";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Lime;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label2.Font = new System.Drawing.Font("Swis721 Hv BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.label2.Location = new System.Drawing.Point(57, 124);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(117, 24);
			this.label2.TabIndex = 2;
			this.label2.Text = "First Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Lime;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label3.Font = new System.Drawing.Font("Swis721 Hv BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.label3.Location = new System.Drawing.Point(60, 190);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(114, 24);
			this.label3.TabIndex = 3;
			this.label3.Text = "Last Name";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Lime;
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label4.Font = new System.Drawing.Font("Swis721 Hv BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.label4.Location = new System.Drawing.Point(98, 255);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(76, 24);
			this.label4.TabIndex = 4;
			this.label4.Text = "Village";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Lime;
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label5.Font = new System.Drawing.Font("Swis721 Hv BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.label5.Location = new System.Drawing.Point(117, 323);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 24);
			this.label5.TabIndex = 5;
			this.label5.Text = "Area";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Lime;
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label6.Font = new System.Drawing.Font("Swis721 Hv BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.label6.Location = new System.Drawing.Point(15, 395);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(159, 24);
			this.label6.TabIndex = 6;
			this.label6.Text = "Mobile Number";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Lime;
			this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label7.Font = new System.Drawing.Font("Swis721 Hv BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.label7.Location = new System.Drawing.Point(76, 466);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(98, 24);
			this.label7.TabIndex = 7;
			this.label7.Text = "Pin Code";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = global::Mobiles.Properties.Resources.atomix_user31;
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.Location = new System.Drawing.Point(433, 128);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(150, 150);
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button1.Font = new System.Drawing.Font("Hobo Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.button1.Location = new System.Drawing.Point(460, 292);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(101, 39);
			this.button1.TabIndex = 9;
			this.button1.Text = "Browse";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// fname
			// 
			this.fname.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fname.Location = new System.Drawing.Point(227, 124);
			this.fname.Name = "fname";
			this.fname.Size = new System.Drawing.Size(168, 27);
			this.fname.TabIndex = 10;
			// 
			// lname
			// 
			this.lname.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lname.Location = new System.Drawing.Point(227, 188);
			this.lname.Name = "lname";
			this.lname.Size = new System.Drawing.Size(168, 27);
			this.lname.TabIndex = 11;
			// 
			// pnumber
			// 
			this.pnumber.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pnumber.Location = new System.Drawing.Point(227, 394);
			this.pnumber.Name = "pnumber";
			this.pnumber.Size = new System.Drawing.Size(168, 27);
			this.pnumber.TabIndex = 12;
			this.pnumber.TextChanged += new System.EventHandler(this.PhoneNumberChanged);
			this.pnumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneNumber);
			// 
			// pncode
			// 
			this.pncode.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pncode.Location = new System.Drawing.Point(227, 465);
			this.pncode.Name = "pncode";
			this.pncode.Size = new System.Drawing.Size(168, 27);
			this.pncode.TabIndex = 13;
			this.pncode.TextChanged += new System.EventHandler(this.pinCode);
			this.pncode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pinCode);
			// 
			// village
			// 
			this.village.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.village.FormattingEnabled = true;
			this.village.Location = new System.Drawing.Point(227, 254);
			this.village.Name = "village";
			this.village.Size = new System.Drawing.Size(168, 26);
			this.village.TabIndex = 14;
			this.village.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
			// 
			// area
			// 
			this.area.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.area.FormattingEnabled = true;
			this.area.Location = new System.Drawing.Point(227, 322);
			this.area.Name = "area";
			this.area.Size = new System.Drawing.Size(168, 26);
			this.area.TabIndex = 15;
			this.area.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
			// 
			// perror
			// 
			this.perror.AutoSize = true;
			this.perror.Location = new System.Drawing.Point(224, 424);
			this.perror.Name = "perror";
			this.perror.Size = new System.Drawing.Size(0, 13);
			this.perror.TabIndex = 16;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.Font = new System.Drawing.Font("Clarendon BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.button2.Location = new System.Drawing.Point(106, 551);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(134, 38);
			this.button2.TabIndex = 17;
			this.button2.Text = "Create";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button3.Font = new System.Drawing.Font("Clarendon BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.button3.Location = new System.Drawing.Point(344, 551);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(134, 38);
			this.button3.TabIndex = 18;
			this.button3.Text = "Cancel";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// AddCustomer
			// 
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(594, 621);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.perror);
			this.Controls.Add(this.area);
			this.Controls.Add(this.village);
			this.Controls.Add(this.pncode);
			this.Controls.Add(this.pnumber);
			this.Controls.Add(this.lname);
			this.Controls.Add(this.fname);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "AddCustomer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add Customer";
			this.Load += new System.EventHandler(this.AddCustomer_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private void AddCustomer_Load(object sender, EventArgs e)
		{
			if (conn.State == ConnectionState.Open)
				conn.Close();
			string text;
			bool test = File.Exists(@"C:\SwathiMobiles\Village.txt");
			if (test)
			{
				StreamReader file = new StreamReader(@"C:\SwathiMobiles\Village.txt");
				while ((text = file.ReadLine()) != null)
				{
					village.Items.Add(text);
				}
				file.Close();

			}
			test = File.Exists(@"C:\SwathiMobiles\Area.txt");
			if (test)
			{
				StreamReader file = new StreamReader(@"C:\SwathiMobiles\Area.txt");
				while ((text = file.ReadLine()) != null)
				{
					area.Items.Add(text);
				}
				file.Close();

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
			int destWidth = (int)(150);
			int destHeight = (int)(150);

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
		private void button1_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "Jpg (*.jpeg)|*.jpeg|jpg (*.jpg)|*.jpg|Png (*.png)|*.png";
			ofd.Title = "Select Customer Image";
			ofd.InitialDirectory = @"C:\";
			if (DialogResult.OK == ofd.ShowDialog())
			{
				string filename = ofd.FileName;
				Image img = Image.FromFile(filename);
				img = ScaleByPercent(img, (int)30);
				pictureBox1.Image = img;
			}
		}

		private void KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}

		private void phoneNumber(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}

			// only allow one decimal point
			/*if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
			{
				e.Handled = true;
			}*/
		}

		private void PhoneNumberChanged(object sender, EventArgs e)
		{
			perror.Text = "";
			if (pnumber.Text.Length > 10)
			{
				perror.Text = "Phone Number Less then 10 digit";
				perror.ForeColor = Color.Red;
			}
		}

		private void pinCode(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void pinCode(object sender, EventArgs e)
		{
		}
		public string getCustId()
		{
			string cusid = "";
			try
			{

				conn.Open();
				string query = "select cusid from customer_number";
				MySqlCommand cmd = new MySqlCommand(query, conn);
				MySqlDataReader mdr = cmd.ExecuteReader();
				while (mdr.Read())
					cusid = "SMCUS" + mdr["cusid"].ToString();
				cmd.Dispose();
				mdr.Dispose();
				query = "update customer_number set cusid = cusid+1";
				cmd = new MySqlCommand(query, conn);
				cmd.ExecuteNonQuery();
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
			return cusid;

			
			/*Random rnd = new Random();
			int day = rnd.Next(10, 30);
			int mnt = rnd.Next(31,60);
			int yer = rnd.Next(61, 99);
			return day.ToString()+mnt.ToString()+yer.ToString();*/
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				string firstname = fname.Text;
				string lastname = lname.Text;
				string vlg = village.SelectedItem.ToString();
				string ar = area.SelectedItem.ToString();
				string mn = pnumber.Text;
				string pn = pncode.Text;
				string cust_id = getCustId();
				Image img = pictureBox1.Image;
				img = sc.convertImage(img, new Size(100, 100));
				byte[] prdimage;
				ImageConverter converter = new ImageConverter();
				prdimage = (byte[])converter.ConvertTo(img, typeof(byte[]));
				conn.Open();
				string query = "insert into customer(cust_id,first_name,last_name,village,area,mobile_num,pincode,create_at,cust_img) values('" + cust_id + "','" + firstname + "','" + lastname + "','" + vlg + "','" + ar + "','" + mn + "','" + pn + "',@createdate,@customerImage)";
				MySqlCommand cmd = new MySqlCommand(query, conn);
				DateTimePicker dtp = new DateTimePicker();
				cmd.Parameters.Add("@createdate", MySqlDbType.Date).Value = dtp.Value.Date;
				cmd.Parameters.Add("@customerImage", MySqlDbType.LongBlob).Value = prdimage;
				int result = cmd.ExecuteNonQuery();
				if (result != 0)
					MessageBox.Show("Customer Added");
				//MessageBox.Show(result.ToString());
				conn.Close();
				//if(result != 0)

			}
			catch (NullReferenceException)
			{
				MessageBox.Show("Please Fill all Fields");
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

		private void button3_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
