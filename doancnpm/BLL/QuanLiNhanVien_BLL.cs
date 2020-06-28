using doancnpm.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doancnpm.BLL
{
 public class QuanLiNhanVien_BLL
    {
        private static QuanLiNhanVien_BLL _instance;

        public static QuanLiNhanVien_BLL Instance
        { 
            get
            {
                if (_instance == null)
                    _instance = new QuanLiNhanVien_BLL();
                return _instance;
            }
            set => _instance = value;
        }
        public List<USER> ShowThongTinNhanVien()
        {
           
            Model1 db = new Model1();
            var li = db.USERs.Select(p => p);
            return li.ToList();
                        
        }
        public  List<USER> SearchNV(string name)
        {
            Model1 db = new Model1();
            var li = db.USERs.Where(p => p.HoTen.Contains(name)).ToList();  
            return li;
        }
      public bool DelNV(DataGridViewSelectedRowCollection r)
        {
            Model1 db = new Model1();
            try
            {
                foreach(USER i in db.USERs)
                {
                    foreach (DataGridViewRow j in r)
                    {
                        if (i.ID == Convert.ToInt32(j.Cells["ID"].Value.ToString()))
                        {
                            USER t = i;
                            db.USERs.Remove(t);
                        }
                    }
                }
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
      
        public USER Getusser(int ID)
        {
            Model1 db = new Model1();
            USER s = db.USERs.Where(p => p.ID == ID).FirstOrDefault();
            return s;
        }
        //public bool Savedulieu(USER s)
        //{
        //    Model1 db = new Model1();
        //    db.USERs.Add(s);
        //    db.SaveChanges();
        //    return true;
        //}
        //public bool Edit(USER s)
        //{
        //    Model1 db = new Model1();
        //    try
        //    {
        //        USER user = new USER();
        //        user = Getusser(s.ID);
        //        user.ID = s.ID;
        //        user.HoTen = s.HoTen;
        //        user.Diachi = s.Diachi;
        //        user.SDT = s.SDT;
        //        user.NgaySinh = s.NgaySinh;
        //        user.LuongCB = s.LuongCB;
        //        user.SoNgayLam = s.SoNgayLam;
        //        user.SoTienPhat = s.SoTienPhat;
        //        user.SoTienThuong = s.SoTienThuong;
        //        user.GioiTinh = s.GioiTinh;
        //        db.SaveChanges();
        //        return true;
        //    }
        //    catch (Exception)
        //    {

        //        return false;
        //    }
        //}
    }
}
