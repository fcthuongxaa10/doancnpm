using doancnpm.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doancnpm.BLL
{
   public class Showthongtinadmin_BLL
    {
        private static Showthongtinadmin_BLL _instace;

        public static Showthongtinadmin_BLL Instace
        {
            get
            {
                if (_instace == null)
                    _instace = new Showthongtinadmin_BLL();
                return _instace;
            }
           private set => _instace = value;
        }
        public int GetID(string s, string pa)
        {
            Model1 db = new Model1();
            var li = db.Accounts.Where(p => p.Username == s && p.PassWord == pa).FirstOrDefault();
            int iduser = li.IDuser;
            return iduser;
        }
         public USER ThongTin(int Iduser)
        {
            Model1 db = new Model1();
            USER li = db.USERs.Where(p => p.ID == Iduser).FirstOrDefault();              
            return li;
        }

    }
}
