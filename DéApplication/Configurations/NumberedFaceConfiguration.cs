using DéApplication.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DéApplication.Configurations
{
    public class NumberedFaceConfiguration : IEntityTypeConfiguration<NumberedFace>
    {
        public DbSet<NumberedFace> numberedFaces { get; set; }

        public void Configure(EntityTypeBuilder<NumberedFace> builder)
        {
            builder.Property(e => e.FaceNumber)
           .IsRequired();
        }
    }
}
