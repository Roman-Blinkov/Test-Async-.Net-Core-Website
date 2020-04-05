using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Test_Async_.Net_Core_Website;

namespace Test_Async_.Net_Core_Website.Data
{
    public class DefaultContext : DbContext
    {
        public DefaultContext (DbContextOptions<DefaultContext> options)
            : base(options)
        {
        }

        public DbSet<Test_Async_.Net_Core_Website.User> User { get; set; }
    }
}
