using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaSalesApplication
{
    public partial class AdminPanelForm : Form
    {
        public AdminPanelForm()
        {
            InitializeComponent();
        }

        private void btnAPlogin_Click(object sender, EventArgs e)
        {
            if (txtAPMail.Text=="" || txtAPPassword.Text=="")
            {
                MessageBox.Show("Please fill in the empty file");
            }
            else if (txtAPMail.Text=="admin" && txtAPPassword.Text=="123")
            {

                //sql

                MessageBox.Show("Management Provided");
                AdminPanelFormList adminformlist = new AdminPanelFormList();
                this.Hide();
                adminformlist.Show();

            }
            else
            {
                MessageBox.Show("Wrong Information!");
            }


        }

        private void btnAPExit_Click(object sender, EventArgs e)
        {
            MainPage gotomain3 = new MainPage();
            this.Hide();
            gotomain3.Show();
        }

        
    }
}
