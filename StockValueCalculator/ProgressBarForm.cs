using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockValueCalculator
{
    public partial class ProgressBarForm : Form
    {
        private Thread progressBarThread;

        public ProgressBarForm()
        {
            InitializeComponent();
        }

        public ProgressBarForm(int x, int y, string title)
        {
            InitializeComponent();

            this.Location = new Point(x, y);
            this.Text = title;
        }

        public void StartProgressBar()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Utils.InvokeDelegate(StartProgressBar),null);
            }
            else
            {
                //progressBarThread = new Thread(() =>
                //{
                //    this.Show();
                //});

                //progressBarThread.Start();

                this.Show();
            }
            
        }

        public void StopProgressBar()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Utils.InvokeDelegate(StopProgressBar),null);
            }
            else
            {
                //if (progressBarThread != null && progressBarThread.IsAlive)
                //{
                //    progressBarThread.Abort();
                //}

                this.Dispose();
            }
            
        }
    }
}
