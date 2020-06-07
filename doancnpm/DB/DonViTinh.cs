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
        [Required]
        public int IDDonViTinh { get; set; }
        [Required]
        [StringLength(50)]
        public string TenDonViTinh { get; set; }
        public virtual ICollection<MatHang>  MatHang { get; set; }
        public DonViTinh()
        {
            this.MatHang = new HashSet<MatHang>();
        }
    }
}
