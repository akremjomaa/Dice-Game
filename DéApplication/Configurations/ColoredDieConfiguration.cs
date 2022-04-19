using DéApplication.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DéApplication.Configurations
{
    public class ColoredDieConfiguration : IEntityTypeConfiguration<ColoredDie>
    {
        public DbSet<Die> Dies { get; set; }
        public void Configure(EntityTypeBuilder<ColoredDie> builder)
        {
          /*  builder
           .Property(b => b.Type)
           .HasColumnName("Type");*/

        }
    }
}
