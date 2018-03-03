using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
//using System.Data.SqlClient;

namespace Mobiles
{
	public partial class login : Form
	{
		MySqlConnection conn;
        public static string userType = "";

        string connString = "server=localhost;persistsecurityinfo=False;user id=root;database=swathi_mobiles;allowuservariables=True";
		public login()
		{
			InitializeComponent();
		}

		private void login_Load(object sender, EventArgs e)
		{
			textBox3.Select();
            //textBox2.UseSystemPasswordChar = true;
        }

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			
		}
		
		private void textBox2_TextChanged(object sender, EventArgs e)
		{
            textBox2.UseSystemPasswordChar = true;
        }

		private void textBox1_Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
		}

		private void textBox2_Click(object sender, EventArgs e)
		{
			textBox2.UseSystemPasswordChar = true;
			textBox2.Text = "";
		}

		private void label2_Click(object sender, EventArgs e)
		{
			try
			{
				conn = new MySqlConnection(connString);
				string username = textBox1.Text;
				string password = textBox2.Text;
				conn.Open();
                /*string query = "insert into login(username,password) values('" + username + "','" + password + "')";
				SqlCommand cmd = new SqlCommand(query, conn);
				int result = cmd.ExecuteNonQuery();
				string text = textBox1.Text + textBox2.Text;
				MessageBox.Show(result.ToString());*/
                userType = "";
				string query = "select type from login where username='" + username + "' and password='"+password+"'";
				MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader red = cmd.ExecuteReader();
                while (red.Read())
                    userType = red[0].ToString();
				//int cnt = int.Parse(cmd.ExecuteScalar().ToString());
				if (userType != "")
				{
					Menu mn = new Mobiles.Menu();
					mn.Show();
					this.Hide();
				}
				else
				{
					MessageBox.Show("Invalid Credentials.",	"Credentials", MessageBoxButtons.OK,MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				textBox1.Text = "username";
				textBox2.Text = "password";
				conn.Close();
			}
		}
	}
}
