using System.Data;

namespace School_Supply_OrderSystem
{
    public partial class Form1 : Form
    {
        DataTable dtClerk = new DataTable();
        double discount = 0;
        double total = 0;
        double price = 0;
        double totalPrice = 0;
        public Form1()
        {
            InitializeComponent();
            dtClerk.Columns.Add("Clerk", typeof(string));
            dtClerk.Columns.Add("Supply", typeof(string));
            dtClerk.Columns.Add("Unit Price", typeof(double));
            dtClerk.Columns.Add("Quantity", typeof(double));
            dtClerk.Columns.Add("Discount", typeof(double));
            dtClerk.Columns.Add("Total", typeof(double));

            dvgTable.DataSource = dtClerk;
        }
        private void cmbsupply_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbsupply.SelectedIndex == 0)
            {
                txtPrice.Text = "950";
                price = double.Parse(txtPrice.Text);
            }
            else if (cmbsupply.SelectedIndex == 1)
            {
                txtPrice.Text = "1,250";
                price = double.Parse(txtPrice.Text);
            }
            else if (cmbsupply.SelectedIndex == 2)
            {
                txtPrice.Text = "680";
                price = double.Parse(txtPrice.Text);
            }
            else if (cmbsupply.SelectedIndex == 3)
            {
                txtPrice.Text = "300";
                price = double.Parse(txtPrice.Text);
            }
            else if (cmbsupply.SelectedIndex == 4)
            {
                txtPrice.Text = "750";
                price = double.Parse(txtPrice.Text);
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {

            if (chkDsicount.Checked)
            {
                double qty = double.Parse(txtQuantity.Text);
                total = qty * price;
                discount = total * .10;
                totalPrice = total - discount;
            }
            else
            {
                double qty = double.Parse(txtQuantity.Text);
                total = qty * price;
                totalPrice = total;
            }

            dtClerk.Rows.Add(txtName.Text,
                cmbsupply.Text, txtPrice.Text,
                txtQuantity.Text, discount.ToString(),
                totalPrice.ToString());

            discount = 0;
            totalPrice = 0;
            total = 0;


            txtName.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            cmbsupply.SelectedIndex = -1;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string name = dvgTable.SelectedRows[0].Cells["Clerk"].Value.ToString();
            string supply = dvgTable.SelectedRows[0].Cells["Supply"].Value.ToString();
            double uprice = double.Parse(dvgTable.SelectedRows[0].Cells["Unit price"].Value.ToString());
            double quantity = double.Parse(dvgTable.SelectedRows[0].Cells["Quantity"].Value.ToString());
            double discount = double.Parse(dvgTable.SelectedRows[0].Cells["Discount"].Value.ToString());
            double Total = double.Parse(dvgTable.SelectedRows[0].Cells["Total"].Value.ToString());

            Form2 form2 = new Form2(name, supply, uprice, quantity, discount, Total);

            form2.ShowDialog();
        }
    }
}
