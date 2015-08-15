using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
//using System.Data.Entity.IDatabaseInitializer;

namespace EntityFrameWorkAssignment
{
    public class SeedClass : DropCreateDatabaseAlways<UserContext>
    {
        protected override void Seed(UserContext context)
        {
            IList<Users> defaultuser = new List<Users>();

            defaultuser.Add(new Users() { Fname = "Tejas", Lname = "Katariya" });
            defaultuser.Add(new Users() { Fname = "Avdhut", Lname = "Pandit" });
            defaultuser.Add(new Users() { Fname = "Mahendra", Lname = "Tandon" });

            foreach (Users user in defaultuser)
                context.User.Add(user);

            base.Seed(context);
        }
        
    }
}
