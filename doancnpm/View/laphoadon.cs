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
    public partial class laphoadon : Form
    {
        private int IDnv;
        public laphoadon(int s)
        {
            IDnv1 = s;
            InitializeComponent();
        }

        public int IDnv1 { get => IDnv; set => IDnv = value; }

        private void buttonnhaphd_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            string MHDd=txtmaHD.Text;
            string mahang = txtmahang.Text;
            int soLuong =Convert.ToInt32(txtsoluong.Text);
            string ten = "";
            int gia;
            int thanhtien;
            ChiTietHoaDon ct = new ChiTietHoaDon()
            {
                MaHD = MHDd,  
                MaHang = mahang,
                SoLuong = soLuong.ToString(),
            };
            db.ChiTietHoaDons.Add(ct);
            db.SaveChanges();
            var li = db.MatHangs.Where(p => p.MaHang == mahang).FirstOrDefault();
            {
                ten = li.TenHang;
                gia = Convert.ToInt32(li.Gia);
            };
            thanhtien = gia * soLuong;
            var li2 = db.ChiTietHoaDons.Where(p => p.HoaDonBanHang.MaHD ==MHDd).
                Select(p => new { p.MaHD, p.MaHang, ten, gia, p.SoLuong});
            dataGridView1.DataSource = li2.ToList();
        }
     
        private void iconButton1_Click(object sender, EventArgs e)
        {
            ThemHD f = new ThemHD(IDnv1);
            f.ShowDialog();
        }

        private void butttontongtien_Click(object sender, EventArgs e)
        {

        }
    }
}
