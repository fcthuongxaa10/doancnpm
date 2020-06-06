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
        public string MaHD;
        [Key]
        public string MaHang;
        public string SoLuong;
        public string TongTien;
        [ForeignKey("MaHang")]
        public virtual ICollection<MatHang> MatHangs { set; get; }
        public virtual HoaDonBanHang HoaDonBanHang { get; set; }
        public ChiTietHoaDon()
        {
            this.MatHangs = new HashSet<MatHang>();
        }
    }
}
