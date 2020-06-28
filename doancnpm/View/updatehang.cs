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
            SetEditOrAdd();

        }
        public void SetEditOrAdd()
        {
            Model1 db = new Model1();
            string Donvi;
            int j = 0;
            bool check = true;
            if (MaHang != "")
            {
                this.Text = "";
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
            var db = new Model1();
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
        public bool Check(string MH, string TH, string SL, string Gia, string NNK, object DVT)
        {
            BLL.HangHoa_BLL.Instance.Check(MH);
            if (MH == "" || TH == "" || SL == "" || Gia == "" || NNK == "" || DVT == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return false;
            }
            else
            {
                if (BLL.HangHoa_BLL.Instance.Check(MH).Count == 1)
                {
                    MessageBox.Show("Mặt hàng này đã tồn tại vui lòng nhập lại");
                    return false;
                }
                else return true;
            }
        }
        public void SetDB()
        {
            Model1 db = new Model1();
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
            if (MaHang == "add")
            {
                if (Check(txtMahang.Text, txtTensanpham.Text,
                    txtSoluong.Text, txtGia.Text, dtNgaynhapkho.Value.ToString(), cbbDonvitinh.SelectedItem))
                {
                    if (BLL.HangHoa_BLL.Instance.ADDorEDIT("add", this.MaHang.ToString(), mh,
                        txtMahang.Text, txtTensanpham.Text, txtSoluong.Text, txtGia.Text, dtNgaynhapkho.Value, cbbDonvitinh.SelectedItem))
                    {
                        this.MaHang = txtMahang.Text;
                        this.Close();
                    }
                }
            }
            else
            {
                if (BLL.HangHoa_BLL.Instance.ADDorEDIT("", this.MaHang.ToString(), mh,
                    txtMahang.Text, txtTensanpham.Text, txtSoluong.Text, txtGia.Text, dtNgaynhapkho.Value, cbbDonvitinh.SelectedItem))
                {
                    this.Close();
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