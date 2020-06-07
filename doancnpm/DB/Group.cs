using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doancnpm.DB
{
    [Table("Group")]
    public class Group
    {
        [Key]
        [Required]
        public int IDGroup { set; get; }
        [Required]
        [StringLength(255)]
        public string TenGroup { set; get; }
        public virtual ICollection<Account> Accounts { get; set; }
        public Group()
        {
            this.Accounts = new HashSet<Account>();
        }
    }
}
