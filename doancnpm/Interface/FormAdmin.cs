
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceDA
{
    public partial class FormAdmin : Form
    {

        public FormAdmin()
        {
            InitializeComponent();
            hideSubMenu();
        }

        private void hideSubMenu()
        {
            panelQLHH.Visible = false;
            panelQLNV.Visible = false;
            panelQLAC.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            showSubMenu(panelQLHH);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            showSubMenu(panelQLNV);
        }
        //private Form activeForm = null;
        //private void openChildFormInPanel(Form childForm)
        //{
        //    if (activeForm != null)
        //        activeForm.Close();
        //    activeForm = childForm;
        //    childForm.TopLevel = false;
        //    childForm.FormBorderStyle = FormBorderStyle.None;
        //    childForm.Dock = DockStyle.Fill;
        //    panelChildForm.Controls.Add(childForm);
        //    panelChildForm.Tag = childForm;
        //    childForm.BringToFront();
        //    childForm.Show();
        //}

        private void btDanhsachnhavien_Click(object sender, EventArgs e)
        {

        }

        private void btThemnhanvien_Click(object sender, EventArgs e)
        {

        }

        private void btQuanlihanghoa_Click(object sender, EventArgs e)
        {
            showSubMenu(panelQLHH);
        }

        private void btThemmathang_Click(object sender, EventArgs e)
        {

        }

        private void btDoanhthu_Click(object sender, EventArgs e)
        {

        }

        private void btQuanliaccount_Click(object sender, EventArgs e)
        {
            showSubMenu(panelQLAC);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btThongtincanhan_Click(object sender, EventArgs e)
        {

        }

        private void btQuanlinhanhvien_Click(object sender, EventArgs e)
        {
            showSubMenu(panelQLNV);
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
