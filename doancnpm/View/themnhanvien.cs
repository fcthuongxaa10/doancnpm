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
    public partial class themnhanvien : Form
    {
        private int _id;
        public delegate void dele();
        public dele D;

        public int Id { get => _id; set => _id = value; }

        public themnhanvien(int s)
        {
            InitializeComponent();
            Id = s;
            if(Id!=0)
            {
                EditOrAdd(Id);
            }
        }


        public void EditOrAdd(int id)
        {
            USER s = new USER();
            s = BLL.QuanLiNhanVien_BLL.Instance.Getusser(id);
            txtID.Text = s.ID.ToString();
            txttenNv.Text = s.HoTen;
            txtDiaChi.Text = s.Diachi;
            txtSDT.Text = s.SDT;
            txtLuong.Text =s.LuongCB.ToString();
            txtngaylam.Text = s.SoNgayLam.ToString();
            txttienthuong.Text = s.SoTienThuong.ToString();
            txttienphat.Text = s.SoTienPhat.ToString();
            if(s.GioiTinh==true)
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
            dateTimePicker1.Value = s.NgaySinh;
        }

        private void buttonaddnv_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txttenNv.Text == "" || txtDiaChi.Text == "" || txtLuong.Text == "" || txtSDT.Text == "" || txtngaylam.Text == "" || txttienthuong.Text == "" || txttienphat.Text == "")
            {
                MessageBox.Show("Thiếu Thông Tin Bắt Buộc");
            }
            else
            {
                Model1 DB = new Model1();
                if (Id == 0)
                {
                    try
                    {
                        USER s = new USER()
                        {
                            HoTen = txttenNv.Text,
                            Diachi = txtDiaChi.Text,
                            SDT = txtSDT.Text,
                            LuongCB = Convert.ToDecimal(txtLuong.Text),
                            SoNgayLam = Convert.ToInt32(txtngaylam.Text),
                            SoTienThuong = Convert.ToDecimal(txttienthuong.Text),
                            SoTienPhat = Convert.ToDecimal(txttienphat.Text),
                            GioiTinh = radioButton1.Checked,
                            NgaySinh = Convert.ToDateTime(dateTimePicker1.Value.ToString()),
                        };
                        DB.USERs.Add(s);
                        DB.SaveChanges();

                        MessageBox.Show("Thêm Thành Công");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Có Lỗi Trong Quá Trình Xử Lí");
                    }
                }
                else
                {
                    try
                    {
                        var li = DB.USERs.Where(p => p.ID == Id).FirstOrDefault();
                        {
                            li.ID = Convert.ToInt32(txtID.Text);
                            li.HoTen = txttenNv.Text;
                            li.Diachi = txtDiaChi.Text;
                            li.SDT = txtSDT.Text;
                            li.LuongCB = Convert.ToDecimal(txtLuong.Text);
                            li.SoNgayLam = Convert.ToInt32(txtngaylam.Text);
                            li.SoTienThuong = Convert.ToDecimal(txttienthuong.Text);
                            li.SoTienPhat = Convert.ToDecimal(txttienphat.Text);
                            li.NgaySinh = Convert.ToDateTime(dateTimePicker1.Value.ToString());
                            li.GioiTinh = radioButton1.Checked;
                        }
                        DB.SaveChanges();
                        var li1 = DB.USERs.Select(p => new { p.ID, p.HoTen, p.LuongCB, p.NgaySinh, p.SDT, p.GioiTinh, p.SoNgayLam, p.SoTienThuong, p.SoTienPhat, p.Diachi });
                        MessageBox.Show("OK");
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Có Lỗi Trong Quá Trình Xử Lí");
                    }
                }
            }

            D();
        }

        private void buttoncancer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public USER add()
        {
            USER s = new USER();
            s.ID = Convert.ToInt32(txtID.Text);
            s.HoTen = txttenNv.Text;
            s.Diachi = txtDiaChi.Text;
            s.SDT = txtSDT.Text;
            s.LuongCB = Convert.ToDecimal(txtLuong.Text);
            s.SoNgayLam = Convert.ToInt32(txtngaylam.Text);
            s.SoTienThuong = Convert.ToDecimal(txttienthuong.Text);
            s.SoTienPhat = Convert.ToDecimal(txttienphat.Text);
            s.NgaySinh = Convert.ToDateTime(dateTimePicker1.Value.ToString());
            s.GioiTinh = radioButton1.Checked;
            return s;
        }
        public USER update(int ID)
        {
            USER s = new USER();
            s.ID = Convert.ToInt32(txtID.Text);
            s.HoTen = txttenNv.Text;
            s.Diachi = txtDiaChi.Text;
            s.SDT = txtSDT.Text;
            s.LuongCB = Convert.ToDecimal(txtLuong.Text);
            s.SoNgayLam = Convert.ToInt32(txtngaylam.Text);
            s.SoTienThuong = Convert.ToDecimal(txttienthuong.Text);
            s.SoTienPhat = Convert.ToDecimal(txttienphat.Text);
            s.NgaySinh = Convert.ToDateTime(dateTimePicker1.Value.ToString());
            s.GioiTinh = radioButton1.Checked;
            return s;
        }
    }
}
