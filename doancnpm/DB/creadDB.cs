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
            context.DonViTinhs.Add(new DonViTinh
            {
                IDDonViTinh = 11,
                TenDonViTinh = "Hộp",
            });
            context.DonViTinhs.Add(new DonViTinh
            {
                IDDonViTinh = 12,
                TenDonViTinh = "Thùng",
            });
            context.DonViTinhs.Add(new DonViTinh
            {
                IDDonViTinh = 13,
                TenDonViTinh = "Chai",
            });
            context.MatHangs.Add(new MatHang
            {
                MaHang = "110123a",
                TenHang = "mì tôm",
                SoLuongSp = 10,
                Gia = 100000,  
                IDDonViTinh = 12,
                NgayNhapKho = new DateTime(2019,2,2)
            });
            context.MatHangs.Add(new MatHang
            {
                MaHang = "110431a",
                TenHang = "dầu ăn",
                SoLuongSp = 9,
                Gia = 90000,
                IDDonViTinh = 13,
                NgayNhapKho = new DateTime(2019, 5, 22)
            });
            context.ChiTietHoaDons.Add(new ChiTietHoaDon
            {
                MaHD = "1",
                MaHang = "110123a",
                SoLuong = "3",
                //TongTien =1000000
            });
            context.ChiTietHoaDons.Add(new ChiTietHoaDon
            {
                MaHD = "2",
                MaHang = "110431a",
                SoLuong = "3",
                //TongTien = 1000000
            });
            context.HoaDonBanHangs.Add(new HoaDonBanHang
            {
                MaHD = "1",
             NgayLapHD = new DateTime(2020,3,12),
             TongTien = 300000,
             IDNV = 111,
            });
            context.HoaDonBanHangs.Add(new HoaDonBanHang
            {
                MaHD = "2",
                NgayLapHD = new DateTime(2020, 12, 3),
                TongTien = 150000,
                IDNV = 112,
            });
            context.Accounts.Add(new Account
            {
                ID = 111,
                IDGroup = 2 ,
                IDuser = 102180,
                Username = "fcthuongxaa10",
                PassWord= "123456",
                NgayLap = new DateTime(2020,2,2),
            });
            context.Accounts.Add(new Account
            {
                ID = 112,
                IDGroup = 1,
                IDuser = 102181,
                Username = "epic.theking",
                PassWord = "123456",
                NgayLap = new DateTime(2020, 4, 12),
            });
            context.Groups.Add(new Group
            {
                IDGroup= 1,
               TenGroup = "ADmin"
            });
            context.Groups.Add(new Group
            {
                IDGroup = 2,
                TenGroup = "NhanVien"
            });
            context.USERs.Add(new USER
            {
                IDuser = 102180,
                HoTen = "Lê Trường Sơn",
                SDT = "0326416995",
                SoNgayLam = 0,
                LuongCB =2500000,
                GioiTinh = true,
                NgaySinh =new DateTime(1999,2,2),
                Diachi = "quảng trị",
                SoTienPhat =0,
                SoTienThuong=0,
            });
            context.USERs.Add(new USER
            {
                IDuser= 102181,
                HoTen = "Lê Trường Quân" ,
                SDT = "0393415991",
                SoNgayLam = 0,
                LuongCB = 2500000,
                GioiTinh =false,
                NgaySinh = new DateTime(1999, 3, 3),
                Diachi = "quảng trị",
                SoTienPhat = 0,
                SoTienThuong = 0,
            });
        }

    }
}