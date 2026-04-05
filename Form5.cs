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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        
        private void Form5_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            LoadFlowers();
            LoadOrders();
        }

        // Load customers 
        private void LoadCustomers()
        {
            try
            {
                Functions F = new Functions();

                string query = "SELECT CustomerID, CustomerName, CONVERT(VARCHAR(50), CustomerID) + ' - ' + CustomerName AS DisplayName FROM Customer";

                DataSet ds = F.ShowFunction(query);

                cbxCid.DataSource = ds.Tables[0];
                cbxCid.DisplayMember = "DisplayName";
                cbxCid.ValueMember = "CustomerID";
                cbxCid.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Load flowers with ID + Name display
        private void LoadFlowers()
        {
            try
            {
                Functions F = new Functions();
                
                string query = "SELECT FlowerID, FlowerName, Price, FlowerID + ' - ' + FlowerName AS DisplayName FROM Flower WHERE [Status]='Available'";
                
                DataSet ds = F.ShowFunction(query);

                cbxFid.DataSource = ds.Tables[0];
                cbxFid.DisplayMember = "DisplayName"; 
                cbxFid.ValueMember = "FlowerID";      
                cbxFid.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading flowers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Load orders into DataGridView
        private void LoadOrders()
        {
            try
            {
                Functions F = new Functions();
                
                string query = @"SELECT o.OrderID, o.CustomerID, c.CustomerName, o.FlowerID, f.FlowerName, o.TotalAmount 
                                FROM [Order] o 
                                INNER JOIN Customer c ON o.CustomerID = c.CustomerID 
                                INNER JOIN Flower f ON o.FlowerID = f.FlowerID 
                                ORDER BY o.OrderID DESC";
                
                DataSet ds = F.ShowFunction(query);
                
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dataGridView3.DataSource = ds.Tables[0];
                }
                else
                {
                    // Create empty table with column headers
                    dataGridView3.DataSource = ds.Tables[0];
                    MessageBox.Show("No orders found. Add your first order!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading orders: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Update price when flower is selected
        private void cbxFid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxFid.SelectedIndex != -1)
            {
                try
                {
                    DataRowView row = (DataRowView)cbxFid.SelectedItem;
                    decimal price = Convert.ToDecimal(row["Price"]);
                    lblPrice.Text = price.ToString("0.00");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error getting price: " + ex.Message);
                    lblPrice.Text = "0.00";
                }
            }
            else
            {
                lblPrice.Text = "100";
            }
        }

        // Pay button
        private void btnpay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxOid.Text) || cbxCid.SelectedIndex == -1 || cbxFid.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all details!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Functions F = new Functions();
                string orderID = tbxOid.Text;
                string customerID = cbxCid.SelectedValue.ToString();
                string flowerID = cbxFid.SelectedValue.ToString();
                DataRowView row = (DataRowView)cbxFid.SelectedItem;
                decimal price = Convert.ToDecimal(row["Price"]);
                
                //Change "Order" to match your table name
                string query = "INSERT INTO [Order] (OrderID, CustomerID, FlowerID, TotalAmount) VALUES ('" 
                    + orderID + "', '" 
                    + customerID + "', '" 
                    + flowerID + "', " 
                    + price + ")";
                
                F.InsertFunction(query);
                MessageBox.Show("Payment processed successfully! Order saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadOrders();
                LoadFlowers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Payment failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Home button
        private void button4_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        // DataGridView click
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView3.Rows[e.RowIndex];
                tbxOid.Text = row.Cells["OrderID"].Value.ToString();
                
                // Optional: Also load customer and flower when clicking row
                // cbxCid.SelectedValue = row.Cells["CustomerID"].Value;
                // cbxFid.SelectedValue = row.Cells["FlowerID"].Value;
            }
        }

        // Clear fields
        private void ClearFields()
        {
            tbxOid.Clear();
            cbxCid.SelectedIndex = -1;
            cbxFid.SelectedIndex = -1;
            lblPrice.Text = "100";
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void btnAdd_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void NUDquantity_ValueChanged(object sender, EventArgs e) { }
        private void tbxOid_TextChanged(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void cbxCid_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}
   
