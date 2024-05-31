using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CashierApplication
{
    public partial class CashierForm : Form
    {
        public CashierForm()
        {
            InitializeComponent();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLoginAccounts logout = new frmLoginAccounts();
            this.Hide();
            logout.Show();
        }



        DiscountedItem DI;
        private void button1_Click(object sender, EventArgs e)
        {
            string name = ItemName.Text;
            double price = double.Parse(prices.Text);
            int quantity = Convert.ToInt32(quantityy.Text);
            double discount = double.Parse(discounts.Text);
            DI = new DiscountedItem (name, price, quantity, discount);
            double totalPrice = DI.getTotalPrice();
            TotalAmount.Text = totalPrice.ToString();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            double AmountPayment = double.Parse(PRecieved.Text);
            DI.setPayment(AmountPayment);
            double change = DI.getChange();
            changes.Text  =  change.ToString();
        }
    }
}
