using DéApplication.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DéApplication.Configurations
{
    public class ColoredDieColoredFaceConfiguration : IEntityTypeConfiguration<ColoredDieColoredFace>
    {
        public DbSet<ColoredDieColoredFace> coloredDieColoredFaces { get; set; } = null!;

        public void Configure(EntityTypeBuilder<ColoredDieColoredFace> builder)
        {
       //   builder.HasKey(sc => new { sc.DieId, sc.ColoredFaceId });
            builder.HasOne(sc => sc.ColoredDie)
            .WithMany(s => s.ColoredDieColoredFaces)
            .HasForeignKey(sc => sc.DieId);


            builder.HasOne(sc => sc.ColoredFace)
                .WithMany(s => s.coloredDieColoredFaces)
                .HasForeignKey(sc => sc.ColoredFaceId);

        }
    }
}
