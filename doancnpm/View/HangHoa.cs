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
            dataGridView1.DataSource = BLL.HangHoa_BLL.Instance.GetMH();
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
            BLL.HangHoa_BLL.Instance.Dell(r);
            Show();
        }

        private void buttonsearchacc_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = BLL.HangHoa_BLL.Instance.GetMH_search(txtSearch.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa nhậo sữ liệu cần tìm!");
            }
        }
    }


}