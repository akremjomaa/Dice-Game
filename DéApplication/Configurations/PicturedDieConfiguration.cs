using DéApplication.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DéApplication.Configurations
{
    public class PicturedDieConfiguration : IEntityTypeConfiguration<PicturedDie>
    {
        public DbSet<Die> Dies { get; set; }
        public void Configure(EntityTypeBuilder<PicturedDie> builder)
        {
           /* builder
          .Property(b => b.Type)
          .HasColumnName("Type");*/
        }
    }
}
