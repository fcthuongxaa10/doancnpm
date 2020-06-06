using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doancnpm
{
    public partial class timeskip : Form
    {
        public timeskip()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            int i;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            for (i = 0; i <100; i++)
            {
                progressBar1.Value = i;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin f = new Admin();
            f.ShowDialog();
        }
    }
}
