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
        [Required]
        public int ID { get; set; }
        public virtual ICollection<HoaDonBanHang> HoaDonBanHangs { get; set; }
        public Account()
        {
            this.HoaDonBanHangs = new HashSet<HoaDonBanHang>();
        }
        [Required]
        public int IDGroup { get; set; }
        [Required]
        public int IDuser { get; set; }
        [Required]          // cái này là không được phép null
        [StringLength(255)]  // cái này là độ dài tối đa  là 255 ký tự (mạng anh lag quá nên làm tiếp đi mai anh review nha)
        public string Username { get; set; }
        [Required]
        [StringLength(50)]
        public string PassWord { get; set; }
        [Required]
        public DateTime NgayLap { get; set; }
        [ForeignKey("IDuser")]
        public virtual USER USER { get; set; }
        [ForeignKey("IDGroup")]
        public virtual Group Group { get; set; }
       

    }
}
