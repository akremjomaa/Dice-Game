namespace DéApplication.Models
{
    public class ColoredDieColoredFaceDto
    {
        public ColoredDieColoredFaceDto(int id , int dieId,int coloredFaceId)
        {
            Id = id;
            DieId = dieId;
            ColoredFaceId = coloredFaceId;

        }
        public int Id { get; set; }
        public int DieId { get; set; }
        public int ColoredFaceId { get; set; }
    }
}
