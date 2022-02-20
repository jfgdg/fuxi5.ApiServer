using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fuxi5.Domain;
using Microsoft.EntityFrameworkCore;

namespace fuxi5.Context
{
   public class Context:DbContext
    {
        public Context(DbContextOptions<Context> op) : base(op)
        {

        }
        public DbSet<Relationship> relationships { get; set; }
        public DbSet<Role> roles { get; set; }
        public DbSet<User> users { get; set; }
    }
}
