using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using UserAccountNamespace;

namespace CashierApplication
{
    public partial class frmLoginAccount : Form
    {
        private Cashier cashier = new Cashier("Shariejun Balagosa", "Computer Science", "shariepogi", "sharie123789");
        public frmLoginAccount()
        {
            InitializeComponent();
        }

        private void logInBtn_Click(object? sender, EventArgs e)
        {
            string uName = userNameTxtbox.Text;
            string password = passTxtbox.Text;
            if (cashier.validateLogin(uName, password))
            {
                MessageBox.Show(
                    $"Welcome {cashier.getFullName()} of {cashier.getDepartment()}",
                    "Login Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                userNameTxtbox.Clear();
                passTxtbox.Clear();

                this.Hide();

                frmPurchaseDiscountedItem purchaseForm = new frmPurchaseDiscountedItem();
                purchaseForm.FormClosed += PurchaseForm_FormClosed;
                purchaseForm.Show();
            }
            else
            {
                MessageBox.Show(
                    "Invalid username or password.",
                    "Login Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }
        private void PurchaseForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            if (sender is frmPurchaseDiscountedItem purchaseForm && purchaseForm.IsLoggingOut)
            {
                this.Show();
            }
            else
            {
                Application.Exit();
            }
        }

        private void showPassCheckbox_CheckedChanged(object? sender, EventArgs e)
        {
            passTxtbox.UseSystemPasswordChar = !showPassCheckbox.Checked;
        }
    }
}
