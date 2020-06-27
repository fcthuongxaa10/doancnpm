﻿using doancnpm.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
       
    }
}
