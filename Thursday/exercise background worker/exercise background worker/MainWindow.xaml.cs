using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace exercise_background_worker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BackgroundWorker bw = new BackgroundWorker();
        int num;
        public MainWindow()
        {
            InitializeComponent();
            bw.DoWork += bw_DoWork;
            bw.WorkerReportsProgress = true;
            bw.ProgressChanged += bw_ProgressChanged;
        }

        void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbar.Value = e.ProgressPercentage;
            lst.Items.Add(e.ProgressPercentage);
            lst.ScrollIntoView(e.ProgressPercentage);
            
        }

        void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; i <=num; i++)
            {
                Thread.Sleep(1);
                bool flag = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i%j==0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    bw.ReportProgress(i);
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            num = int.Parse(txt.Text);
            pbar.Minimum=0;
            pbar.Maximum = num;
            bw.RunWorkerAsync();
        }
    }
}
