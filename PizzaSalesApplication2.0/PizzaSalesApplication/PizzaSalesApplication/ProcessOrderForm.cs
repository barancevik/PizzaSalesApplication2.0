using MySql.Data.MySqlClient;
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
    public partial class ProcessOrderForm : Form
    {
        public ProcessOrderForm()
        {
            InitializeComponent();
        }

        double SizeValue;
        double PizzaValue;
        double Piece;

        private void ProcessOrderForm_Load(object sender, EventArgs e)
        {

            List<Size> sizes = new List<Size>()
            {
                new Size{Name="Small",Price=1},
                new Size{Name="Medium",Price=1.25},
                new Size{Name="Big",Price=1.5},
                new Size{Name="SuperBig",Price=2}

            };
            CbSizes.DataSource = sizes;
            CbSizes.ValueMember = "Price";
            CbSizes.DisplayMember= "Name";

            List<Pizza> pizzas = new List<Pizza>()
            {
                new Pizza{Name="Mexicano Pizza",Price=12},
                new Pizza{Name="Pizza With Cheddar Sauce",Price=14},
                new Pizza{Name="Extravaganzza",Price=13},
                new Pizza{Name="Callypso",Price=15},
                new Pizza{Name="Plenty Of Meat",Price=14},
                new Pizza{Name="Pastrami & Sausage",Price=16},
                new Pizza{Name="Margarita",Price=14},
                new Pizza{Name="Loves Mushrooms",Price=18},
                new Pizza{Name="loves Sausage",Price=18}

            };

            lstPizzas.DataSource = pizzas;
            lstPizzas.ValueMember = "Price";
            lstPizzas.DisplayMember = "Name";


        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            try
            {
                Piece = Convert.ToDouble(txtPieces.Text);
                txtAmount.Text = Convert.ToString((SizeValue * PizzaValue) * Piece);


            }
            catch (Exception)
            {

                MessageBox.Show("Please enter the quantity"); 
            }


        }

        private void CbSizes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                SizeValue = (Double)CbSizes.SelectedValue;
            }
            catch (Exception)
            {

                MessageBox.Show("Please enter the size");
            }
        }


        List<PizzaBasket> pizzas = new List<PizzaBasket>();
        double totalamount = 0.0;
        private void btnAddToBasket_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Clear();
            string ingredients = "";

            foreach (CheckBox item in gbIngredients.Controls)
            {

                if (item.Checked)
                {
                    ingredients += item.Text + ",";
                }
            }

            string doughs = "";
            foreach (RadioButton item in gbDough.Controls)
            {
                if (radioButton1.Checked)
                {
                    doughs = radioButton1.Text;
                }
                else
                {
                    doughs = radioButton2.Text;
                }
            }

            try
            {
                PizzaBasket P = new PizzaBasket();
                P.Size = CbSizes.Text;
                P.Kind = lstPizzas.Text;
                P.TotalPrice = Convert.ToDouble(txtAmount.Text);
                P.Ingredient = ingredients;
                P.Dough = doughs;
                P.piece = Convert.ToDouble(txtPieces.Text);
                P.SizeValue = SizeValue;
                P.PizzaValue = PizzaValue;
                P.DoughValue = doughs;
                pizzas.Add(P);
            }
            catch (Exception)
            {

                MessageBox.Show("Please enter the requested values");
            }

            foreach (PizzaBasket item in pizzas)
            {
                lstOrder.Items.Add(item.Size + " " + item.Kind + " " + item.DoughValue + " " + item.Ingredient + " " + item.piece + " x " + "(" + item.SizeValue + " x " + item.PizzaValue + ")" + "=" + item.TotalPrice.ToString());
                totalamount += item.TotalPrice;
            }

            lblTotal.Text = totalamount.ToString() + "Pound";
        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text=="")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                MySqlConnection Mconnect = new MySqlConnection();
                Mconnect.ConnectionString = "Server = localhost; Database = projectpizza; Uid = root; Pwd = ''";
                Mconnect.Open();
                MySqlCommand Mcommand = new MySqlCommand();
                Mcommand.CommandText = ("update pizzabox set Stock= Stock - '" + (txtPieces.Text) + "' where Kinds='" + (lstPizzas.Text) + "'");
                Mcommand.Connection = Mconnect;
                Mcommand.ExecuteNonQuery();
                Mcommand.Dispose();
                Mconnect.Close();
                this.Hide();
                string total = Convert.ToString(lblTotal.Text);
                MessageBox.Show("Total " + "" + txtPieces.Text + "" + "pieces" + "" + lblTotal.Text + "" + "of your order");
                txtPieces.Clear();
                txtAmount.Clear();
                lblTotal.ResetText();
                MainPage F1 = new MainPage();
                F1.Show();

            }


        }

 

        private void lstPizzas_MouseClick_1(object sender, MouseEventArgs e)
        {
            try
            {
                PizzaValue = (double)lstPizzas.SelectedValue;

            }
            catch (Exception)
            {

                MessageBox.Show("Please Select Pizza Type");
            }
        }
    }
}
