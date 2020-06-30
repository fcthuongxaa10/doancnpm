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
    public partial class NhanVien2 : Form
    {
        private Form Formchild;
        private int Iduser;

        public int Iduser1 { get => Iduser; set => Iduser = value; }

        public NhanVien2(int s)
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
            OpenChildForm(new ThongtinNv(Iduser1), btn);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            OpenChildForm(new laphoadon(Iduser1), btn);
        }

        private void NhanVien2_Load(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            var li = db.USERs.Where(p => p.ID == Iduser1).FirstOrDefault();
                label1.Text = "WELCOME " + li.HoTen;
             
        }

        private void buttondangxuat_Click(object sender, EventArgs e)
        {
            dangnhap f = new dangnhap();
            f.FormClosed += new FormClosedEventHandler(fclose);
            f.Show();
            this.Hide();
        }
        private void fclose(object sender, EventArgs e)
        {
            this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}