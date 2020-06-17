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
    public partial class Acount : Form
    {
        public Acount()
        {
            InitializeComponent();
        }
        public void ShowDGV()
        {
            Model2 db = new Model2();
            var li = db.Accounts.Select(p => p);
            dtAC.DataSource = li.ToList();

        }
       

        private void buttonsearchacc_Click(object sender, EventArgs e)
        {
            Model2 db = new Model2();
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

        private void buttonaddacc_Click(object sender, EventArgs e)
        {

        }

        private void buttondeleteacc_Click(object sender, EventArgs e)
        {
            Model2 db = new Model2();
            DataGridViewSelectedRowCollection r = dtAC.SelectedRows;
            if (r.Count == 0)
            {
                MessageBox.Show("Vui lonng chon row muon xoa");
            }
            else
            {
                foreach (Account i in db.Accounts)
                {
                    foreach (DataGridViewRow j in r)
                        if (i.ID.ToString() == j.Cells["ID"].Value.ToString())
                        {

                        }
                    db.Accounts.Remove(i);

                }
                db.SaveChanges();
                dtAC.DataSource = db.Accounts.ToList();
            }
        }

        private void buttonupdateacc_Click(object sender, EventArgs e)
        {

        }

        private void Acount_Load(object sender, EventArgs e)
        {
            Model2 db = new Model2();
            var li = db.Accounts.Select(p => p);
            dtAC.DataSource = li.ToList();
        }

        private void textSearchAcc_Enter(object sender, EventArgs e)
        {

            if (textSearchAcc.Text == "Nhập họ tên user ")
            {
                textSearchAcc.Text = "";
                textSearchAcc.ForeColor = Color.Black;


            }
        }

        private void textSearchAcc_Leave(object sender, EventArgs e)
        {
            if (textSearchAcc.Text == "")
            {
                textSearchAcc.Text = "Nhập họ tên user";
                textSearchAcc.ForeColor = Color.Silver;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Model2 db = new Model2();
            var list_sort = db.Accounts.Select(p => p).OrderBy(p => p.Username);
            dtAC.DataSource = list_sort.ToList();
        }
    }
}
