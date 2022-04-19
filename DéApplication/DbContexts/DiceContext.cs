using DéApplication.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DéApplication.DbContexts
{
    public class DiceContext : DbContext
    {
        public DiceContext(DbContextOptions<DiceContext> options) : base(options)
        {

        }
        public DbSet<Die> Dies { get; set; }
        public DbSet<ColoredDie> Colors { get; set; }
        public DbSet<NumberedDie> Numeros { get; set; }
        public DbSet<GroupOfDice> GroupOfDices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
