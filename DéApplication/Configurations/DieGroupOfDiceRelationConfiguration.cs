using DéApplication.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DéApplication.Configurations
{
    public class DieGroupOfDiceRelationConfiguration : IEntityTypeConfiguration<DieGroupOfDice>
    {
        public DbSet<DieGroupOfDice> dieGroupOfDices { get; set; }
        public void Configure(EntityTypeBuilder<DieGroupOfDice> builder)
        {
            builder.HasKey(sc => new { sc.GroupOfDiceId, sc.DieId });
            builder.HasOne(sc => sc.GroupOfDice)
            .WithMany(s => s.dieGroupOfDices)
            .HasForeignKey(sc => sc.GroupOfDiceId);


            builder.HasOne(sc => sc.Die)
                .WithMany(s => s.dieGroupOfDices)
                .HasForeignKey(sc => sc.DieId);

        }
    }
}
