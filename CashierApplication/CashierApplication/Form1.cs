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
    public partial class Form1 : Form
    {

        String[] items = { "Wireless Mouse", "Wireless Keyboard", "Gaming Mouse", "Gaming Keyboard", "Monitor", "Headset", "RTX 4090 Ti" };
        double[] itemPrices = {315.99, 529.99, 1029.99, 1449.99, 7199.99, 949.99,179999};

        public Form1()
        {
            InitializeComponent();
            txt_price.ReadOnly = true;
            item_combobox.Items.AddRange(items);
            lbl_totalprice.Text = ("");
            lbl_changefinal.Text = ("");
        }

        double item;
        double discount;
        double price;
        double totalprice;

        private void Bttn_compute_Click(object sender, EventArgs e)
        {
            price = (Convert.ToDouble(txt_price.Text) * Convert.ToDouble(txt_quantity.Text));
            discount = (Convert.ToDouble(txt_discount.Text) * 0.01);
            item = (price * discount);
            totalprice = (price - (price * discount));
            lbl_totalprice.Text = totalprice.ToString("F2");
        }

        double payment;
        double change;

        private void Bttn_calculate_Click(object sender, EventArgs e)
        {
            payment = Convert.ToDouble(txt_payment.Text);
            change = payment - totalprice;
            lbl_changefinal.Text = change.ToString();
        }

        private void item_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = item_combobox.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < itemPrices.Length)
            {
                txt_price.Text = itemPrices[selectedIndex].ToString();
            }
        }
    }
}
