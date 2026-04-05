namespace FlowerShopManagementSystem2
{
    partial class Form5
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbxOid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxFid = new System.Windows.Forms.ComboBox();
            this.btnpay = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxCid = new System.Windows.Forms.ComboBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblCid = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.tbxOid);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbxFid);
            this.panel1.Controls.Add(this.btnpay);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbxCid);
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Controls.Add(this.lblCid);
            this.panel1.Location = new System.Drawing.Point(23, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 174);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tbxOid
            // 
            this.tbxOid.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxOid.Location = new System.Drawing.Point(152, 24);
            this.tbxOid.Name = "tbxOid";
            this.tbxOid.Size = new System.Drawing.Size(196, 22);
            this.tbxOid.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Flower ID:";
            // 
            // cbxFid
            // 
            this.cbxFid.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFid.FormattingEnabled = true;
            this.cbxFid.Location = new System.Drawing.Point(152, 105);
            this.cbxFid.Name = "cbxFid";
            this.cbxFid.Size = new System.Drawing.Size(196, 23);
            this.cbxFid.TabIndex = 16;
            // 
            // btnpay
            // 
            this.btnpay.BackColor = System.Drawing.Color.Maroon;
            this.btnpay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnpay.Location = new System.Drawing.Point(564, 101);
            this.btnpay.Name = "btnpay";
            this.btnpay.Size = new System.Drawing.Size(175, 35);
            this.btnpay.TabIndex = 14;
            this.btnpay.Text = "Pay";
            this.btnpay.UseVisualStyleBackColor = false;
            this.btnpay.Click += new System.EventHandler(this.btnpay_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(585, 66);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(33, 19);
            this.lblPrice.TabIndex = 13;
            this.lblPrice.Text = "100";
            this.lblPrice.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(523, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Price ($):";
            // 
            // cbxCid
            // 
            this.cbxCid.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCid.FormattingEnabled = true;
            this.cbxCid.Location = new System.Drawing.Point(152, 62);
            this.cbxCid.Name = "cbxCid";
            this.cbxCid.Size = new System.Drawing.Size(196, 23);
            this.cbxCid.TabIndex = 9;
            this.cbxCid.SelectedIndexChanged += new System.EventHandler(this.cbxCid_SelectedIndexChanged);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(73, 24);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(69, 19);
            this.lblname.TabIndex = 8;
            this.lblname.Text = "Order ID:";
            // 
            // lblCid
            // 
            this.lblCid.AutoSize = true;
            this.lblCid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCid.Location = new System.Drawing.Point(51, 66);
            this.lblCid.Name = "lblCid";
            this.lblCid.Size = new System.Drawing.Size(91, 19);
            this.lblCid.TabIndex = 1;
            this.lblCid.Text = "Customer ID:";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(23, 192);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(827, 232);
            this.dataGridView3.TabIndex = 2;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Salmon;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Maroon;
            this.button4.Location = new System.Drawing.Point(784, 430);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 28);
            this.button4.TabIndex = 17;
            this.button4.Text = "HOME";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(871, 459);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.panel1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnpay;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxCid;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblCid;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxFid;
        private System.Windows.Forms.TextBox tbxOid;
    }
}