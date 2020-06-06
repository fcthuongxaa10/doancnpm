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
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public int SoLuongSp { get; set; }
        public decimal Gia { get; set; }
        public int IDDonViTinh { get; set; }
        public DateTime NgayNhapKho { get; set; }
        public virtual ICollection<DonViTinh> DonViTinhs  { set; get; }
        public virtual ChiTietHoaDon ChiTietHoaDon { get; set; }
        public virtual DonViTinh DonViTinh { get; set; }
    }
}
