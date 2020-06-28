﻿using doancnpm.BLL;
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
    public partial class ShowNV : Form
    {
        public ShowNV()
        {
            InitializeComponent();
        }

        private void buttonaddnhanvien_Click(object sender, EventArgs e)
        {
            try
            {
                themnhanvien f = new themnhanvien(0);
                f.D += new themnhanvien.dele(Show);
                f.ShowDialog();

            }
            catch (Exception)
            {
                return;
            }
        }

        private void buttoneditnv_Click(object sender, EventArgs e)
        {
           
                DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
                try
                {
                    if (r.Count == 1)
                    {
                        int id =Convert.ToInt32(r[0].Cells["id"].Value.ToString());
                        themnhanvien f = new themnhanvien(id);
                    f.D += new themnhanvien.dele(Show);
                        f.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Mời Chọn Nhân Viên Để Chỉnh Sửa");
                    }
                }
                catch (Exception)
                {

                    return;
                }
            }
        public  void Show()
        {
            dataGridView1.DataSource = BLL.QuanLiNhanVien_BLL.Instance.ShowThongTinNhanVien();
        }

        private void buttonxoanv_Click(object sender, EventArgs e)
        {

            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            Model1 db = new Model1();
            if(r==null)
            {
                MessageBox.Show("Mời chọn nhân viên cần xóa");
            }
            if (BLL.QuanLiNhanVien_BLL.Instance.DelNV(r))
            {
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("có lỗi");
            }
            var li1 = db.USERs.Select(p => new { p.ID, p.HoTen, p.LuongCB, p.NgaySinh, p.SDT, p.GioiTinh, p.SoNgayLam, p.SoTienThuong, p.SoTienPhat, p.Diachi });
            dataGridView1.DataSource = li1.ToList();
          
        }

        

        private void buttonsearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.QuanLiNhanVien_BLL.Instance.SearchNV(txtsearch.Text);
        }

        private void ShowNV_Load(object sender, EventArgs e)
        {
          dataGridView1.DataSource= BLL.QuanLiNhanVien_BLL.Instance.ShowThongTinNhanVien();
        }
        private void buttonchamcong_Click(object sender, EventArgs e)
        {

        }

     
    }
}