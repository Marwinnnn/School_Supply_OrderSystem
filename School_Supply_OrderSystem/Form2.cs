using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace School_Supply_OrderSystem
{
    public partial class Form2 : Form
    {
        double payment = 0;
        public Form2(string _name, string _supply,
            double _uprice,
            double _quantity,
            double _disount,
            double _total)

        {
            InitializeComponent();
            lblClerk.Text = _name.ToString();
            lblsupply.Text = _supply.ToString();
            lblUnitprice.Text = _uprice.ToString();
            lblQuantity.Text = _quantity.ToString();
            lblDiscount.Text = _disount.ToString();
            lblOrderTotal.Text = _total.ToString();

        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            if (cmbPlan.SelectedIndex == 0)
            {

                double total = double.Parse(lblOrderTotal.Text);
                payment = total;
                MessageBox.Show($"You will pay {payment} full", "Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else if (cmbPlan.SelectedIndex == 1)
            {
                
                double total = double.Parse(lblOrderTotal.Text);
                payment = total / 2;
                MessageBox.Show($"You will pay {payment} twice", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (cmbPlan.SelectedIndex == 2)
            {
                double total = double.Parse(lblOrderTotal.Text);
                payment = total / 12;
                MessageBox.Show($"You will pay {payment} per month", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }
    }
}
