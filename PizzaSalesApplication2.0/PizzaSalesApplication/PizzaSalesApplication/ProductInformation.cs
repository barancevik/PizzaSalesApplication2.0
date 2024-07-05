using MySql.Data.MySqlClient;
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
    public partial class ProductInformation : Form
    {
        public ProductInformation()
        {
            InitializeComponent();
        }

        private void btnAPFLPInfoExit_Click(object sender, EventArgs e)
        {
            AdminPanelFormList adminformlt = new AdminPanelFormList();
            this.Hide();
            adminformlt.Show();
        }

        private void btnAPFLViewShow_Click(object sender, EventArgs e)
        {
            MySqlConnection Mconnect = new MySqlConnection();
            Mconnect.ConnectionString = "Server=localhost;Database=projectpizza;Uid=root;Pwd=''";
            MySqlCommand Mcommand = new MySqlCommand();
            MySqlDataAdapter adapter;
            DataTable dt;
            dt = new DataTable();
            Mconnect.Open();
            adapter = new MySqlDataAdapter("select * from pizzabox", Mconnect);
            adapter.Fill(dt);
            dgAPFLProductInfStck.DataSource = dt;
            Mconnect.Close();

        }
    }
}
