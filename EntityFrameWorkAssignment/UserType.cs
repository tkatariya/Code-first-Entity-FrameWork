using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace EntityFrameWorkAssignment
{
    public class UserType
    {
        public UserType()
        {
           Users = new Collection<Users>();
        }

        public int Id { get; set; }
        [MaxLength(50), Required]
        public string Name { get; set; }
        public ICollection<Users> Users { get; set; }
    }
}
