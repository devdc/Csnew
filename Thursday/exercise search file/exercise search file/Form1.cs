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
namespace exercise_search_file
{
    public partial class Form1 : Form
    {
        string path;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //colorDialog1.ShowDialog();
            //this.BackColor = colorDialog1.Color;

            folderBrowserDialog1.ShowDialog();
            path=folderBrowserDialog1.SelectedPath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //foreach (string file in Directory.GetFiles(path+"\\"+textBox1.Text))
            //foreach (string file in Directory.GetFiles(path,textBox1.Text,SearchOption.AllDirectories))
            //{
            //    listBox1.Items.Add(file);
            //}
            FindFile(path, textBox1.Text);
        }

        void FindFile(string path, string filename)
        {
            foreach (string  f in Directory.GetFiles(path))
            {
                if (Path.GetFileName(f)==filename)
                {
                    listBox1.Items.Add(f);
                }
            }
           
            foreach (string dir in Directory.GetDirectories(path))
            {
                FindFile(dir, filename);
            }
           
        }
    }
}
