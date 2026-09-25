using System;
using System.Windows.Forms;
using ItemNamespace;

namespace CashierApplication
{
    public partial class frmPurchaseDiscountedItem : Form
    {
        private Item? item;

        public bool IsLoggingOut { get; private set; } = false;

        public frmPurchaseDiscountedItem()
        {
            InitializeComponent();
            submitBtn.Click += submitBtn_Click;
            ComputeBtn.Click += ComputeBtn_Click;
        }
        private void logoutToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            IsLoggingOut = true;
            this.Close();
        }
        private void exitApplicationToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }

        private void submitBtn_Click(object? sender, EventArgs e)
        {
            try
            {
                double totalAmount =
                    Convert.ToDouble(totalAmountTxtbox.Text);

                double payment =
                    Convert.ToDouble(paymentTxtbox.Text);

                if (payment < totalAmount)
                {
                    MessageBox.Show(
                        "Payment is not enough.",
                        "Insufficient Payment",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                double change = payment - totalAmount;

                changeTxtbox.Text = change.ToString("0.00");
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Please enter a valid payment amount.",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void ComputeBtn_Click(object? sender, EventArgs e)
        {
            try
            {
                string itemName = itemTxtbox.Text;
                double price = Convert.ToDouble(priceTxtbox.Text);
                double discount = Convert.ToDouble(discountTxtbox.Text);
                int quantity = Convert.ToInt32(QuantityTxtbox.Text);

                item = new DiscountedItem(
                    itemName,
                    price,
                    quantity,
                    discount
                );

                double totalAmount = item.GetTotalAmount();

                totalAmountTxtbox.Text = totalAmount.ToString("0.00");
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Please enter valid values for price, discount, and quantity.",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        
    }
}