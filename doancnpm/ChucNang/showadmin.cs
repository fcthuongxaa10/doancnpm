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
    public partial class showadmin : Form
    {
        private int Iduser;
        public showadmin(int s)
        {
            Iduser1=s;
            InitializeComponent();
        }

        public int Iduser1 { get => Iduser; set => Iduser = value; }

        

        private void showadmin_Load(object sender, EventArgs e)
        {
            Model4 db = new Model4();
            var li = db.USERs.Where(p => Iduser1 == p.IDUser).FirstOrDefault();
            txtname.Text = li.HoTen;
            txtphone.Text = li.SDT;
            txtId.Text = Iduser1.ToString();
            txtaddress.Text = li.Diachi;
            dateTimePicker1.Value = li.NgaySinh;
            if (radioButton1.Checked)
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
        }
    }
}
