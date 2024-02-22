namespace Assignment3
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
            this.txbFname = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.txbLname = new System.Windows.Forms.TextBox();
            this.lblPnum = new System.Windows.Forms.Label();
            this.txbPnum = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txbOutput = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txbFname
            // 
            this.txbFname.Location = new System.Drawing.Point(217, 72);
            this.txbFname.Name = "txbFname";
            this.txbFname.Size = new System.Drawing.Size(197, 26);
            this.txbFname.TabIndex = 0;
            this.txbFname.TextChanged += new System.EventHandler(this.txbFname_TextChanged);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(87, 34);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(74, 20);
            this.title.TabIndex = 1;
            this.title.Text = "Uppgift 3";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Location = new System.Drawing.Point(91, 72);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(77, 20);
            this.lblFname.TabIndex = 2;
            this.lblFname.Text = "Förnamn:";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Location = new System.Drawing.Point(91, 103);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(88, 20);
            this.lblLname.TabIndex = 4;
            this.lblLname.Text = "Efternamn:";
            // 
            // txbLname
            // 
            this.txbLname.Location = new System.Drawing.Point(217, 103);
            this.txbLname.Name = "txbLname";
            this.txbLname.Size = new System.Drawing.Size(197, 26);
            this.txbLname.TabIndex = 3;
            this.txbLname.TextChanged += new System.EventHandler(this.txbLname_TextChanged);
            // 
            // lblPnum
            // 
            this.lblPnum.AutoSize = true;
            this.lblPnum.Location = new System.Drawing.Point(91, 135);
            this.lblPnum.Name = "lblPnum";
            this.lblPnum.Size = new System.Drawing.Size(121, 20);
            this.lblPnum.TabIndex = 6;
            this.lblPnum.Text = "Personnummer:";
            // 
            // txbPnum
            // 
            this.txbPnum.Location = new System.Drawing.Point(217, 135);
            this.txbPnum.Name = "txbPnum";
            this.txbPnum.Size = new System.Drawing.Size(197, 26);
            this.txbPnum.TabIndex = 5;
            this.txbPnum.TextChanged += new System.EventHandler(this.txbPnum_TextChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(360, 217);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(184, 33);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Registrera person";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(523, 290);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(184, 33);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Avsluta program";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txbOutput
            // 
            this.txbOutput.AcceptsReturn = true;
            this.txbOutput.Location = new System.Drawing.Point(91, 217);
            this.txbOutput.Multiline = true;
            this.txbOutput.Name = "txbOutput";
            this.txbOutput.Size = new System.Drawing.Size(248, 176);
            this.txbOutput.TabIndex = 9;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(94, 185);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(69, 20);
            this.lblOutput.TabIndex = 10;
            this.lblOutput.Text = "Resultat";
            // 
            // menu
            // 
            this.menu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menu.FormattingEnabled = true;
            this.menu.Items.AddRange(new object[] {
            "Registrera person",
            "Avsluta program"});
            this.menu.Location = new System.Drawing.Point(504, 64);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(222, 28);
            this.menu.TabIndex = 11;
            this.menu.SelectedIndexChanged += new System.EventHandler(this.menu_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 463);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txbOutput);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblPnum);
            this.Controls.Add(this.txbPnum);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.txbLname);
            this.Controls.Add(this.lblFname);
            this.Controls.Add(this.title);
            this.Controls.Add(this.txbFname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbFname;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.TextBox txbLname;
        private System.Windows.Forms.Label lblPnum;
        private System.Windows.Forms.TextBox txbPnum;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txbOutput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.ComboBox menu;
    }
}

