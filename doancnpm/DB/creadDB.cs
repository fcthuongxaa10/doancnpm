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
                ID = 102181,
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
                ID = 102180,
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
            context.Accounts.Add(new Account
            {
                ID = 111,
                IDGroup = 2, 
                IDuser = 102180,
                Username = "fcthuongxaa10",
                PassWord = "123456",
                NgayLap = new DateTime(2020,12,23),
            });
            context.Accounts.Add(new Account
            {
                ID = 112,
                IDGroup = 1,
                IDuser = 102181,
                Username = "fcthuongxaa9",
                PassWord = "123456",
                NgayLap = new DateTime(2020, 2, 2),
            });
            context.Groups.Add(new Group
            {
                ID = 1 ,
                TenGroup = "admin",
            });
            context.Groups.Add(new Group
            {
                ID = 2,
                TenGroup = "NhanVien",
            });
            context.HoaDonBanHangs.Add(new HoaDonBanHang
            {
                MaHD = "1",
                NgayLapHD = new DateTime(2020, 9, 9),
                TongTien = 3000000,
                IDNV = 111,
            });
            context.HoaDonBanHangs.Add(new HoaDonBanHang
            {
                MaHD = "2",
                NgayLapHD = new DateTime(2020, 3, 19),
                TongTien = 4000000,
                IDNV = 112,
            });
            context.ChiTietHoaDons.Add(new ChiTietHoaDon
            {
                MaHD = "1",
                MaHang = "110123a",
                SoLuong = "4",
                TongTien = "100000",
            });
            context.ChiTietHoaDons.Add(new ChiTietHoaDon
            {
                MaHD = "2",
                MaHang = "110431a",
                SoLuong = "3",
                TongTien = "90000",
            });
            context.MatHangs.Add(new MatHang
            {
                MaHang = "110123a",
                TenHang ="Mi Tom",
                SoLuongSp = 10,
                Gia = 100000,
                IDDonViTinh = 12,
                NgayNhapKho = new DateTime(2019,12,3),
            });
            context.MatHangs.Add(new MatHang
            {
                MaHang = "110431a",
                TenHang = "dầu ăn",
                SoLuongSp = 20,
                Gia = 200000,
                IDDonViTinh = 13,
                NgayNhapKho = new DateTime(2019, 12, 3),
            });
            context.DonViTinhs.Add(new DonViTinh
            {
                IDDonViTinh =11,
                TenDonViTinh ="hộp",
            });
            context.DonViTinhs.Add(new DonViTinh
            {
                IDDonViTinh = 12,
                TenDonViTinh = "thùng",
            });
            context.DonViTinhs.Add(new DonViTinh
            {
                IDDonViTinh = 13,
                TenDonViTinh = "chai",
            });

        }

    }
}