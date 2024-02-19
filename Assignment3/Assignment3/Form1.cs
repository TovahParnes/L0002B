using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Variables
        string output;

        private void btnRegister_Click(object sender, EventArgs e)
        {
            output = "";
            string fName = txbFname.Text;
            string lName = txbLname.Text;
            long pNum = long.Parse(txbPnum.Text);

            if (!validPnum(pNum))
            {
                output = "Personnummret är inte giltigt.";
                lblOutput.Text = output;
                return;
            }

            output += ("Förnamn: " + fName + "\n");
            output += ("Efternamn: " + lName + "\n");
            output += ("Personnummer: " + pNum + "\n");

            lblOutput.Text = output;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool validPnum(long pNum)
        {
            return true;
        }
    }
}
