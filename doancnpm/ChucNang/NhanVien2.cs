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
            OpenChildForm(new laphoadon(), btn);
        }
    }
}