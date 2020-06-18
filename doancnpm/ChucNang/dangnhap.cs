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
                Model4 db = new Model4();
                var li = db.Accounts.Where(p => p.Username == textBox1.Text && p.PassWord == textBox2.Text).FirstOrDefault();
                Id = li.IDGroup;
                iduser = li.IDuser;
            }
            catch (Exception)
            {

            }

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
                MessageBox.Show("Bạn nhập sai user hoặc password. Vui lòng nhập lại!!");
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                textBox1.Text = "";
            if (textBox2.Text != "")
                textBox2.Text = "";
        }

     

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
                textBox2.PasswordChar = '\0';
            else
                textBox2.PasswordChar = '*';

        }
    }
}
