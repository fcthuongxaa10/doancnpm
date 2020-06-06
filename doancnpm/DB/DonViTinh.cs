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
        public int IDDonViTinh { get; set; }
        public string TenDonViTinh { get; set; }
        public virtual ICollection<MatHang> MatHangs { get; set; }
        public DonViTinh()
        {
            this.MatHangs = new HashSet<MatHang>();
        }
    }
}
