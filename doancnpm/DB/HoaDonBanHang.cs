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
        [Column(Order =1)]
        public string MaHD { get; set; }
        public DateTime NgayLapHD { get; set; }
        public decimal TongTien { get; set; }
        [Key]
        [Column(Order = 2)]
        public int IDNV { set; get; }          
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { set; get; }
        public virtual Account Account { get; set; }
        public HoaDonBanHang()
        {
            this.ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }
    }
}
