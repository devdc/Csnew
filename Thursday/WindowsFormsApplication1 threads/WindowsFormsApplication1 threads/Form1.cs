using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace WindowsFormsApplication1_threads
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // DoSomething();
            Thread t = new Thread(DoSomething);
            t.Priority = ThreadPriority.AboveNormal;

            t.Start();
           
        }

        void DoSomething()
        {
            for (int i = 0; i < 7; i++)
            {
                MessageBox.Show(i.ToString());
            }
        }
    }
}
