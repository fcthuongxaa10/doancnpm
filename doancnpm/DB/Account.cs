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
        public int ID;
        public int IDGroup;
        public int IDuser;
        public string Username;
        public string PassWord;
        public DateTime NgayLap;
        //[ForeignKey("IDGroup")]
        //[ForeignKey("IDuser")]
        public virtual USER USER { get; set; }
        public virtual Group Group { get; set; }
        public virtual ICollection<HoaDonBanHang> HoaDonBanHangs { get; set; }
        public Account()
        {
            this.HoaDonBanHangs = new HashSet<HoaDonBanHang>();
        }

    }
}
