using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace the_sender_and_e
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)sender).Text  ;
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = "X:" + e.X + " Y:" + e.Y;
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show(e.KeyChar.ToString());
            if (e.KeyChar=='a')
            {
               // e.KeyChar = 'B';
                e.Handled = true;
            }
        }
    }
}
