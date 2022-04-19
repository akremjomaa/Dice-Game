using DéApplication.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DéApplication.Configurations
{
    public class PicturedDiePictuedFaceConfiguration : IEntityTypeConfiguration<PicturedDiePictuedFace>
    {
        public DbSet<PicturedDiePictuedFace> picturedDiePictuedFaces { get; set; }
        public void Configure(EntityTypeBuilder<PicturedDiePictuedFace> builder)
        {
           // builder.HasKey(sc => new { sc.DieId, sc.PicturedFaceId });
            builder.HasOne(sc => sc.PicturedDie)
            .WithMany(s => s.PicturedDiePictuedFaces)
            .HasForeignKey(sc => sc.DieId);


            builder.HasOne(sc => sc.PicturedFace)
                .WithMany(s => s.picturedDiePictuedFaces)
                .HasForeignKey(sc => sc.PicturedFaceId);

        }
    }
}
