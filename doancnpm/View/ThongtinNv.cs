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
    public partial class ThongtinNv : Form
     
    {
        private int Iduser;
        public ThongtinNv(int s)
        {
            Iduser1=s;
            InitializeComponent();
        }

        public int Iduser1 { get => Iduser; set => Iduser = value; }


        private void ThongtinNv_Load(object sender, EventArgs e)
        {
            USER s = BLL.Showthongtinadmin_BLL.Instace.ThongTin(Iduser1);
            txtname.Text = s.HoTen;
            txtphone.Text = s.SDT;
            txtId.Text = Iduser1.ToString();
            txtaddress.Text = s.Diachi;
            dateTimePicker1.Value = s.NgaySinh;
            if (s.GioiTinh == true)
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = false;
            } 
        }
    }
}
