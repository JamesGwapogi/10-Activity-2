using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplication
{
    public partial class frmLoginAccounts : Form
    {
        public frmLoginAccounts()
        {
            InitializeComponent();
        }
        private Cashier cash;


        private void Logins_Click(object sender, EventArgs e)
        {
            cash = new Cashier("James Carrascal", "Finance", userName.Text, passWord.Text);

            if (cash.validateLogin(userName.Text, passWord.Text))
            {
                MessageBox.Show("Welcome " + cash.getFullName() + " of " + cash.getDepartment(), "Success", MessageBoxButtons.OK);
                CashierForm cashier = new CashierForm();
                this.Hide();
                cashier.Show();

            }
            else
            {
                MessageBox.Show("Login Failed. Pls Try Again ", "Failed", MessageBoxButtons.OK);
            }
        }
    }
}
