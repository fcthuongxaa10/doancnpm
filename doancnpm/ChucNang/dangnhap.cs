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
    public partial class dangnhap : Form
    {
        public dangnhap()
        {
            InitializeComponent();
        }

       
       
        private void buttonDN_Click(object sender, EventArgs e)
        {
            int Id = 0;
            int iduser = 0;

            try
            {
                Model1 db = new Model1();
                var li = db.Accounts.Where(p => p.Username == textBox1.Text && p.PassWord == textBox2.Text).FirstOrDefault();
                Id = li.IDGroup;
                iduser = li.IDuser;
                
            }
            catch (Exception)
            {

            }
            MessageBox.Show(Id.ToString() + 1);
            if (Id!=0)
            {
                if(Id==1)
                {
                    Admin f = new Admin(iduser);
                    f.ShowDialog();
                }
                else
                {
                    NhanVien2 f = new NhanVien2(iduser);
                    f.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Tai khoan khong ton tai");
            }
        }
    }
}
