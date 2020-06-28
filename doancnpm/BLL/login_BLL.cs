using doancnpm.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doancnpm.BLL
{
    public class login_BLL
    {
        private static login_BLL _Instance;

        public static login_BLL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new login_BLL();
                return _Instance;
            }
            private set => _Instance = value;
        }

        public int CheckAcc(string username, string pass)
        {
            int Id;
            Model1 Db = new Model1();
            var li = Db.Accounts.Where(p => p.Username == username && p.PassWord == pass).FirstOrDefault();
                Id = li.IDGroup;
            return Id;
             
        }
        public int GetID(string s, string pa)
        {
            try
            {
                Model1 db = new Model1();
                var li = db.Accounts.Where(p => p.Username == s && p.PassWord == pa).FirstOrDefault();
                int iduser = li.IDuser;
                return iduser;
            }
            catch
            {
                return 0;
            }
          }
       
    }
}
