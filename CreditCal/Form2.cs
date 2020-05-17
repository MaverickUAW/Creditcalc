using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditCal
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double countofcredit;

            double percent;

            double Termin;

            double monthPay;

            double SummPay;

            countofcredit = Convert.ToDouble(textBox1.Text);

            percent = Convert.ToDouble(textBox2.Text);

            monthPay = Convert.ToDouble(textBox3.Text);

            SummPay = Convert.ToDouble(textBox4.Text);

            Termin = Convert.ToDouble(textBox5.Text);


          

            CR Cred = new CR(countofcredit, percent, Termin, monthPay, SummPay);

            switch (CR.Zapros)
            {

                case 1:

                    textBox1.Text = Math.Round(Cred.CountOfCredit(),
                        2).ToString();

                    textBox4.Text = Math.Round(Cred.CountOfPay(),
                        2).ToString();

                    break;

                case 2:

                    textBox4.Text = Math.Round(Cred.CountOfPay(),
                        2).ToString();

                    textBox2.Text = Math.Round(Cred.Procent(), 
                        2).ToString();

                    break;

                case 3:

                    textBox4.Text = Math.Round(Cred.CountOfPayTerm(),
                        0).ToString();

                    textBox5.Text = Math.Round(Cred.vzTerm(),
                        0).ToString();

                    break;
                
            }
           
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}