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
    public partial class AdminPanelFormList : Form
    {
        public AdminPanelFormList()
        {
            InitializeComponent();
        }

        private void btnAPFLProductStock_Click(object sender, EventArgs e)
        {
            ProductInformation ProductInfoview = new ProductInformation();
            this.Hide();
            ProductInfoview.Show();
        }

        private void btnAPFLMemberList_Click(object sender, EventArgs e)
        {
            MemberInformationLıst memberınfolistview = new MemberInformationLıst();
            this.Hide();
            memberınfolistview.Show();
        }

        private void btnAPFLExit_Click(object sender, EventArgs e)
        {
            AdminPanelForm adminpanefv = new AdminPanelForm();
            this.Hide();
            adminpanefv.Show();
        }

        private void btnAPFLReport_Click(object sender, EventArgs e)
        {
            Report productReport = new Report();
            this.Hide();
            productReport.Show();

        }
    }
}
