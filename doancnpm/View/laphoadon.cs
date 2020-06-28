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
            txtID.Text = IDnv1.ToString();
        }

        public int IDnv1 { get => IDnv; set => IDnv = value; }

        private void buttonnhaphd_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            string MHDd = txtmaHd.Text;
            string mahang = txtmahang.Text;
            int soLuong =Convert.ToInt32(txtsoluong.Text);
            string ten ="";
            int gia;
            int thanhtien;
            var li = db.Accounts.Where(p => p.IDuser == IDnv1).FirstOrDefault();
            int idacc = li.ID;
            ChiTietHoaDon ct = new ChiTietHoaDon()
            {
                MaHD =MHDd ,  
                MaHang = mahang,
                SoLuong = soLuong.ToString(),
            };
            db.ChiTietHoaDons.Add(ct);
            db.SaveChanges();
            var li1 = db.MatHangs.Where(p => p.MaHang == mahang).FirstOrDefault();
            {
                ten = li1.TenHang;
                gia = Convert.ToInt32(li1.Gia);
            };
            thanhtien = gia * soLuong;
            var li2 = db.ChiTietHoaDons.Where(p => p.MaHang==mahang && p.MaHD==MHDd).
               Select(p => new { p.MaHD, p.MaHang, ten, gia, p.SoLuong});
            dataGridView1.DataSource = li2.ToList();
        }
     

        private void butttontongtien_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
           

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string Mhd = txtmaHd.Text;
            Model1 db = new Model1();
            var mahd = db.HoaDonBanHangs.Where(p => p.MaHD == Mhd).FirstOrDefault();
                if(mahd==null)
            {
                var li = db.Accounts.Where(p => p.IDuser == IDnv1).FirstOrDefault();
                int idacc = li.ID;
                HoaDonBanHang h = new HoaDonBanHang()
                {
                    MaHD = txtmaHd.Text,
                    IDNV = idacc,
                    TongTien = 0,
                    NgayLapHD = DateTime.Now,
                };
                db.HoaDonBanHangs.Add(h);
                db.SaveChanges();
                MessageBox.Show("OK");
            }
                else
            {
                MessageBox.Show("Ma hoa don da ton tai");
            }
            
           
        }
        public string MaHD(string mhd)
        {
            Model1 db = new Model1();
            var li = db.HoaDonBanHangs.Where(p => p.MaHD == mhd).FirstOrDefault();
            return mhd;
        }
    }
}
