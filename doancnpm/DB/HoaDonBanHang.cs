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
        [Required]
        [StringLength(50)]
        public string MaHD { set; get; }
        [Required]
        public DateTime NgayLapHD { set; get; }
        [Required]
        public decimal TongTien { set; get; }
        [Required]
       
        public virtual ICollection<ChiTietHoaDon> Mathangs { set; get; }
        public int IDNV { set; get; }
        [ForeignKey("IDNV")] 
        public virtual Account Account { get; set; }
     
    }
}
