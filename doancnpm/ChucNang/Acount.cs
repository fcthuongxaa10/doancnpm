using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using doancnpm.ChucNang;
using doancnpm.DB;

namespace doancnpm
{
    public partial class Acount : Form
    {
        public Acount()
        {
            InitializeComponent();
        }
        public void ShowDGV()
        {
            Model4 db = new Model4();
            var li = db.Accounts.Select(p => p);
            dtAC.DataSource = li.ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model4 db = new Model4();
            DataGridViewSelectedRowCollection r = dtAC.SelectedRows;
            if (r.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn hàng bạn muốn xóa");
            }
            else
            {
                foreach (Account i in db.Accounts)
                {
                    foreach (DataGridViewRow j in r)
                        if (i.ID.ToString() == j.Cells["ID"].Value.ToString())
                        {
                            db.Accounts.Remove(i);
                        }


                }
                db.SaveChanges();
                dtAC.DataSource = db.Accounts.ToList();
            }
        }

        private void buttonsearch_Click(object sender, EventArgs e)
        {
            Model4 db = new Model4();
            string sea = textSearchAcc.Text;
            try
            {
                var list_sea = db.Accounts.Where(p => p.USER.HoTen.Contains(sea));
                dtAC.DataSource = list_sea.ToList();

            }
            catch (Exception)
            {

            }
        }

        private void buttonaDD_Click(object sender, EventArgs e)
        {
            try
            {
                Form2Acc f = new Form2Acc(0);
                f.D += new Form2Acc.mydel(ShowDGV);
                f.ShowDialog();
            }
            catch(Exception )
            {
                return;
            }

        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dtAC.SelectedRows;
            if (r.Count ==1)
            {
            
           

                int IDA = Convert.ToInt32(r[0].Cells["ID"].Value.ToString());
                Form2Acc f = new Form2Acc(IDA);
                f.D += new Form2Acc.mydel(ShowDGV);
                f.ShowDialog();
            }
            else {
                MessageBox.Show("Chọn hàng cần xóa");
            }
        }

        private void buttonsort_Click(object sender, EventArgs e)
        {

            Model4 db = new Model4();
            var list_sort = db.Accounts.Select(p => p).OrderBy(p => p.Username);
            dtAC.DataSource = list_sort.ToList();
        }

        private void Acount_Enter(object sender, EventArgs e)
        {

        }

        private void textSearchAcc_Leave(object sender, EventArgs e)
        {

            if (textSearchAcc.Text == " ")
            {
                textSearchAcc.Text = "Nhập họ tên user";
                textSearchAcc.ForeColor = Color.Silver;
            }
        }

        private void textSearchAcc_Enter(object sender, EventArgs e)
        {
            if (textSearchAcc.Text == "Nhập họ tên user")
            {
                textSearchAcc.Text = " ";
                textSearchAcc.ForeColor = Color.Black;


            }
        }

        private void Acount_Load(object sender, EventArgs e)
        {
            Model4 db = new Model4();
            var li = db.Accounts.Select(p => p);
            dtAC.DataSource = li.ToList();
        }
    }
}
