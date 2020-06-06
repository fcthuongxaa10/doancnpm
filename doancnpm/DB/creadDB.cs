using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using codefirt;
using doancnpm;
using doancnpm.DB;

namespace codefirt
{
    public class creadDB : CreateDatabaseIfNotExists<Model1>
    {
        protected override void Seed(Model1 context)
        {
            context.USERs.Add(new USER
            {
                ID = 111,
                HoTen = "Lê Trường Sơn",
                SDT = "0326416995",
                SoNgayLam = 0,
                LuongCB = 3200000,
                GioiTinh = true,
                NgaySinh = new DateTime(1999, 2, 2),
                Diachi = "Quảng Trị",
                SoTienThuong = 0,
                SoTienPhat = 0,
            });
            context.USERs.Add(new USER
            {
                ID = 112,
                HoTen = "Lê Trường Quân",
                SDT = "0393415991",
                SoNgayLam = 0,
                LuongCB = 3500000,
                GioiTinh = true,
                NgaySinh = new DateTime(1994, 5, 14),
                Diachi = "Quảng Trị",
                SoTienThuong = 0,
                SoTienPhat = 0,
            });
        }

    }
}