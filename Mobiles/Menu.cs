using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobiles
{
	public partial class Menu : Form
	{
		public Menu()
		{
			InitializeComponent();
		}

		private void Menu_Load(object sender, EventArgs e)
		{

		}

		private void prdDetails_Click(object sender, EventArgs e)
		{
			ProductDetails pd = new ProductDetails();
			pd.Show();
			this.Hide();
		}

		private void custDetails_Click(object sender, EventArgs e)
		{
			this.Hide();
			CustomerDetails cd = new CustomerDetails();
			cd.Show();
		}

        private void ordDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderPage op = new OrderPage();
            op.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login lg = new login();
            lg.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (login.userType == "Admin")
            {
                Registration rs = new Registration();
                rs.Show();
            }
            else
            {
                MessageBox.Show("Your Not a Admin User");
            }
        }
    }
}
