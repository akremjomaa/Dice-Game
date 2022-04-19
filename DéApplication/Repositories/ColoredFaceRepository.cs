using DéApplication.DbContexts;
using DéApplication.Entities;

namespace DéApplication.Repositories
{
    public class ColoredFaceRepository : BaseRepository<ColoredFace>
    {
        public ColoredFaceRepository(DiceContext dbContext) : base(dbContext)
        {
        }
    }
}
