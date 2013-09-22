using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace example_xml
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XElement x = XElement.Load("a.xml");

            var q = from c in x.Descendants("country")
                    select c;
            foreach (XElement i in q)
            {
                Console.WriteLine(i);
            }


        }
    }
}
