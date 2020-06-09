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
            Model2 db = new Model2();
            var li = db.MatHangs.Select(p => p);
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
    }

   
}
