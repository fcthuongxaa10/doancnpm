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
            if (checkBox1.Checked)
                textBox2.PasswordChar = '\0';
            else
                textBox2.PasswordChar = '*';
        }

        private void buttonDN_Click(object sender, EventArgs e)
        {
            if (textBox1.Text !="" && textBox2.Text != "")
            {

                int iduser = BLL.login_BLL.Instance.GetID(textBox1.Text, textBox2.Text);
                if (BLL.login_BLL.Instance.CheckAcc(textBox1.Text, textBox2.Text) ==1)
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
                MessageBox.Show("nhap tai khoan hoac mat khau");
            }
        }
    }
}
