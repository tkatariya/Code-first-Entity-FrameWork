using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;



namespace EntityFrameWorkAssignment
{
    public class UserContext:DbContext
    {
        public UserContext() : base("UserEntityFramework") 
        {
            Database.SetInitializer(new SeedClass());       
        }
        public DbSet<Users> User { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<Permission> Permissions { get; set; }
    }
}
