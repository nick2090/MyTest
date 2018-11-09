using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EFCodeFirst_01
{
    public class EFDataContext:DbContext
    {
        public EFDataContext() : base("Name=mycodefirst")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<EFDataContext>());
        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
