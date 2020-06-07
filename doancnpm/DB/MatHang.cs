using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doancnpm.DB
{
    [Table("MatHang")]
    public class MatHang
    {
        [Key]
        [Required]
        [StringLength(50)]
        public string MaHang { get; set; }
        [Required]
        [StringLength(50)]
        public string TenHang { get; set; }
        [Required]
        public int SoLuongSp { get; set; }
        public decimal Gia { get; set; }
     
        [Required]
        public DateTime NgayNhapKho { get; set; }

        public virtual ICollection<ChiTietHoaDon> HoaDonBanHangs { get; set; }
        [Required]
        public int IDDonViTinh { get; set; }
        [ForeignKey("IDDonViTinh")]
        public virtual DonViTinh DonViTinh { get; set; }
    
    }
}
