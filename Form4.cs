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
    public partial class Form4 : Form
    {
        public Form4()
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
            string query = "SELECT * FROM Flower";
            DataSet ds = F.ShowFunction(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 Form4 = new Form3();
            Form4.Show();

            this.Hide();
        }
             //CLEAR
        private void button2_Click(object sender, EventArgs e)
        {
            tbxid.Clear();
            tbxname.Clear();
            cbxStatus.ResetText();
            tbxPrice.Clear();
        }
            //DELETE
        private void button3_Click(object sender, EventArgs e)
        {
            {
                const string message = "Are you sure that you want to Delete this Flower?";
                const string caption = "Delete Confirmation";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Functions F = new Functions();
                    if (string.IsNullOrWhiteSpace(tbxid.Text))
                    {
                        MessageBox.Show("Please Select a Flower!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        try
                        {
                            string query = "DELETE FROM Flower WHERE FlowerID = '" + tbxid.Text + "'";
                            F.DeleteFunction(query);

                            MessageBox.Show("Flower Details Successfully Deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            RefreshData();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Delete Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                        tbxid.Clear();
                        tbxname.Clear();
                        cbxStatus.ResetText();
                        tbxPrice.Clear();

                    }

                }
            }
        }                
              //INSERT              
        private void btnout_Click(object sender, EventArgs e)
        {            if (string.IsNullOrWhiteSpace(tbxid.Text) || string.IsNullOrWhiteSpace(tbxname.Text) || string.IsNullOrWhiteSpace(cbxStatus.Text) || string.IsNullOrEmpty(tbxPrice.Text))
            {
                MessageBox.Show("Please Fill All the Details..!","Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
            else
            {
                string query = "INSERT INTO Flower (FlowerID, FlowerName, [Status], Price) VALUES ('" + tbxid.Text + "','" + tbxname.Text + "','" + cbxStatus.SelectedItem.ToString() + "','" + tbxPrice.Text + "')";
                
                Functions F  = new Functions();
                try
                {
                    F.InsertFunction(query);
                    MessageBox.Show("Flower Added Successfully..!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception)
                {
                    MessageBox.Show("Flower Adding Failed..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                RefreshData();

                tbxid.Clear();
                tbxname.Clear();
                cbxStatus.ResetText();
                tbxPrice.Clear();
              }
        }

        private void tbxid_TextChanged(object sender, EventArgs e)
        {

        }
              //UPDATE
        private void button1_Click(object sender, EventArgs e)
        {
            Functions F = new Functions();

            if (string.IsNullOrWhiteSpace(tbxid.Text))
            {
                MessageBox.Show("Please Select a Flower!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    string query = "UPDATE Flower SET FlowerName='" + tbxid + "','" + tbxname + "','" + cbxStatus.SelectedItem.ToString() + "','" + tbxPrice + "' WHERE FlowerID='"+tbxid.Text+"'";

                    F.UpdateFunction(query);

                    MessageBox.Show("Flower Details Successfully Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    RefreshData();
                }

                catch (Exception)
                {
                    MessageBox.Show("Update Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                tbxid.Clear();
                tbxname.Clear();
                cbxStatus.ResetText();
                tbxPrice.Clear();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                tbxid.Text = dataGridView1.Rows[e.RowIndex].Cells["FlowerID"].FormattedValue.ToString();
                tbxname.Text = dataGridView1.Rows[e.RowIndex].Cells["FlowerName"].FormattedValue.ToString();
                tbxPrice.Text = dataGridView1.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString();
                cbxStatus.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells["Status"].FormattedValue.ToString();
            }
                    
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void tbxPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
