using DéApplication.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DéApplication.Configurations
{
    public class DieConfiguration : IEntityTypeConfiguration<Die>
    {
        public DbSet<Die> Dies { get; set;}
        public void Configure(EntityTypeBuilder<Die> builder)
        {
         builder
        .HasDiscriminator<string>("Die_Type")
        .HasValue<Die>("die_base")
        .HasValue<NumberedDie>("die_number")
        .HasValue<ColoredDie>("die_color")
        .HasValue<PicturedDie>("die_picture");
        }
    }
}
