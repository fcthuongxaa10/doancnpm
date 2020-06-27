using doancnpm.DB;
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
    public partial class ThemHD : Form
    {
        private int ID;
        public ThemHD(int s)
        {
            ID1 = s;
            InitializeComponent();
        }

        public int ID1 { get => ID; set => ID = value; }

        private void ThemHD_Load(object sender, EventArgs e)
        {
            textBox1.Text = ID1.ToString();
            textBox2.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            HoaDonBanHang H = new HoaDonBanHang()
            {
                IDNV = Convert.ToInt32(textBox1.Text),
                TongTien = Convert.ToDecimal(textBox2.Text),
                MaHD = textBox3.Text,
                NgayLapHD = DateTime.Now,
            };
            db.HoaDonBanHangs.Add(H);
            db.SaveChanges();
            var li = db.HoaDonBanHangs.Select(p => p);   
        }
    }
}
