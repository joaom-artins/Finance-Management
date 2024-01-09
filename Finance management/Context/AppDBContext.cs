using Finance_management.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace Finance_management.Context
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }
        public DbSet<Person> Person { get; set; }
        public DbSet<Finance> Finance { get; set; }
        protected override void OnModelCreating(ModelBuilder mb)
        {

        }
    }
}
