using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

    public class MvcPuppyContext : DbContext
    {
        public MvcPuppyContext (DbContextOptions<MvcPuppyContext> options)
            : base(options)
        {
        }

        public DbSet<Puppy> Puppy { get; set; } = default!;
    }
