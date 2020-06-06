using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doancnpm.DB
{
    [Table("USER")]
  public  class USER
    {
        [Key]
        public int ID;
        public string HoTen;
        public string SDT;
        public int SoNgayLam;
        public decimal LuongCB;
        public Boolean GioiTinh;
        public DateTime NgaySinh;
        public string Diachi;
        public decimal SoTienThuong;
        public decimal SoTienPhat;
       public virtual Account Account { get; set; }

    }
}
