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
    public partial class HangHoa : Form
    {
        public HangHoa()
        {
            InitializeComponent();
            Show();
        }
        public void Show()
        {
            Model2 db = new Model2();
            var li = db.MatHangs.Select(p => new { p.MaHang, p.TenHang, p.SoLuongSp, p.Gia, p.NgayNhapKho, p.DonViTinh.TenDonViTinh });
            dataGridView1.DataSource = li.ToList();
        }
        private void buttonsearchhang_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new Model2();
                List<MatHang> l = new List<MatHang>();

                foreach (MatHang i in db.MatHangs)
                {
                    if (i.TenHang.ToString().Contains(txtSearch.Text))
                    {
                        l.Add(i);
                    }
                }
                dataGridView1.DataSource = l;
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa nhậo sữ liệu cần tìm!");
            }
        }

        private void buttonaddacc_Click(object sender, EventArgs e)
        {
            updatehang U = new updatehang("add");
            U.D = new updatehang.Mydel(Show);
            U.ShowDialog();
        }

        private void buttonupdateacc_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            if (r.Count == 1)
            {
                string MH = r[0].Cells["MaHang"].Value.ToString();
                updatehang U = new updatehang(MH);
                U.D = new updatehang.Mydel(Show);
                U.ShowDialog();
            }
        }

        private void buttondeleteacc_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            Model2 db = new Model2();
            foreach (MatHang i in db.MatHangs)
            {
                foreach (DataGridViewRow j in r)
                {
                    if (i.MaHang == j.Cells["MaHang"].Value.ToString())
                    {
                        db.MatHangs.Remove(i);
                    }
                }
            }
            db.SaveChanges();
            Show();
        }

        private void buttonsearchacc_Click(object sender, EventArgs e)
        {
            var db = new Model2();
            List<MatHang> t = new List<MatHang>();

            foreach (MatHang i in db.MatHangs)
            {
                if (i.TenHang.ToString().Contains(txtSearch.Text))
                {
                    t.Add(i);
                }
            }

            dataGridView1.DataSource = t;
        }
    }

   
}
