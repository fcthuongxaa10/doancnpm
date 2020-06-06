using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doancnpm.DB
{
    [Table("HoaDonBanHang")]
  public  class HoaDonBanHang
    {
        [Key]
        public string MaHD;
        public DateTime NgayLapHD;
        public decimal TongTien;
        public int IDNV;
        [ForeignKey("IDNV")]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { set; get; }
        public virtual Account Account { get; set; }
        public HoaDonBanHang()
        {
            this.ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }
    }
}
