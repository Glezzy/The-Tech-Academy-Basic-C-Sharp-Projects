using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst
{
    class CodeFirstContext : DbContext
    {
        public DbSet < Student > Students
        {
            get; set;
        }

    }
}
