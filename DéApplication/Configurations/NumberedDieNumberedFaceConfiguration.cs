using DéApplication.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DéApplication.Configurations
{
    public class NumberedDieNumberedFaceConfiguration : IEntityTypeConfiguration<NumberedDieNumberedFace>
    {
        public DbSet<NumberedDieNumberedFace> numberedDieNumberedFaces { get; set; }

        public void Configure(EntityTypeBuilder<NumberedDieNumberedFace> builder)
        {

         //   builder.HasKey(sc => new { sc.DieId, sc.NumberedFaceId });
            builder.HasOne(sc => sc.NumberedDie)
            .WithMany(s => s.NumberedDieNumberedFaces)
            .HasForeignKey(sc => sc.DieId);


            builder.HasOne(sc => sc.NumberedFace)
                .WithMany(s => s.numberedDieNumberedFaces)
                .HasForeignKey(sc => sc.NumberedFaceId);
        }
    }
}
