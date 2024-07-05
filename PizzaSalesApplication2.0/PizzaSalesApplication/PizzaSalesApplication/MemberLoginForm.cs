using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace PizzaSalesApplication
{
    public partial class MemberLoginForm : Form
    {
        MySqlConnection Mconnect;
        MySqlCommand Mcommand;
        MySqlDataReader dr;

        public MemberLoginForm()
        {
            InitializeComponent();
            Mconnect = new MySqlConnection("Server=localhost;Database=projectpizza;user=root;Pwd='';SslMode=none"); 
        }

        private void btnMLFlogin_Click(object sender, EventArgs e)
        {

            string Semail = txtMLFemail.Text;
            string Spassword = txtMLFpassword.Text;
            Mcommand = new MySqlCommand();
            Mconnect.Open();
            Mcommand.Connection = Mconnect;
            Mcommand.CommandText = "SELECT * from registerformt where Semail='" + txtMLFemail.Text + "' AND Spassword='" + txtMLFpassword.Text + "'";
            dr = Mcommand.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Login successful");
                ProcessOrderForm getOrder = new ProcessOrderForm();
                this.Hide();
                getOrder.Show();

            }
            else
            {
                MessageBox.Show("You Entered Incorrect Username or Password");
            }
            Mconnect.Close();

            




        }

        private void btnMLFExit_Click(object sender, EventArgs e)
        {
            MainPage gotomain2 = new MainPage();
            this.Hide();
            gotomain2.Show();
        }
    }
}
