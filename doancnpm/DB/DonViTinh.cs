using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doancnpm.DB
{
    [Table("DonViTinh")]
   public class DonViTinh
    {
        [Key]
        public int IDDonViTinh;
        public string TenDonViTinh;
        [ForeignKey("IDDonViTinh")]
        public virtual MatHang MatHang { get; set; }
    }
}
