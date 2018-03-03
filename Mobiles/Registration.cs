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
using System.Data.SqlClient;

namespace Mobiles
{
	public partial class Registration : Form
	{
		MySqlConnection conn;
		string connString = "server=localhost;persistsecurityinfo=False;user id=root;database=swathi_mobiles;allowuservariables=True";
		public Registration()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				conn = new MySqlConnection(connString);
				conn.Open();
				string username_text = username.Text;
				string password_text = password.Text;
				string conform_text = conformpassword.Text;
				if (typeCombo.Text == "--Select Type--")
				{
					MessageBox.Show("Please Select User Type");
					return;
				}
				else if (username_text == "")
				{
					MessageBox.Show("Please Enter Username");
					return;
				}
				string type = typeCombo.SelectedItem.ToString();
				int result = String.Compare(password_text, conform_text);
				if ((result == 0) && (password_text != "") && (conform_text != "") && (password_text != " ") && (conform_text != " "))
				{
					string cmdString = "insert into Login(username,password,type) values('"+username_text+"','"+password_text+"','"+type+"')";
					MySqlCommand cmd = new MySqlCommand(cmdString, conn);
					result = cmd.ExecuteNonQuery();
					MessageBox.Show("User Registered");
				}
				else
				{
					MessageBox.Show("Password Do not match without empty password or space");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				conn.Close();
			}
		}

		private void Registration_Load(object sender, EventArgs e)
		{
			password.UseSystemPasswordChar = true;
			conformpassword.UseSystemPasswordChar = true;
		}

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
