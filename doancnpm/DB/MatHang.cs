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
        public string MaHang;
        public string TenHang;
        public int SoLuongSp;
        public decimal Gia;
        public int IDDonViTinh;
        public DateTime NgayNhapKho;
       // [ForeignKey("IDDonViTinh")]
        public virtual ICollection<DonViTinh> DonViTinhs  { set; get; }
        public MatHang()
        {
            this.DonViTinhs = new HashSet<DonViTinh>();
        }
    }
}
