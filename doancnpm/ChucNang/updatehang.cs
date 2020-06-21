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
    public partial class updatehang : Form
    {
        private string _MaHang;
        public string MaHang { get => _MaHang; set => _MaHang = value; }
        public Mydel D { get; set; }

        public delegate void Mydel();
        public updatehang(string MH)
        {
            MaHang = MH;
            InitializeComponent();
            
            SetCBB();
            EditOrAdd();

        }
        public void EditOrAdd()
        {
            Model2 db = new Model2();
            string Donvi;
            int j = 0;
            bool check = true;
            if (MaHang == "add")
            {

            }
            if(MaHang != "")
            {
                foreach (MatHang i in db.MatHangs)
                {
                    if (i.MaHang == MaHang)
                    {
                        var l = db.MatHangs.Where(p => p.MaHang == MaHang).FirstOrDefault();
                        txtMahang.Text = i.MaHang.ToString();
                        txtTensanpham.Text = i.TenHang.ToString();
                        txtSoluong.Text = i.SoLuongSp.ToString();
                        dtNgaynhapkho.Value = i.NgayNhapKho;
                        txtGia.Text = i.Gia.ToString();
                        Donvi = i.DonViTinh.TenDonViTinh.ToString();
                        
                        while (check)
                        {
                            cbbDonvitinh.SelectedIndex = j;
                            if (Donvi == cbbDonvitinh.SelectedItem.ToString())
                            {
                                check = false;
                                break;
                            }
                            j++;
                        }
                    }
                }
            }

        }
        public void SetCBB()
        {
            DataTable dt = new DataTable();
            var db = new Model2();
            if (cbbDonvitinh.Items != null)
            {
                cbbDonvitinh.Items.Clear();
            }
            foreach (DonViTinh i in db.DonViTinhs)
            {
                cbbDonvitinh.Items.Add(new CBBItems
                {
                    Values = i.IDDonViTinh,
                    Text = i.TenDonViTinh.ToString()
                });
            }
        }
        public bool Check(string MH, string TH, string SL, string Gia, string NNK, object DVT )
        {
            Model2 db = new Model2();
            var l = db.MatHangs.Select(p => new { p.MaHang, p.TenHang, p.SoLuongSp, p.Gia, p.NgayNhapKho, p.DonViTinh.TenDonViTinh });
            if (MH == "" || TH == "" || SL == "" || Gia == ""|| NNK ==""|| DVT == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return false;
            }
            else if (l.ToList().Count == 1)
            {
                MessageBox.Show("Mặt hàng này đã tồn tại vui lòng nhập lại");
                return false;
            }
            else return true;
        }
        public void SetDB()
        {
            Model2 db = new Model2();
            if (MaHang== "add")
            {
                if (Check(txtMahang.Text, txtTensanpham.Text, txtSoluong.Text ,txtGia.Text, dtNgaynhapkho.Value.ToString(), cbbDonvitinh.SelectedItem))
                {
                    int IDDVT = (cbbDonvitinh.SelectedItem as CBBItems).Values;
                    MatHang mh = new MatHang
                    {
                        MaHang = txtMahang.Text,
                        TenHang = txtTensanpham.Text,
                        SoLuongSp = Convert.ToInt32(txtSoluong.Text.ToString()),
                        Gia = Convert.ToDecimal(txtGia.Text.ToString()),
                        NgayNhapKho = dtNgaynhapkho.Value,
                        IDDonViTinh = IDDVT

                    };

                    try
                    {
                        db.MatHangs.Add(mh);
                        this.MaHang = txtMahang.Text;
                        db.SaveChanges();
                        MessageBox.Show("Thêm thành công!");
                        this.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Nhập sai định dạng!");
                    }
                }

            }
            else
            {
                try
                {
                    var l = db.MatHangs.Where(p => p.MaHang == this.MaHang).FirstOrDefault();
                    l.MaHang = txtMahang.Text;
                    l.TenHang = txtTensanpham.Text;
                    l.SoLuongSp = Convert.ToInt32(txtSoluong.Text.ToString());
                    l.Gia = Convert.ToDecimal(txtGia.Text.ToString());
                    l.NgayNhapKho = dtNgaynhapkho.Value;
                    l.IDDonViTinh = (cbbDonvitinh.SelectedItem as CBBItems).Values;
                    db.SaveChanges();
                    MessageBox.Show("Chỉnh sửa thành công!");
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Nhập sai định dạng!");
                }
            }
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            SetDB();
            if (D != null)
            {
                D();
            };
        }

        private void buttoncancer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
