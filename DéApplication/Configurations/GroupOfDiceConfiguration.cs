using DéApplication.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DéApplication.Configurations
{
    public class GroupOfDiceConfiguration : IEntityTypeConfiguration<GroupOfDice>
    {
        public DbSet<GroupOfDice> groupOfDices { get; set; }

        public void Configure(EntityTypeBuilder<GroupOfDice> builder)
        {
            builder.Property(e => e.Title).IsRequired();
        }
    }
}
