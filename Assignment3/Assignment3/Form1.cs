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
            Person person = new Person(txbFname.Text, txbLname.Text, txbPnum.Text);

            if (!person.validPnum())
            {
                output = "Personnummret är inte giltigt.";
                txbOutput.Text = output;
                return;
            }

            //todo fix new line in printing
            output += ("Förnamn: " + person.fName + "   \n");
            output += ("Efternamn: " + person.lName + "     \n");
            output += ("Personnummer: " + person.pNum + "   \n");
            output += ("Kön: " + person.getGender() + "\n");

            txbOutput.Text = output;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }

    internal class Person
    {
        public string fName;
        public string lName;
        public string pNum;

        public Person(string FName, string LName, string Pnum)
        {
            this.fName = FName;
            this.lName = LName;
            this.pNum = Pnum;
        }

        public bool validPnum()
        {
            if (pNum.Length != 10)
            {
                return false;
            }

            bool multiply = true;
            int sum = 0;
            foreach (char i in pNum)
            {
                int num = i - '0';
                if (multiply && num >= 5)
                {
                    sum += num*2 % 10 + 1;
                }
                else
                {
                    sum += num;
                }
                multiply = !multiply;
            }
            Console.WriteLine(sum);

            if (sum%10 == 0)
            {
                return true;
            }
            return false;
        }

        public string getGender()
        {
            int gen = pNum[pNum.Length - 2] - '0';
            if (gen%2 == 0)
            {
                return "Kvinna";
            }
            return "Man";
        }
    }
}
