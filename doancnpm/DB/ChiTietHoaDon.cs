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
        [Column(Order = 1)]
        [Required]
        [StringLength(50)]
        public string MaHD;
        [Key]
        [Column(Order = 2)]
        [Required]
        [StringLength(50)]
        public string MaHang { get; set; }
        [Required]
        [StringLength(50)]
        public string SoLuong { get; set; }
        [Required]
        public decimal TongTien { get; set; }
        public virtual ICollection<MatHang> MatHangs { set; get; }
        public virtual HoaDonBanHang HoaDonBanHang { get; set; }
        public ChiTietHoaDon()
        {
            this.MatHangs = new HashSet<MatHang>();
        }
    }
}
