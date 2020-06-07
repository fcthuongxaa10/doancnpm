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
                themnhanvien f = new themnhanvien("");
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
                        string id = r[0].Cells["id"].Value.ToString();
                        themnhanvien f = new themnhanvien(id);
                        //f.D += new Form2.dele(Show);
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

        private void buttonxoanv_Click(object sender, EventArgs e)
        {

        }

        private void ShowNV_Load(object sender, EventArgs e)
        {//cái ni là tạo db sai cmnr  để coi tí// 

            Model1 Db = new Model1();
                    var li = Db.USERs.Select(p => new { p.ID, p.HoTen, p.LuongCB, p.NgaySinh, p.SDT, p.GioiTinh });
                    dataGridView1.DataSource = li.ToList();
                
            //
            
        }
    }
}
