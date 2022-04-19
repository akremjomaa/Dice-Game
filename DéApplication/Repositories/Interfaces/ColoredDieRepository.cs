using DéApplication.DbContexts;
using DéApplication.Entities;

namespace DéApplication.Repositories.Interfaces
{
    public class ColoredDieRepository : BaseRepository<ColoredDie>
    {
        public ColoredDieRepository(DiceContext dbContext) : base(dbContext)
        {
        }
    }
}
