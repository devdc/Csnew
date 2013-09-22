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


namespace the_RW_binary_files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         //int.Parse("aaa");


            string s = "abc";
           // Console.WriteLine( (int)s[0]);
            Console.WriteLine( (char)99);


            //FileStream fs = new FileStream("a.bin", FileMode.Create);
            //BinaryWriter w = new BinaryWriter(fs);
            //w.Write("hello");
            //w.Write(123);
            //w.Write(4.7);
            //w.Write(true);
            //w.Write("fin");
            //w.Close();





           // FileStream fs = new FileStream("a.bin", FileMode.Open);
           // BinaryReader r = new BinaryReader(fs);
           // int x = 0;
           // while (x<100)
           // {
           //     Console.WriteLine(r.ReadByte());
           //     x++;                
           // }
           // //Console.WriteLine(r.ReadString());
           // //Console.WriteLine(r.ReadInt32());
           // //Console.WriteLine(r.ReadDouble());
           // //Console.WriteLine(r.ReadBoolean());
           //// Console.WriteLine(r.ReadString());
           // r.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
        }
    }
}
