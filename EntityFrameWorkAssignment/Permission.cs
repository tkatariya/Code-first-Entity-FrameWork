using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace EntityFrameWorkAssignment
{
    public class Permission
    {
        public int Id { get; set; }

        [MaxLength(50), Required]
        public string type { get; set; }

        public ICollection<Users> user { get; set; }
    }
}
