namespace DéApplication.Entities
{
    public class NumberedDieNumberedFace
    {
        public int Id { get; set; }
        public int DieId { get; set; }
        public NumberedDie NumberedDie { get; set; }
        public int NumberedFaceId { get; set; }
        public NumberedFace NumberedFace { get; set; }
    }
}
