using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doancnpm.DB
{
    [Table("chiTietHoaDon")]
   public class ChiTietHoaDon
    {
        [Key]
        [Column(Order =1)]
        public string MaHD { set; get; }
        [Key]
        [Column(Order = 2)]
        public string MaHang{ set; get; }
        public string SoLuong { set; get; }
        public string TongTien { set; get; }
        public virtual ICollection<MatHang> MatHangs { set; get; }
        public virtual HoaDonBanHang HoaDonBanHang { get; set; }
        public ChiTietHoaDon()
        {
            this.MatHangs = new HashSet<MatHang>();
        }
    }
}
