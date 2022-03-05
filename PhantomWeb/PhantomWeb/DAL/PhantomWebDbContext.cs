using Microsoft.EntityFrameworkCore;
using PhantomWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhantomWeb.DAL
{
    public class PhantomWebDbContext : DbContext
    {
        public PhantomWebDbContext(DbContextOptions<PhantomWebDbContext> options) : base(options)
        {}

        public DbSet<Banner> Banners { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<Generic> Generics { get; set; }
        public DbSet<Users> Users { get; set; }

    }
}
