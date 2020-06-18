using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doancnpm.DB
{
 
    [Table("ChiTietHoaDon")]
    public class ChiTietHoaDon
    {

        [Key, Column(Order = 0)]
        public string MaHang { get; set; }

        [Key, Column(Order = 1)]
        public string MaHD { get; set; }
        public string SoLuong { get; set; }
   

        public virtual HoaDonBanHang HoaDonBanHang { get; set; }
        public virtual MatHang MatHang { get; set; }
    }
}
