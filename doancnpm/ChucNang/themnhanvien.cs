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
    public partial class themnhanvien : Form
    {
        private string _id;
        public themnhanvien(string s)
        {
            InitializeComponent();
            Id = s;
        }

        public string Id { get => _id; set => _id = value; }
    }
}
