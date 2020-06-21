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
    public partial class Admin : Form
    {
        private Form Formchild;
        private int Iduser;

        public int Iduser1 { get => Iduser; set => Iduser = value; }

        public Admin(int s)
        {
            Iduser1=s;
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (Formchild != null)
                Formchild.Close();
            //ActivateButton(btnSender);
            Formchild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(childForm);
            this.panel3.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //  lblTitle.Text = childForm.Text;
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            OpenChildForm(new showadmin(Iduser1), btn);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            OpenChildForm(new ShowNV(), btn);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            OpenChildForm(new HangHoa(), btn);
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {

            Button btn = sender as Button;
            OpenChildForm(new Acount(), btn);
        }

        private void buttondangxuat_Click(object sender, EventArgs e)
        {
            this.Dispose();
            dangnhap dn = new dangnhap();
            dn.ShowDialog();
            
        }
    }
}
