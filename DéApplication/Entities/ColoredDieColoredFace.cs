namespace DéApplication.Entities
{
    public class ColoredDieColoredFace
    {
        public int Id { get; set; }
        public int DieId { get; set; }
        public ColoredDie ColoredDie { get; set; }
        public int ColoredFaceId { get; set; }
        public ColoredFace ColoredFace { get; set; }
    }
}
