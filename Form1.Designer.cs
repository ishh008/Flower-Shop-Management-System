namespace FlowerShopManagementSystem2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblwelcome = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.tbxuser = new System.Windows.Forms.TextBox();
            this.tbxpass = new System.Windows.Forms.TextBox();
            this.cbxshowpass = new System.Windows.Forms.CheckBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblwelcome.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelcome.ForeColor = System.Drawing.Color.Maroon;
            this.lblwelcome.Location = new System.Drawing.Point(132, 9);
            this.lblwelcome.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(421, 74);
            this.lblwelcome.TabIndex = 0;
            this.lblwelcome.Text = "WELCOME TO FLOWER SHOP \r\nMANAGEMENT SYSTEM";
            this.lblwelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblwelcome.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.Location = new System.Drawing.Point(58, 102);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(96, 22);
            this.lbluser.TabIndex = 2;
            this.lbluser.Text = "UserName";
            this.lbluser.Click += new System.EventHandler(this.lbluser_Click);
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.Location = new System.Drawing.Point(58, 189);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(90, 22);
            this.lblpass.TabIndex = 3;
            this.lblpass.Text = "Password";
            this.lblpass.Click += new System.EventHandler(this.lblpass_Click);
            // 
            // tbxuser
            // 
            this.tbxuser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxuser.Location = new System.Drawing.Point(56, 139);
            this.tbxuser.Name = "tbxuser";
            this.tbxuser.Size = new System.Drawing.Size(550, 26);
            this.tbxuser.TabIndex = 4;
            this.tbxuser.TextChanged += new System.EventHandler(this.tbxuser_TextChanged);
            // 
            // tbxpass
            // 
            this.tbxpass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxpass.Location = new System.Drawing.Point(56, 225);
            this.tbxpass.Name = "tbxpass";
            this.tbxpass.Size = new System.Drawing.Size(550, 26);
            this.tbxpass.TabIndex = 5;
            this.tbxpass.UseSystemPasswordChar = true;
            this.tbxpass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // cbxshowpass
            // 
            this.cbxshowpass.AutoSize = true;
            this.cbxshowpass.BackColor = System.Drawing.Color.Transparent;
            this.cbxshowpass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxshowpass.Location = new System.Drawing.Point(476, 257);
            this.cbxshowpass.Name = "cbxshowpass";
            this.cbxshowpass.Size = new System.Drawing.Size(130, 23);
            this.cbxshowpass.TabIndex = 6;
            this.cbxshowpass.Text = "Show Password";
            this.cbxshowpass.UseVisualStyleBackColor = false;
            this.cbxshowpass.CheckedChanged += new System.EventHandler(this.cbxpass_CheckedChanged);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnclear.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnclear.Location = new System.Drawing.Point(197, 299);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(107, 38);
            this.btnclear.TabIndex = 7;
            this.btnclear.Text = "CLEAR";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Crimson;
            this.btnlogin.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnlogin.Location = new System.Drawing.Point(354, 299);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(107, 38);
            this.btnlogin.TabIndex = 8;
            this.btnlogin.Text = "LOGIN";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(658, 359);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.cbxshowpass);
            this.Controls.Add(this.tbxpass);
            this.Controls.Add(this.tbxuser);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.lblwelcome);
            this.Font = new System.Drawing.Font("Engravers MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblwelcome;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.TextBox tbxuser;
        private System.Windows.Forms.TextBox tbxpass;
        private System.Windows.Forms.CheckBox cbxshowpass;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnlogin;
    }
}

