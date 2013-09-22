using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace the_files_namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            // Directory.CreateDirectory("c:\\abc");
            // Directory.Delete("c:\\abc");

           // File.Create("c:\\a.txt");


            //Console.WriteLine("c:\\a\\b\\c\\d.txt");
            //Console.WriteLine(@"c:\a\b\c\d.txt");


            //Directory.GetFiles(
            //foreach (string i in Directory.GetFiles(@"C:\IDE\Common7\IDE"))
            //{
            //    Console.WriteLine(Path.GetFileName(i));
            //}

            //DirectoryInfo d = new DirectoryInfo(@"C:\IDE\Common7\IDE");
            //foreach (FileInfo f in d.GetFiles())
            //{
            //    Console.WriteLine(f.FullName);
            //}

            //StreamWriter writer = new StreamWriter("a.txt",true);
            ////writer.AutoFlush = true;
            //writer.WriteLine("hello");
            //writer.WriteLine("how do you do");
            //writer.WriteLine("today");
            ////writer.Flush();
            //writer.Close();

            StreamReader reader = new StreamReader("a.txt");
            //Console.WriteLine(reader.ReadToEnd());

            while (!reader.EndOfStream)
            {
                Console.WriteLine(reader.ReadLine());
            }

            reader.Close();
            
        }
    }
}
