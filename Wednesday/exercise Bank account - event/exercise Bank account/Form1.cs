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
    public partial class Form1 : Form
    {
        Account acc = new Account();

        public Form1()
        {
          
            InitializeComponent();
            label1.Text = acc.Balance.ToString();
            acc.OverDraft += acc_OverDraft;
        }

        void acc_OverDraft(double minus)
        {
            MessageBox.Show("an over balance of "+minus +" shekels is prohibited");
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
    }
}
