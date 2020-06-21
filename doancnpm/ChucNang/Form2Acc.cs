using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using doancnpm;
using doancnpm.ChucNang;
using doancnpm.DB;
namespace doancnpm.ChucNang
{
    public partial class Form2Acc : Form
    {
        public delegate void mydel();
        public mydel D;
        public int IDA1 { get; set; }
        public Form2Acc(int x)
        {
            InitializeComponent();
             IDA1 = x;
          
            SetView();
        }

        public void SetView()
        {
            Model4 mh = new Model4();
            if (IDA1 == 0)
            {
                textID.ReadOnly = false;
            }
            else
            {
                textID.ReadOnly = true;
              

                foreach (Account i in mh.Accounts)
                {
                    if (i.ID== IDA1)
                    {
                        textID.Text = i.ID.ToString();
                        textIDuser.Text = i.IDuser.ToString();
                        textIDGroup.Text = i.IDGroup.ToString();
                        textusername.Text = i.Username;
                        textPassword.Text = i.PassWord;
                        dateTimePicker1.Value = i.NgayLap;
                    }
                }
            }
        }



        private void buttonOK_Click(object sender, EventArgs e)
        {
            Model4 db = new Model4();
            if (textID.Text == "" || textIDuser.Text == "" || textIDGroup.Text == "" || textusername.Text == "" || textPassword.Text == "" || dateTimePicker1.Value==null)
            {
                MessageBox.Show("Thiếu Thông Tin Bắt Buộc");
            }
            else
            {
                if (IDA1 == 0)
                {
                    try
                    {
                        Account ac = new Account()
                        {
                            ID = Convert.ToInt32(textID.Text),
                            IDGroup = Convert.ToInt32(textIDGroup.Text),
                            IDuser = Convert.ToInt32(textIDuser.Text),
                            Username = textusername.Text,
                            PassWord = textPassword.Text,
                            NgayLap = dateTimePicker1.Value
                        };
                        db.Accounts.Add(ac);
                        db.SaveChanges();
   
                        MessageBox.Show("Thêm thành công!");
                    }

                    catch (Exception)
                    {
                        MessageBox.Show("ERROR");
                    }
                }


                else
                {
                    try
                    {
                        var ac1 = db.Accounts.Where(p => p.ID == IDA1).FirstOrDefault();
                        ac1.ID = Convert.ToInt32(textID.Text);
                        ac1.IDGroup = Convert.ToInt32(textIDGroup.Text);
                        ac1.IDuser = Convert.ToInt32(textIDuser.Text);
                        ac1.Username = textusername.Text;
                        ac1.PassWord = textPassword.Text;
                        ac1.NgayLap = dateTimePicker1.Value;
                        db.SaveChanges();
                        MessageBox.Show("Chỉnh sửa thành công!");


                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Nhập sai định dạng!");
                    }
                }
                D();
            }
        }


        
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        }
    }

