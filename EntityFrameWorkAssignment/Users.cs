using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameWorkAssignment
{
    public class Users
    {
        public Users()
        {
 
        }
        public int Id { get; set; }

        [MaxLength(50), Required]
        public string Fname { get; set; }

        [MaxLength(50), Required]
        public string Lname { get; set; }

        public int? UserTypeId { get; set; }

        public UserType UserTypes { get; set; }

        public ICollection<Permission> permissions { get; set; }


    }
}
