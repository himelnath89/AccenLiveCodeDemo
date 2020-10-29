using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunFridayAPI.DataAccess
{
    public class FunFridayDBContext : DbContext
    {
        public FunFridayDBContext()
        {

        }

        public FunFridayDBContext(DbContextOptions<FunFridayDBContext> dbContextOptions):base(dbContextOptions)
        {
            
        }
        public DbSet<Event> Events { get; set; }

    }
}
