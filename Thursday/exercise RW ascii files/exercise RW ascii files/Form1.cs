using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace exercise_RW_ascii_files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {

            if (File.Exists("a.txt"))
            {
                listBox1.Items.Clear();
                StreamReader r = new StreamReader("a.txt");
                while (!r.EndOfStream)
                {
                    listBox1.Items.Add(r.ReadLine());
                }
                r.Close();
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {

            //StreamWriter w = new StreamWriter("a.txt", true);

            FileStream fs = new FileStream("a.txt", FileMode.Append, FileAccess.Write, FileShare.None);
            StreamWriter w = new StreamWriter(fs);


            w.WriteLine(textBox1.Text);
            w.Close();
            //btnRead_Click(null, null);
            btnRead_Click(sender, e);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            int location, count = 0;

            StreamReader r = new StreamReader("a.txt");

            string data = r.ReadToEnd();
            int originalLength = data.Length;
            int newLength = data.Replace(textBox1.Text, "").Length;
            MessageBox.Show( ((originalLength-newLength)/textBox1.Text.Length).ToString()  );

            //while (r.EndOfStream==false)
            //{
            //    string line = r.ReadLine();
                
            //    location = -1;               
                //do
                //{
                //    location = line.IndexOf(textBox1.Text, ++location);
                //    if (location>-1)
                //    {
                //        count++;
                //    }
                    
                //} while (location!=-1);
            //}
            r.Close();
            //MessageBox.Show(count.ToString());
        }
    }
}
