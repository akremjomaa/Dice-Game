using DéApplication.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DéApplication.Configurations
{
    public class PicturedFaceConfiguration : IEntityTypeConfiguration<PicturedFace>
    {
        public DbSet<PicturedFace> picturedFaces { get; set; }
        public void Configure(EntityTypeBuilder<PicturedFace> builder)
        {
            builder.Property(e => e.Picture)
             .IsRequired();
        }
    }
}
