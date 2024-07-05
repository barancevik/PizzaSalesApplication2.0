using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaSalesApplication
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm Registerf = new RegisterForm();
            Registerf.Show();



        }

        private void btnMemberLogin_Click(object sender, EventArgs e)
        {
            MemberLoginForm memberlogin = new MemberLoginForm();
            this.Hide();
            memberlogin.Show();


        }

        private void btnAdminPanel_Click(object sender, EventArgs e)
        {
            AdminPanelForm adminpanellogin = new AdminPanelForm();
            this.Hide();
            adminpanellogin.Show();
        }

       
    }
}
