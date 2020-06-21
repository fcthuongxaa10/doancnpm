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
        private updatehang updatehang;
        public HangHoa()
        {
            
            InitializeComponent();
            Model4 db = new Model4();
            var li = db.MatHangs.Select(p => p);
            dataGridView1.DataSource = li.ToList();
        }

        private void Showdtg()
        {
            Model4 db = new Model4();
            var l = db.MatHangs.Select(p => p);
            dataGridView1.DataSource = l.ToList();
        }

        private void buttonsearchacc_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new Model4();
                List<MatHang> l = new List<MatHang>();

                foreach (MatHang i in db.MatHangs)
                {
                    if (i.TenHang.ToString().Contains(textBox1.Text))
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

        private void buttondeleteacc_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection s = dataGridView1.SelectedRows;
            Model4 mh = new Model4();
            if (s == null)
            {
                MessageBox.Show("Hãy chọn mặt hàng cần xóa!");
            }
            else
            {
                foreach (MatHang i in mh.MatHangs)
                {
                    foreach (DataGridViewRow j in s)
                    {
                        if (i.MaHang == j.Cells["MaHang"].Value.ToString())
                        {
                            mh.MatHangs.Remove(i);
                        }
                    }
                }
                mh.SaveChanges();
                Show();
            }
            
        }
       
        private void buttonaddacc_Click(object sender, EventArgs e)
        {
            //updatehang f = new updatehang("");
            //f.D += new updatehang
            //f.ShowDialog();
        }
    }

   
}
