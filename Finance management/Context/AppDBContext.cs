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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasKey(p => p.Id);
            modelBuilder.Entity<Person>().Property(p => p.Name).HasMaxLength(128).IsRequired();
            modelBuilder.Entity<Person>().Property(p => p.Job).HasMaxLength(128).IsRequired();
            modelBuilder.Entity<Person>().Property(p => p.Salary).HasPrecision(18, 2);

            modelBuilder.Entity<Finance>().HasKey(f => f.Id);
            modelBuilder.Entity<Finance>().Property(f => f.Debts).HasPrecision(18, 2);
            modelBuilder.Entity<Finance>().Property(f => f.EmergencyReserve).HasPrecision(18, 2);
            modelBuilder.Entity<Finance>().Property(f => f.MoneyInvested).HasPrecision(18, 2);

           
            modelBuilder.Entity<Finance>().HasOne(f => f.Person).WithOne(p => p.Finance).HasForeignKey<Finance>(f => f.PersonId);
        }
    }
}
