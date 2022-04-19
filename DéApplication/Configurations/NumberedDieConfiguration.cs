using DéApplication.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DéApplication.Configurations
{
    public class NumberedDieConfiguration : IEntityTypeConfiguration<NumberedDie>
    {
        public DbSet<Die> Dies { get; set; }
        public void Configure(EntityTypeBuilder<NumberedDie> builder)
        {
         /*   builder
        .Property(b => b.Type)
        .HasColumnName("Type");*/
        }
    }
}
