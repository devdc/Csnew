using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aaa.WebServiceSoapClient x = new aaa.WebServiceSoapClient();
            textBox3.Text = x.Add(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
        }
    }
}
