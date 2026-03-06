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

namespace ProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
            progressBar1.Value = 0;


            for (int i = 0; i < 10; i++)
            {

                if(progressBar1.Value < progressBar1.Maximum)
                {
                    Thread.Sleep(500);
                    progressBar1.Value += 10;

                    label1.Text = (((float)progressBar1.Value / progressBar1.Maximum) * 100) + "%";

                    progressBar1.Refresh();
                    label1.Refresh();
                }

            }
            
            if(progressBar1.Value == progressBar1.Maximum)
                MessageBox.Show("Download Done", "", MessageBoxButtons.OK);

        }
    }
}
