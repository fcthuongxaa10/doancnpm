using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doancnpm.ChucNang
{
    public partial class Form2Acc : Form
    {
        public delegate void mydel();
        public mydel D;
        public int IDA1 { get; set; }
        public Form2Acc(int x)
        {
            int IDA1 = x;
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Model4 db = new Model4();
            if (IDA1 == 0)
            {
                if (Check(Convert.ToInt32(textID.Text), Convert.ToInt32(textIDuser.Text), Convert.ToInt32(textIDGroup.Text), textusername.Text, textPassword.Text, dateTimePicker1.Value))
                {

                    Account sv = new Account
                    {

                    };

                    try
                    {
                        db.SinhVien.Add(sv);
                        this.MSSV = txtMSSV.Text;
                        db.SaveChanges();
                        MessageBox.Show("Thêm thành công!");
                        this.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Nhập sai định dạng!");
                    }
                }

            }
            else
            {
                try
                {
                    var l = db.SinhVien.Where(p => p.MSSV == this.MSSV).FirstOrDefault();
                    l.MSSV = MSSV;
                    l.NameSV = txtNameSV.Text;
                    l.Age = Convert.ToInt32(txtAge.Text);
                    l.ID_Lop = (cbbNameLop.SelectedItem as CBBItems).Values;
                    db.SaveChanges();
                    MessageBox.Show("Chỉnh sửa thành công!");
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Nhập sai định dạng!");
                }
            }
        }
    

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }
        public bool Check(int ID, int IDUser, int IDGroup, string UserName, string password, DateTime NgayLap
            )
        {
            Model4 db = new Model4();
            var l = db.Accounts.Select(p => p);
            if (ID==0 ||IDUser==0|| IDGroup==0|| UserName==""||password==""||NgayLap==null)
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin");
                return false;
            }
            else if (l.ToList().Count == 1)
            {
                MessageBox.Show(" Sinh viên này đã tồn tại vui lòng nhập lại");
                return false;
            }
            else return true;
        }
    }
}
