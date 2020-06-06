using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doancnpm.DB
{
    [Table("Account")]
   public class Account
    {
        [Key]
        [Column(Order = 1)]
        public int ID { set; get; }
        [Key]
        [Column(Order = 2)]
        public int IDGroup { set; get; }
        [Key]
        [Column(Order = 3)]
        public int IDuser { set; get; }
        public string Username { get; set; }
        public string PassWord { get; set; }
        public DateTime NgayLap { get; set; }
        public virtual USER USER { get; set; }
        public virtual Group Group { get; set; }
        public virtual ICollection<HoaDonBanHang> HoaDonBanHangs { get; set; }
        public Account()
        {
            this.HoaDonBanHangs = new HashSet<HoaDonBanHang>();
        }

    }
}
