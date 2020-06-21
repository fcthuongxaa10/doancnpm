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
        public laphoadon()
        {
            InitializeComponent();
        }

        private void buttonnhaphd_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            string MHDd=txtmaHD.Text;
            string mahang = txtmahang.Text;
            int soLuong =Convert.ToInt32(txtsoluong.Text);
            string ten = "";
            int gia;
           // string MHD="";
            int thanhtien;
            //HoaDonBanHang C = new HoaDonBanHang()
            //{
            //    MaHD=MHDd,
            //    NgayLapHD = dateTimePicker1.Value,
            //    TongTien =30000,
            //    IDNV =3,
            //};
           
            ChiTietHoaDon ct = new ChiTietHoaDon()
            {
                MaHD = MHDd,  
                MaHang = mahang,
                SoLuong = soLuong.ToString(),
            };
           // db.HoaDonBanHangs.Add(C);
            db.ChiTietHoaDons.Add(ct);
            db.SaveChanges();
            var li = db.MatHangs.Where(p => p.MaHang == mahang).FirstOrDefault();
            {
                ten = li.TenHang;
                gia = Convert.ToInt32(li.Gia);
            };
            
            thanhtien = gia * soLuong;
            var li2 = db.ChiTietHoaDons.Where(p => p.MaHang ==mahang ).
                Select(p => new { p.MaHD, p.MaHang, ten, gia, p.SoLuong});
            dataGridView1.DataSource = li2.ToList();
        }
    }
}
