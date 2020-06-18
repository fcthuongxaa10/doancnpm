using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doancnpm.DB
{
    [Table("USER")]
  public  class USER
    {
        [Key]
        [Required]
        public int ID { set; get; }
        [Required]
        [StringLength(255)]
        public string HoTen { set; get; }
        [Required]
        [StringLength(255)]
        public string SDT { set; get; }
        public int SoNgayLam { set; get; }
        [Required]
        public decimal LuongCB { set; get; }
        [Required]
        public Boolean GioiTinh { set; get; }
        [Required]
        public DateTime NgaySinh { set; get; }
        [Required]
        public string Diachi { set; get; }
        public decimal SoTienThuong { set; get; }
        public decimal SoTienPhat { set; get; }

        public virtual ICollection<Account> Account { get; set; }
        public USER()
        {
            this.Account = new HashSet<Account>();
        }
 
    }
}
