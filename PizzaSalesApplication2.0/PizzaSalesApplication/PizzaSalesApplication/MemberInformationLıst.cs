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
    public partial class MemberInformationLıst : Form
    {
        public MemberInformationLıst()
        {
            InitializeComponent();
        }

        private void btnAPFLMembInfoExit_Click(object sender, EventArgs e)
        {
            AdminPanelFormList adminformlt = new AdminPanelFormList();
            this.Hide();
            adminformlt.Show();
        }

        private void btnAPFLViewMembInfo_Click(object sender, EventArgs e)
        {

            MySqlConnection Mconnect = new MySqlConnection();
            Mconnect.ConnectionString = "Server=localhost;Database=projectpizza;Uid=root;Pwd=''";
            MySqlCommand Mcommand = new MySqlCommand();
            MySqlDataAdapter adapter;
            DataTable dt;
            dt = new DataTable();
            Mconnect.Open();
            adapter = new MySqlDataAdapter("select * from registerformt", Mconnect);
            adapter.Fill(dt);
            dgAPFLViewMemb.DataSource = dt;
            Mconnect.Close();


        }
    }
}
