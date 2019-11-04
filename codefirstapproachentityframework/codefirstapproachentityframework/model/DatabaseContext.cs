using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefirstapproachentityframework.model
{
    class DatabaseContext:DbContext
    {
        public DbSet<employee> employees { get; set; }
    }
}
