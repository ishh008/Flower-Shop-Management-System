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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbluser_Click(object sender, EventArgs e)
        {

        }

        private void cbxpass_CheckedChanged(object sender, EventArgs e)
        {

            if (cbxshowpass.Checked == true)
            {
                tbxpass.UseSystemPasswordChar = false;
            }
            else
            {

                tbxpass.UseSystemPasswordChar = true;
            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblpass_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbxuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string UserName = tbxuser.Text;
            string Password = tbxpass.Text;

            if (UserName == "Admin" && Password == "Admin@123")
            {
                MessageBox.Show("Login Success !", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form3 Form1 = new Form3();
                Form1.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Error !", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
 

            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            tbxuser.Clear();
            tbxpass.Clear();
        }
    }
 }

