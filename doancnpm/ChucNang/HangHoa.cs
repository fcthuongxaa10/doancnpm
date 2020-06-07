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
            Model1 db = new Model1();
            var li = db.MatHangs.Select(p => new { p.MaHang, p.TenHang });
            dataGridView1.DataSource = li.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
