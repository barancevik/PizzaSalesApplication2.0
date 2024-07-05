using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PizzaSalesApplication
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRFregister_Click(object sender, EventArgs e)
        {
            if (txtNameSurname.Text=="" || txtAddress.Text=="" || txtPhoneNumber.Text=="" || txtEmail.Text==""|| txtRegisterPass.Text=="")
            {
                MessageBox.Show("Please fill in the empty files");
            }
            else
            {

                MySqlConnection Mconnect = new MySqlConnection();
                Mconnect.ConnectionString = "Server=localhost;Database=projectpizza;Uid=root;Pwd=''";
                Mconnect.Open();
                MySqlCommand Mcommand = new MySqlCommand();
                Mcommand.CommandText = "insert into registerformt(Snamesurname,Saddress,Sphonenumber,Semail,Spassword) values('" + txtNameSurname.Text + "', '" + txtAddress.Text + "', '" + txtPhoneNumber.Text + "', '" + txtEmail.Text + "', '" + txtRegisterPass.Text + "')";
                Mcommand.Connection = Mconnect;
                Mcommand.ExecuteNonQuery();
                Mcommand.Dispose();
                Mconnect.Clone();
                MessageBox.Show("Information saved");



                MainPage mainpagedis = new MainPage();
                this.Hide();
                mainpagedis.Show();
                
                


            }



        }

        private void btnRFExit_Click(object sender, EventArgs e)
        {
            MainPage gotomain = new MainPage();
            this.Hide();
            gotomain.Show();
        }
    }
}
