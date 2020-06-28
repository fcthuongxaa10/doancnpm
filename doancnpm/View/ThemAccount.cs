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
    public partial class ThemAccount : Form
    {
        public delegate void mydel();
        public mydel D;
        public int IDA1 { get; set; }
        public ThemAccount(int x)
        {
            InitializeComponent();
            IDA1 = x;
            SetView();
        }
        public void SetView()
        {
            Model1 mh = new Model1();
            if (IDA1 == 0)
            {
                textID.ReadOnly = false;
            }
            else
            {
                textID.ReadOnly = true;


                foreach (Account i in mh.Accounts)
                {
                    if (i.ID == IDA1)
                    {
                        textID.Text = i.ID.ToString();
                        textIDNV.Text = i.IDuser.ToString();
                        textGr.Text = i.IDGroup.ToString();
                        textUsername.Text = i.Username;
                        textpassword.Text = i.PassWord;
                        dateTimePicker1.Value = i.NgayLap;
                    }
                }
            }
        }
        public bool Check(string ID, string IDNV, string IDGR, string US, string PW, DateTime NL)
        {
            Model1 db = new Model1();
            List<string> list = new List<string>();
            foreach (Account i in db.Accounts)
            {
                list.Add(i.Username);


                foreach (string m in list)
                {
                    if (textUsername.Text == m)
                    {
                        MessageBox.Show("Username đã tồn tại. Vui lòng nhập username khác");
                        return false;
                    }
                }
            }

             var l = db.Accounts.Select(p => p);
            if (ID == "" || IDNV == "" || IDGR == "" || US == "" || PW == "" || NL == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return false;
            }
         
        
            else return true;
        }

        private void buttonaddacc_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();

            if (IDA1 == 0)
            {
                if (Check(textID.Text, textIDNV.Text, textGr.Text, textUsername.Text, textpassword.Text, dateTimePicker1.Value))
                {
                    Account ac = new Account()
                    {
                        ID = Convert.ToInt32(textID.Text),
                        IDuser = Convert.ToInt32(textIDNV.Text),
                        IDGroup = Convert.ToInt32(textGr.Text),
                        Username = textUsername.Text,
                        PassWord = textpassword.Text,
                        NgayLap = dateTimePicker1.Value
                    };
                    db.Accounts.Add(ac);
                    db.SaveChanges();

                    MessageBox.Show("Thêm thành công!");
                    this.Close();

                }
                else MessageBox.Show("No!");

            }

            else
            {
                try
                {
                    var ac1 = db.Accounts.Where(p => p.ID == IDA1).FirstOrDefault();
                   
                            ac1.ID = Convert.ToInt32(textID.Text);
                            ac1.IDGroup = Convert.ToInt32(textGr.Text);
                            ac1.IDuser = Convert.ToInt32(textIDNV.Text);
                            ac1.Username = textUsername.Text;
                            ac1.PassWord = textpassword.Text;
                            ac1.NgayLap = dateTimePicker1.Value;


                            db.SaveChanges();
                            MessageBox.Show("Chỉnh sửa thành công!");  
                }
                catch (Exception)
                {
                    MessageBox.Show("Error!!!");
                }
            }
                   
            D();
                }
            }



            //private void buttoncancer_Click(object sender, EventArgs e)
            //{
            //    this.Close();
            //}
        }




