using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerShopManagementSystem2
{
    public partial class Form6 : Form
    {
        int selectedCustomerID = 0;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        public void RefreshData()
        {
            Functions F = new Functions();
            string query = "SELECT * FROM Customer";
            DataSet ds = F.ShowFunction(query);
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (selectedCustomerID == 0)
            {
                MessageBox.Show("Please Select a Customer!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        string query = "UPDATE Customer SET " +
                       "CustomerName = '" + tbxCname.Text + "', " +
                       "Address = '" + txtCaddress.Text + "', " +
                       "Phone = '" + tbxCphone.Text + "' " +
                       "WHERE CustomerID = '" + selectedCustomerID + "'";

        Functions F = new Functions();

        try
            {
            F.UpdateFunction(query);
            MessageBox.Show("Customer Updated Successfully!", "Success");
            RefreshData();
            }
            catch
            {
                MessageBox.Show("Update Failed!", "Error");
            }

                tbxCid.Clear();
                tbxCname.Clear();
                txtCaddress.Clear();
                tbxCphone.Clear();
            }       

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 Form6 = new Form3();
            Form6.Show();

            this.Hide();
        }

        private void pbximport_Click(object sender, EventArgs e)
        {

        }

        private void tbxname_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnout_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxCid.Text) || string.IsNullOrWhiteSpace(tbxCname.Text) || string.IsNullOrWhiteSpace(txtCaddress.Text) || string.IsNullOrEmpty(tbxCphone.Text))
            {
                MessageBox.Show("Please Fill All the Details..!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string query = "INSERT INTO Customer (CustomerID, CustomerName, Address, Phone) VALUES ('" + tbxCid.Text + "','" + tbxCname.Text + "','" + txtCaddress.Text + "','" + tbxCphone.Text + "')";

                Functions F = new Functions();
                try
                {
                    F.InsertFunction(query);
                    MessageBox.Show("Customer Added Successfully..!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception)
                {
                    MessageBox.Show("Customer Adding Failed..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                RefreshData();

                tbxCid.Clear();
                tbxCname.Clear();
                txtCaddress.Clear();
                tbxCphone.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (selectedCustomerID == 0)
            {

                 MessageBox.Show("Please Select a Customer!", "Warning!");
                 return;
            }

            string query = "DELETE FROM Customer WHERE CustomerID = '" + selectedCustomerID + "'";
            Functions F = new Functions();

            try
            {

                F.DeleteFunction(query);
                MessageBox.Show("Customer Deleted Successfully!");
                RefreshData();
            }
            catch
            {
                MessageBox.Show("Delete Failed!");
            }

                selectedCustomerID = 0;
                tbxCid.Clear();
                tbxCname.Clear();
                txtCaddress.Clear();
                tbxCphone.Clear();
        }        
        
        private void tbxid_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblname_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                selectedCustomerID = Convert.ToInt32(row.Cells["CustomerID"].Value);

                dataGridView2.CurrentRow.Selected = true;
                tbxCid.Text = dataGridView2.Rows[e.RowIndex].Cells["CustomerID"].FormattedValue.ToString();
                tbxCname.Text = dataGridView2.Rows[e.RowIndex].Cells["CustomerName"].FormattedValue.ToString();
                tbxCphone.Text = dataGridView2.Rows[e.RowIndex].Cells["Phone"].FormattedValue.ToString();
                txtCaddress.Text = dataGridView2.Rows[e.RowIndex].Cells["Address"].FormattedValue.ToString();

            }
        }

        private void txtCaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCclear_Click(object sender, EventArgs e)
        {
            selectedCustomerID = 0;
            tbxCid.Clear();
            txtCaddress.Clear();
            tbxCname.Clear();
            tbxCphone.Clear();
        }

        private void tbxCphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
