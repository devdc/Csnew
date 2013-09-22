using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise_Bank_account
{

    public delegate void ledHandler(string message);

    public partial class Form1 : Form
    {
        Account acc = new Account();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            acc.WithDraw(double.Parse(textBox1.Text));
            label1.Text=acc.Balance.ToString();
        }

        private void btnDeposit_Click(object sender, EventArgs e) 
        {
            acc.Deposit(double.Parse(textBox1.Text));
            label1.Text=acc.Balance.ToString();

        }

        static void theFun(string msg)
        {
            Console.WriteLine("the message from the bank is: " + msg);
        }

    }

   

}
