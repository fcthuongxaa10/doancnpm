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
using static doancnpm.HangHoa;

namespace doancnpm
{
    public partial class updatehang : Form
    {
        private string _MaHang;
        public string MaHang { get => _MaHang; set => _MaHang = value; }
        public Mydel D { get; set; }
        public delegate void Mydel();
        public updatehang(string s)
        {
            InitializeComponent();
            MaHang = s;
        }
        public void SetView()
        {
            this.Text = "ADD";
            if (this.MaHang!= "")
            {
                this.Text = "EDIT";
                txtMasanpham.Text = MaHang;
                Model4 db = new Model4();
                foreach (MatHang i in db.MatHangs)
                {
                    if (i.MaHang == MaHang)
                    {
                        txtMasanpham.Text = MaHang.ToString();
                        txtTensanpham.Text = i.TenHang.ToString();
                        txtGiaban.Text = i.Gia.ToString();
                        txtNgaynhapkho.Text = i.NgayNhapKho.ToString();

                    }
                }
            }
        }
        public void AU()
        {

            Model4 db = new Model4();
            //if (this.MaHang == "")
            //{
            //    if (Check_Infor(txtMasanpham.Text, txtTensanpham.Text, txtGiaban.Text, txtNgaynhapkho.Text, txtDonvitinh))
            //    {

            //        MatHang sv = new MatHang
            //        {
            //            MaHang = txtMasanpham.Text,
            //            //TenHang = txtTensanpham.Text,
            //            //Gia = txtGiaban.Text,
            //            //NgayNhapKho = txtNgaynhapkho.Text,
            //            //DonViTinh = 
            //        };

            //        try
            //        {
            //            //db.SinhVien.Add(sv);
            //            // this.MSSV = txtMSSV.Text;
            //            db.SaveChanges();
            //            MessageBox.Show("Thêm thành công!");
            //            this.Close();
            //        }
            //        catch (Exception)
            //        {
            //            MessageBox.Show("Nhập sai định dạng!");
            //        }
            //    }

            //}
            //else
            //{
            //    try
            //    {
            //        //var l = db.SinhVien.Where(p => p.MSSV == this.MSSV).FirstOrDefault();
            //        //l.MSSV = MSSV;
            //        //l.NameSV = txtNameSV.Text;
            //        //l.Age = Convert.ToInt32(txtAge.Text);
            //        //l.ID_Lop = (cbbNameLop.SelectedItem as CBBItems).Values;
            //        db.SaveChanges();
            //        MessageBox.Show("Chỉnh sửa thành công!");
            //        this.Close();
            //    }
            //    catch (Exception)
            //    {
            //        MessageBox.Show("Nhập sai định dạng!");
            //    }
            //}
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            AU();
            if (D != null)
            {
                D();
            };
        }

        public bool Check_Infor(string Mahang, string Tenhang, string Giaban, string Ngaynhapkho, string Donvitinh)
        {
            Model4 db = new Model4();
            var l = db.MatHangs.Select(p => p );
            if (Mahang == "" || Tenhang == "" || Giaban == "" || Ngaynhapkho == "" || Donvitinh == "")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin");
                return false;
            }
            else if (l.ToList().Count == 1)
            {
                MessageBox.Show(" Sinh viên này đã tồn tại vui lòng nhập lại");
                return false;
            }
            else return true;
        }

        private void btnCanCel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
