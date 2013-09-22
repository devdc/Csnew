using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace the_thread
{
    public partial class Form1 : Form
    {
        BackgroundWorker bw = new BackgroundWorker();

        public Form1()
        {
            InitializeComponent();
            bw.DoWork += bw_DoWork;
            bw.WorkerReportsProgress = true;
            bw.ProgressChanged += bw_ProgressChanged;
        }

        void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            label1.Text = "i=" + e.ProgressPercentage;
        }

        void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i <= 10; i++)
            {
                MessageBox.Show("i="+i);
                //label1.Text = "i=" + i;
                bw.ReportProgress(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bw.RunWorkerAsync();
          
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            bw.RunWorkerAsync();
        }
    }
}
