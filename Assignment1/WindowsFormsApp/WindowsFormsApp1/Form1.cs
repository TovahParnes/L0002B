// Tovah Parnes, tovah@parnes.com, L0002B, Uppgift 1 Forms-variant

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // Variables
        string output;
        int[] values = { 500, 200, 100, 50, 20, 10, 5, 1 };
        string[] valueNames = { "500-lappar", "200-lappar", "100-lappar", "50-lappar", "20-lappar", "10-kronor", "5-kronor", "1-kronor" };
        

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            output = "";
            int price = int.Parse(tbPrice.Text);
            int paid = int.Parse(tbPaid.Text);

            int change = paid - price;
            if (change < 0)
            {
                output = "Det betalade täcker inte kostnaden. Försök igen.";
            } else
            {
                output += "Växel tillbaka: " + change + " kr\n";

                for (int i = 0; i<values.Length; i++) {
                change = calculateChange(change, values[i], valueNames[i]);
                }
            }
            lblChange.Text = output;
        }

        private int calculateChange(int change, int value, string valueName)
        {
            int valAmmount = (int)Math.Floor((decimal)change / value);
            if (valAmmount > 0)
            {
                output += valueName + ": " + valAmmount + "\n";
                change = change % value;
            }
            return change;
        }

        private void btnExitProgram_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}