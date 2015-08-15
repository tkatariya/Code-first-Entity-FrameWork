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
    class Program
    {
        static void Main(string[] args)
        {
            var ctx = new UserContext();
            ctx.Database.Initialize(true);
          
        }
    }
}
