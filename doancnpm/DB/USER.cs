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
        public int ID { set; get; }
        public string HoTen { get; set; }
        public string SDT { get; set; }
        public int SoNgayLam { get; set; }
        public decimal LuongCB { get; set; }
        public Boolean GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Diachi { get; set; }
        public decimal SoTienThuong { get; set; }
        public decimal SoTienPhat { get; set; }
        public virtual Account Account { get; set; }
    }
}
