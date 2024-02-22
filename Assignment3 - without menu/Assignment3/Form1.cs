using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Assignment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Variables
        List<string> output = new List<string>();
        Person test = new Person("", "", "");

        private void btnRegister_Click(object sender, EventArgs e)
        {
            output.Clear();
            Person person = new Person(txbFname.Text, txbLname.Text, txbPnum.Text);

            /*
            //Return if not a valid pnum
            if (!person.validPnum())
            {
                output.Add("Personnummret är inte giltigt.");
                OutputText(output);
                return;
            }

            output.Add("Förnamn: " + person.fName + "   \n");
            output.Add("Efternamn: " + person.lName + "     \n");
            output.Add("Personnummer: " + person.pNum + "   \n");
            output.Add("Kön: " + person.getGender() + "\n");

            OutputText(output);
            */
            OutputText(test.generateOutput());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Function for outputting the resuly
        private void OutputText(List<string> output)
        {
            txbOutput.Text = "";
            foreach (string s in output)
            {
                txbOutput.AppendText(s);
                txbOutput.AppendText(Environment.NewLine);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txbPnum_TextChanged(object sender, EventArgs e)
        {
            test.PNum = txbPnum.Text;

        }

        private void txbLname_TextChanged(object sender, EventArgs e)
        {
            test.lName = txbLname.Text;
        }

        private void txbFname_TextChanged(object sender, EventArgs e)
        {
            test.fName = txbFname.Text;
        }
    }

    internal class Person
    {
        public string fName;
        public string lName;
        private string pNum;
        private bool valid;
        private List<String> output;
        private string gender;

        public Person(string fName, string lName, string pNum)
        {
            this.fName = fName;
            this.lName = lName;
            this.pNum = pNum;
        }

        public string PNum
        {
            get => pNum;
            set
            {
                if (validPnum(value)){
                    pNum = value;
                }
            }
        }

        public bool validPnum(string pNum)
        {
            if (pNum.Length != 10)
            {
                valid  = false;
                return valid;
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
                valid = true;
                return valid;
            }
            valid = false;
            return valid;
        }

        public string getGender()
        {
            int gen = pNum[pNum.Length - 2] - '0';
            if (gen%2 == 0)
            {
                gender = "Kvinna";
                return "Kvinna";
            }
            gender = "Man";
            return "Man";
        }

        public List<string> generateOutput()
        {
            output.Add("Förnamn: " + fName + "   \n");
            output.Add("Efternamn: " + lName + "     \n");
            output.Add("Personnummer: " + pNum + "   \n");
            output.Add("Kön: " + getGender() + "\n");
            return output;
        }
    }
}
