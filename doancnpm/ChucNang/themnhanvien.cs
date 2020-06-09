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
            EditOrAdd();
        }


        public void EditOrAdd()
        {
            Model1 db = new Model1();
            if (Id == null)
            {

            }
            else
            {
                foreach (USER i in db.USERs)
                {
                    if (i.ID == Id)
                    {
                        var li = db.USERs.Where(p => p.ID == Id).FirstOrDefault();
                        txtID.Text = (li.ID).ToString();
                        txttenNv.Text = li.HoTen;
                        txtDiaChi.Text = li.Diachi;
                        txtSDT.Text = li.SDT;
                        txtLuong.Text = li.LuongCB.ToString();
                        txtngaylam.Text = (li.SoNgayLam).ToString();
                        txttienthuong.Text = li.SoTienThuong.ToString();
                        txttienphat.Text = li.SoTienPhat.ToString();
                        if (i.GioiTinh)
                        {
                            radioButton1.Checked = true;
                        }
                        else
                        {
                            radioButton2.Checked = true;
                        }
                        dateTimePicker1.Value = li.NgaySinh;
                    }
                }
            }

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
                if(Id==0)
                {
                    try
                    {
                        USER s = new USER()
                        {
                            ID = Convert.ToInt32(txtID.Text),
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
                        var li1 = DB.USERs.Select(p => new { p.ID, p.HoTen, p.LuongCB, p.NgaySinh, p.SDT, p.GioiTinh, p.SoNgayLam, p.SoTienThuong, p.SoTienPhat, p.Diachi });
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
    }
}
