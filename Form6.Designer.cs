namespace FlowerShopManagementSystem2
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCaddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCdelete = new System.Windows.Forms.Button();
            this.btnCclear = new System.Windows.Forms.Button();
            this.btnCupdate = new System.Windows.Forms.Button();
            this.btnCadd = new System.Windows.Forms.Button();
            this.tbxCphone = new System.Windows.Forms.TextBox();
            this.tbxCname = new System.Windows.Forms.TextBox();
            this.tbxCid = new System.Windows.Forms.TextBox();
            this.lblprice = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Location = new System.Drawing.Point(440, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 426);
            this.panel2.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(14, 11);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(391, 401);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.txtCaddress);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCdelete);
            this.panel1.Controls.Add(this.btnCclear);
            this.panel1.Controls.Add(this.btnCupdate);
            this.panel1.Controls.Add(this.btnCadd);
            this.panel1.Controls.Add(this.tbxCphone);
            this.panel1.Controls.Add(this.tbxCname);
            this.panel1.Controls.Add(this.tbxCid);
            this.panel1.Controls.Add(this.lblprice);
            this.panel1.Controls.Add(this.lblstatus);
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Controls.Add(this.lblid);
            this.panel1.Location = new System.Drawing.Point(12, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 446);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtCaddress
            // 
            this.txtCaddress.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaddress.Location = new System.Drawing.Point(45, 209);
            this.txtCaddress.Name = "txtCaddress";
            this.txtCaddress.Size = new System.Drawing.Size(328, 22);
            this.txtCaddress.TabIndex = 16;
            this.txtCaddress.TextChanged += new System.EventHandler(this.txtCaddress_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 14;
            // 
            // btnCdelete
            // 
            this.btnCdelete.BackColor = System.Drawing.Color.Crimson;
            this.btnCdelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCdelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCdelete.Location = new System.Drawing.Point(291, 394);
            this.btnCdelete.Name = "btnCdelete";
            this.btnCdelete.Size = new System.Drawing.Size(95, 32);
            this.btnCdelete.TabIndex = 12;
            this.btnCdelete.Text = "Delete";
            this.btnCdelete.UseVisualStyleBackColor = false;
            this.btnCdelete.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCclear
            // 
            this.btnCclear.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCclear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCclear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCclear.Location = new System.Drawing.Point(27, 394);
            this.btnCclear.Name = "btnCclear";
            this.btnCclear.Size = new System.Drawing.Size(95, 32);
            this.btnCclear.TabIndex = 11;
            this.btnCclear.Text = "Clear";
            this.btnCclear.UseVisualStyleBackColor = false;
            this.btnCclear.Click += new System.EventHandler(this.btnCclear_Click);
            // 
            // btnCupdate
            // 
            this.btnCupdate.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCupdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCupdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCupdate.Location = new System.Drawing.Point(217, 356);
            this.btnCupdate.Name = "btnCupdate";
            this.btnCupdate.Size = new System.Drawing.Size(95, 32);
            this.btnCupdate.TabIndex = 10;
            this.btnCupdate.Text = "Update";
            this.btnCupdate.UseVisualStyleBackColor = false;
            this.btnCupdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCadd
            // 
            this.btnCadd.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnCadd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadd.Location = new System.Drawing.Point(105, 356);
            this.btnCadd.Name = "btnCadd";
            this.btnCadd.Size = new System.Drawing.Size(95, 32);
            this.btnCadd.TabIndex = 9;
            this.btnCadd.Text = "Add";
            this.btnCadd.UseVisualStyleBackColor = false;
            this.btnCadd.Click += new System.EventHandler(this.btnout_Click);
            // 
            // tbxCphone
            // 
            this.tbxCphone.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCphone.Location = new System.Drawing.Point(45, 288);
            this.tbxCphone.Name = "tbxCphone";
            this.tbxCphone.Size = new System.Drawing.Size(328, 22);
            this.tbxCphone.TabIndex = 7;
            this.tbxCphone.TextChanged += new System.EventHandler(this.tbxCphone_TextChanged);
            // 
            // tbxCname
            // 
            this.tbxCname.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCname.Location = new System.Drawing.Point(45, 139);
            this.tbxCname.Name = "tbxCname";
            this.tbxCname.Size = new System.Drawing.Size(328, 22);
            this.tbxCname.TabIndex = 5;
            this.tbxCname.TextChanged += new System.EventHandler(this.tbxname_TextChanged);
            // 
            // tbxCid
            // 
            this.tbxCid.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCid.Location = new System.Drawing.Point(45, 64);
            this.tbxCid.Name = "tbxCid";
            this.tbxCid.Size = new System.Drawing.Size(328, 22);
            this.tbxCid.TabIndex = 4;
            this.tbxCid.TextChanged += new System.EventHandler(this.tbxid_TextChanged);
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(31, 266);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(50, 19);
            this.lblprice.TabIndex = 3;
            this.lblprice.Text = "Phone:";
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.Location = new System.Drawing.Point(31, 187);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(63, 19);
            this.lblstatus.TabIndex = 2;
            this.lblstatus.Text = "Address:";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(31, 117);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(112, 19);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Customer Name:";
            this.lblname.Click += new System.EventHandler(this.lblname_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(31, 42);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(91, 19);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "Customer ID:";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Salmon;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Maroon;
            this.button4.Location = new System.Drawing.Point(784, 433);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 25);
            this.button4.TabIndex = 18;
            this.button4.Text = "HOME";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(871, 459);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCdelete;
        private System.Windows.Forms.Button btnCclear;
        private System.Windows.Forms.Button btnCupdate;
        private System.Windows.Forms.Button btnCadd;
        private System.Windows.Forms.TextBox tbxCphone;
        private System.Windows.Forms.TextBox tbxCname;
        private System.Windows.Forms.TextBox tbxCid;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtCaddress;
    }
}