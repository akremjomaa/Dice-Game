using DéApplication.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DéApplication.Configurations
{
    public class ColoredFaceConfiguration : IEntityTypeConfiguration<ColoredFace>
    {
        public DbSet<ColoredFace> coloredFaces { get; set; }

        public void Configure(EntityTypeBuilder<ColoredFace> builder)
        {
            builder.Property(e => e.Color)
           .IsRequired();
        }
    }
}
